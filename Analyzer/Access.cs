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

            refreshChart();
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

        public void Switch(bool _fast, int _interval, double _range, double _step, out string estimate)
        {
            fast = _fast;
            interval = _interval;
            range = _range;
            step = _step;

            estimate = "Нет оценки";

            if (!fast)
            {
                if (IsWorking == false)
                {
                    time = 0.0;

                    IsWorking = true;

                    setStrategies();

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

                setStrategies();

                time = 0.0;

                refreshChart();

                while (x <= range)
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

                    x += interval / 1000.0;
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

                        time += interval / 1000.0;
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
            mainChart.ChartAreas[0].AxisX.Maximum = Math.Round(time + maxPoints * (double)interval / 1000.0, 1);
            mainChart.ChartAreas[0].AxisY.Minimum = -100;
            mainChart.ChartAreas[0].AxisY.Maximum = 100;
        }

        private void setStrategies()
        {
            input = new List<double>();
            output = new List<double>();
            pure = new List<double>();
            noise = new List<double>();

            if (form.radioFilterMovingAverage.Checked)
                filter = new FilterMovingAverage(int.Parse(form.textFilterLength.Text));
            else if (form.radioFilterSinglePole.Checked)
                filter = new FilterSinglePole(int.Parse(form.textFilterLength.Text),
                    double.Parse(form.textFilterSinglePoleK.Text, CultureInfo.InvariantCulture));
            else
                filter = new FilterGaussian(int.Parse(form.textFilterLength.Text),
                    double.Parse(form.textFilterGaussianA.Text, CultureInfo.InvariantCulture));

            if (form.radioNoiserIdle.Checked)
                noiser = new NoiserIdle();
            else if (form.radioNoiserUniform.Checked)
                noiser = new NoiserUniform(double.Parse(form.textNoiseUniformMin.Text, CultureInfo.InvariantCulture),
                    double.Parse(form.textNoiseUniformMax.Text, CultureInfo.InvariantCulture));
            else if (form.radioNoiserNormal.Checked)
                noiser = new NoiserNormal(double.Parse(form.textNoiseNormalMean.Text, CultureInfo.InvariantCulture),
                    double.Parse(form.textNoiseNormalDeviation.Text, CultureInfo.InvariantCulture));
            else if (form.radioNoiserFunction.Checked)
                noiser = new NoiserFunction(ExtraMath.PieceWiseExample1);

            if (form.radioSourceNetwork.Checked)
            {
                udpThread = new UdpThread();
                udpThread.Start();

                IsEmulation = false;

                if (form.radioSourcePitch.Checked)
                    source = new SourceNetwork(RotationAxis.Pitch, IPAddress.Parse(form.comboIp.Text));
                else if (form.radioSourceRoll.Checked)
                    source = new SourceNetwork(RotationAxis.Roll, IPAddress.Parse(form.comboIp.Text));
                else if (form.radioSourceYaw.Checked)
                    source = new SourceNetwork(RotationAxis.Yaw, IPAddress.Parse(form.comboIp.Text));
            }
            else
            {
                EmulatorSettings settings = new EmulatorSettings(noiser, interval, step, fast, range);

                IsEmulation = true;

                if (form.radioSourceEmulatorSin.Checked)
                {
                    source = new SourceEmulatorSin(settings,
                        double.Parse(form.textSourceSinAmplitude.Text, CultureInfo.InvariantCulture),
                        double.Parse(form.textSourceSinAverage.Text, CultureInfo.InvariantCulture),
                        double.Parse(form.textSourceSinPeriod.Text, CultureInfo.InvariantCulture));
                }
                else if (form.radioSourceEmulatorLinear.Checked)
                {
                    source = new SourceEmulatorLinear(settings, double.Parse(form.textSourceLinearMin.Text, CultureInfo.InvariantCulture),
                        double.Parse(form.textSourceLinearMax.Text, CultureInfo.InvariantCulture));
                }
                else if (form.radioSourceEmulatorFourier.Checked)
                {
                    source = new SourceEmulatorFourier(settings,
                        double.Parse(form.textSourceFourierHalfOffset.Text, CultureInfo.InvariantCulture),
                        aList, bList);
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

        protected int interval;
        protected double range;
        protected bool fast;
        protected double step;

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
