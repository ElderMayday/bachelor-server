using Assets.Backend.Auxiliary;
using Assets.Backend.Estimators;
using Assets.Backend.Filters;
using Assets.Backend.Noisers;
using Assets.Backend.Sources;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

namespace Analyzer
{
    /// <summary>
    /// Обеспечивает доступ интерфейса к бизнес-логике приложения
    /// </summary>
    public class Access
    {
        public Access(AnalyzerForm _form, Chart _mainChart)
        {
            form = _form;
            mainChart = _mainChart;
        }

        public void Start()
        {
            maxPoints = 100;

            aList = new List<double>();
            bList = new List<double>();

            IsWorking = false;
        }

        public List<IPAddress> GetLocalIp()
        {
            return AddressProvider.GetLocalIp();
        }

        public void Stop()
        {
            if (source != null)
                source.Stop();

            if (udpThread != null)
                udpThread.Stop();
        }

        public void Switch(StrategiesParameters parameters, out string estimate)
        {
            emulatorSettings = parameters.EmulatorSetting;

            estimate = "Нет оценки";

            if (!emulatorSettings.Fast)
            {
                if (IsWorking == false)
                {
                    time = 0.0;

                    IsWorking = true;

                    setStrategies(parameters);

                    refreshChart();

                    if ((source != null) && (filter != null) && (noiser != null))
                        source.Start();
                }
                else
                {
                    IsWorking = false;

                    unsetStrategies();

                    if (IsEmulation)
                    {
                        Estimator estimatorCorrelation = new EstimatorCorrelation(pure, output);
                        Estimator estimatorMinkowski = new EstimatorMinkowski(pure, output, 2.0);
                        Estimator estimatorDistance = new EstimatorDistance(pure, output);

                        estimate = "Коэффициент корреляции=" + String.Format("{0:0.000}", estimatorCorrelation.Estimate()) +
                            "\nРасстояние Минковского=" + String.Format("{0:0.000}", estimatorMinkowski.Estimate()) +
                            "\nРасстояние=" + String.Format("{0:0.000}", estimatorDistance.Estimate());
                    }
                }
            }
            else
            {
                double x = 0.0;

                setStrategies(parameters);

                time = 0.0;

                refreshChart();

                while (x <= emulatorSettings.Range)
                {
                    double currentInput, currentOutput, currentPure;

                    currentInput = ((SourceEmulator)source).GetNext();

                    filter.AddInput(currentInput);

                    currentOutput = filter.GetOutput();
                    currentPure = ((SourceEmulator)source).DataPure;

                    input.Add(currentInput);
                    pure.Add(currentPure);
                    output.Add(currentOutput);

                    mainChart.Series["input"].Points.AddXY(x, currentInput);
                    mainChart.Series["output"].Points.AddXY(x, currentOutput);
                    mainChart.Series["pure"].Points.AddXY(x, currentPure);

                    x += emulatorSettings.Interval / 1000.0;
                }

                Estimator estimatorCorrelation = new EstimatorCorrelation(pure, output);
                Estimator estimatorMinkowski = new EstimatorMinkowski(pure, output, 2.0);
                Estimator estimatorDistance = new EstimatorDistance(pure, output);

                estimate = "Коэффициент корреляции=" + String.Format("{0:0.000}", estimatorCorrelation.Estimate()) +
                    "\nРасстояние Минковского=" + String.Format("{0:0.000}", estimatorMinkowski.Estimate()) +
                    "\nРасстояние=" + String.Format("{0:0.000}", estimatorDistance.Estimate());
            }
        }

        public void TimerTick(out string data)
        {
            if (source.IsWorking)
            {
                if (source.IsCorrect)
                {
                    double currentInput = source.Data;

                    double currentPure = 0.0;

                    if (IsEmulation)
                        currentPure = ((SourceEmulator)source).DataPure;

                    filter.AddInput(currentInput);

                    double currentOutput = filter.GetOutput();

                    output.Add(currentOutput);
                    pure.Add(currentPure);

                    if (currentPoints < maxPoints)
                    {
                        mainChart.Series["input"].Points.AddXY(time, currentInput);
                        mainChart.Series["output"].Points.AddXY(time, currentOutput);

                        if (IsEmulation)
                            mainChart.Series["pure"].Points.AddXY(time, currentPure);

                        time += emulatorSettings.Interval / 1000.0;
                    }
                    else
                    {
                        refreshChart();
                        currentPoints = 0;
                    }

                    currentPoints++;

                    data = "Input = " + String.Format("{0:0.00}", currentInput)
                        + "\nOutput = " + String.Format("{0:0.00}", currentOutput);

                    if (IsEmulation)
                        data += "\nPure = " + String.Format("{0:0.00}", currentPure);
                }
                else
                    data = "Not correct";
            }
            else
            {
                data = "Not working";
            }
        }

        public void AddFourier(double a, double b)
        {
            aList.Add(a);
            bList.Add(b);
        }

        public void ClearFourier()
        {
            aList.Clear();
            bList.Clear();
        }

        


        private void refreshChart()
        {
            mainChart.ChartAreas[0].AxisY.Interval = 25;

            currentPoints = 0;

            foreach (var v in mainChart.Series)
                v.Points.Clear();

            mainChart.Series.Clear();

            mainChart.Series.Add("input");
            mainChart.Series["input"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            mainChart.Series["input"].BorderWidth = 2;

            mainChart.Series.Add("output");
            mainChart.Series["output"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            mainChart.Series["output"].BorderWidth = 2;

            mainChart.Series.Add("pure");
            mainChart.Series["pure"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            mainChart.Series["pure"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            mainChart.Series["pure"].BorderWidth = 2;

            mainChart.ChartAreas[0].AxisX.Minimum = Math.Round(time, 1);
            mainChart.ChartAreas[0].AxisX.Maximum = Math.Round(time + maxPoints * (double) emulatorSettings.Interval / 1000.0, 1);
            mainChart.ChartAreas[0].AxisY.Minimum = -100;
            mainChart.ChartAreas[0].AxisY.Maximum = 100;
        }

        private void setStrategies(StrategiesParameters parameters)
        {
            input = new List<double>();
            output = new List<double>();
            pure = new List<double>();
            noise = new List<double>();

            switch (parameters.Filter)
            {
                case FilterType.MovingAverage:
                    filter = new FilterMovingAverage(parameters.FilterLength);                       break;
                case FilterType.SignlePole:
                    filter = new FilterSinglePole(parameters.FilterLength, parameters.SinglePoleK);  break;
                case FilterType.Gaussian:
                    filter = new FilterGaussian(parameters.FilterLength, parameters.GaussianA);      break;
            }
               
            switch (parameters.Noiser)
            {
                case NoiserType.Idle:
                    noiser = new NoiserIdle();                                                    break;
                case NoiserType.Uniform:
                    noiser = new NoiserUniform(parameters.UniformMin, parameters.UniformMax);     break;
                case NoiserType.Normal:
                    noiser = new NoiserNormal(parameters.NormalMean, parameters.NormalDeviation); break;
                case NoiserType.Function:
                    noiser = new NoiserFunction(ExtraMath.PieceWiseExample1);                     break;
            }

            if (parameters.Source == SourceType.Network)
            {
                udpThread = new UdpThread();
                udpThread.Start();

                IsEmulation = false;

                source = new SourceNetwork(parameters.Axis, parameters.IP);
            }
            else
            {
                IsEmulation = true;

                switch (parameters.Source)
                {
                    case SourceType.Sin:
                        source = new SourceEmulatorSin(emulatorSettings, noiser, parameters.SinAmplitude, parameters.SinAverage, parameters.SinPeriod);
                        break;
                    case SourceType.Linear:
                        source = new SourceEmulatorLinear(emulatorSettings, noiser, parameters.LinearMin, parameters.LinearMax);
                        break;
                    case SourceType.Fourier:
                        source = new SourceEmulatorFourier(emulatorSettings, noiser, parameters.HalftOsset, aList, bList);
                        break;
                }
            }
        }

        private void unsetStrategies()
        {
            if (source != null)
                source.Stop();

            if (udpThread != null)
                udpThread.Stop();

            udpThread = null;
            filter = null;
            noiser = null;
            source = null;
        }



        protected Source source;
        protected Filter filter;
        protected Noiser noiser;
        protected UdpThread udpThread;

        protected EmulatorSettings emulatorSettings;

        protected int maxPoints;
        protected int currentPoints;
        protected double time;

        public bool IsWorking { get; protected set; }
        public bool IsEmulation { get; protected set; }

        public List<double> aList { get; protected set; }
        public List<double> bList { get; protected set; }

        protected List<double> input, output, pure, noise;

        protected AnalyzerForm form;
        protected Chart mainChart;
    }
}
