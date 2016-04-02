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
        /// <summary>
        /// Создает класс доступа
        /// </summary>
        /// <param name="_mainChart">График на котором необходимо визуализировать информацию</param>
        public Access(Chart _mainChart)
        {
            mainChart = _mainChart;

            maxPoints = 100;

            aList = new List<double>();
            bList = new List<double>();

            IsWorking = false;
        }

        /// <summary>
        /// Получает список локальных локальных TCP/IP интерфейсов
        /// </summary>
        /// <returns>Список интерфейсов</returns>
        public List<IPAddress> GetLocalIp()
        {
            return AddressProvider.GetLocalIp();
        }

        /// <summary>
        /// Завершает работу
        /// </summary>
        public void Close()
        {
            if (source != null)
                source.Stop();

            if (udpThread != null)
                udpThread.Stop();
        }

        /// <summary>
        /// Переключает режим работы между вводом данных и анализом
        /// </summary>
        /// <param name="parameters">Структура с параметрами запуск</param>
        /// <param name="correlation">Коэффициент корреляции</param>
        /// <param name="minkowski">Расстояние Минсковского</param>
        /// <param name="distance">Расстояние</param>
        public void Switch(StrategiesParameters parameters, out double correlation, out double minkowski, out double distance)
        {
            emulatorSettings = parameters.EmulatorSetting;

            IsEmulation = parameters.Source != SourceType.Network;

            correlation = 0.0;
            minkowski = 0.0;
            distance = 0.0;

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

                        correlation = estimatorCorrelation.Estimate();
                        minkowski = estimatorMinkowski.Estimate();
                        distance = estimatorDistance.Estimate();
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

                correlation = estimatorCorrelation.Estimate();
                minkowski = estimatorMinkowski.Estimate();
                distance = estimatorDistance.Estimate();
            }
        }

        /// <summary>
        /// Следующий момент времени анализа
        /// </summary>
        /// <param name="isWorking">Флаг работы</param>
        /// <param name="isCorrect">Флаг корректности</param>
        /// <param name="currentInput">Входное значение</param>
        /// <param name="currentOutput">Выходное значение</param>
        /// <param name="currentPure">Чистое значение (для эмуляторов)</param>
        public void TimerTick(out bool isWorking, out bool isCorrect, out double currentInput, out double currentOutput, out double currentPure)
        {
            isCorrect = source.IsCorrect;
            isWorking = source.IsWorking;
            currentInput = 0.0;
            currentOutput = 0.0;
            currentPure = 0.0;

            if (source.IsWorking)
            {
                if (source.IsCorrect)
                {
                    currentInput = source.Data;
                    currentPure = 0.0;

                    if (IsEmulation)
                        currentPure = ((SourceEmulator)source).DataPure;

                    filter.AddInput(currentInput);

                    currentOutput = filter.GetOutput();

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
                }
            }
        }

        

        /// <summary>
        /// Обновляет график
        /// </summary>
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

        /// <summary>
        /// Устанавилвает стратегии
        /// </summary>
        /// <param name="parameters"></param>
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
                        source = new SourceEmulatorFourier(emulatorSettings, noiser, parameters.HalfOffset, parameters.aList, parameters.bList);
                        break;
                }
            }
        }

        /// <summary>
        /// Сбрасывает стратегии
        /// </summary>
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



        /// <summary>
        /// Параметр - флаг работы
        /// </summary>
        public bool IsWorking { get; protected set; }

        /// <summary>
        /// Параметр - флаг эмуляции
        /// </summary>
        public bool IsEmulation { get; protected set; }



        /// <summary>
        /// Источник сигнала
        /// </summary>
        protected Source source;

        /// <summary>
        /// Фильтр
        /// </summary>
        protected Filter filter;

        /// <summary>
        /// Искусственный шум
        /// </summary>
        protected Noiser noiser;

        /// <summary>
        /// UDP обработчик
        /// </summary>
        protected UdpThread udpThread;

        /// <summary>
        /// Настройки эмуляции
        /// </summary>
        protected EmulatorSettings emulatorSettings;

        /// <summary>
        /// Максимальное количество точек на графике
        /// </summary>
        protected int maxPoints;

        /// <summary>
        /// Текущее количество точек на графике
        /// </summary>
        protected int currentPoints;
        
        /// <summary>
        /// текущее время
        /// </summary>
        protected double time;
        
        /// <summary>
        /// Списки коэфиициентов Фурье
        /// </summary>
        protected List<double> aList, bList;

        /// <summary>
        /// Списки с данными сигнала
        /// </summary>
        protected List<double> input, output, pure, noise;

        /// <summary>
        /// График для визуализации
        /// </summary>
        protected Chart mainChart;
    }
}
