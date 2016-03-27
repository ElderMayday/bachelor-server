using Assets.Backend.Auxiliary;
using Assets.Backend.Estimators;
using Assets.Backend.Filters;
using Assets.Backend.Noisers;
using Assets.Backend.Sources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyzer
{
    public class Access
    {
        public Access(Form1 _form)
        {
            form = _form;
        }

        public void Start()
        {
            maxPoints = 100;

            source = null;
            filter = null;

            form.timerNetwork.Enabled = false;

            aList = new List<double>();
            bList = new List<double>();

            isWorking = false;

            refreshChart();

            setGUI();

            hideSources();

            List<IPAddress> list = AddressProvider.GetLocalIp();
            foreach (IPAddress ip in list)
                form.comboIp.Items.Add(ip.ToString());
            form.comboIp.Text = list[list.Count - 1].ToString();
        }

        public void Stop()
        {
            if (source != null)
                source.Stop();

            if (udpThread != null)
                udpThread.Stop();
        }

        public void Switch()
        {
            fast = form.checkBoxFast.Checked && !form.radioSourceNetwork.Checked;
            interval = int.Parse(form.textEmulationInterval.Text);
            range = double.Parse(form.textEmulationRange.Text, CultureInfo.InvariantCulture);
            step = double.Parse(form.textEmulationStep.Text, CultureInfo.InvariantCulture);

            if (!fast)
            {
                if (isWorking == false)
                {
                    time = 0.0;

                    isWorking = true;

                    setStrategies();
                    switchControls(false);

                    form.buttonSwitch.Text = "Выключить";
                    form.timerNetwork.Enabled = true;
                    form.timerNetwork.Interval = interval;

                    refreshChart();

                    if ((source != null) && (filter != null) && (noiser != null))
                        source.Start();
                }
                else
                {
                    isWorking = false;

                    form.buttonSwitch.Text = "Включить";

                    form.timerNetwork.Enabled = false;

                    unsetStrategies();

                    if (udpThread != null)
                        udpThread.Stop();

                    switchControls(true);

                    if (isEmulation)
                    {
                        Estimator estimatorCorrelation = new EstimatorCorrelation(pure, output);
                        Estimator estimatorMinkowski = new EstimatorMinkowski(pure, output, 2.0);
                        Estimator estimatorDistance = new EstimatorDistance(pure, output);

                        form.labelEstimate.Text = "Коэффициент корреляции=" + String.Format("{0:0.000}", estimatorCorrelation.Estimate()) +
                            "\nРасстояние Минковского=" + String.Format("{0:0.000}", estimatorMinkowski.Estimate()) +
                            "\nРасстояние=" + String.Format("{0:0.000}", estimatorDistance.Estimate());
                    }

                    form.textEmulationRange.Enabled = form.checkBoxFast.Checked;
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

                    form.mainChart.Series["input"].Points.AddXY(x, currentInput);
                    form.mainChart.Series["output"].Points.AddXY(x, currentOutput);
                    form.mainChart.Series["pure"].Points.AddXY(x, currentPure);

                    x += interval / 1000.0;
                }

                Estimator estimatorCorrelation = new EstimatorCorrelation(pure, output);
                Estimator estimatorMinkowski = new EstimatorMinkowski(pure, output, 2.0);
                Estimator estimatorDistance = new EstimatorDistance(pure, output);

                form.labelEstimate.Text = "Коэффициент корреляции=" + String.Format("{0:0.000}", estimatorCorrelation.Estimate()) +
                    "\nРасстояние Минковского=" + String.Format("{0:0.000}", estimatorMinkowski.Estimate()) +
                    "\nРасстояние=" + String.Format("{0:0.000}", estimatorDistance.Estimate());
            }
        }

        public void TimerTick()
        {
            if (source.IsWorking)
            {
                if (source.IsCorrect)
                {
                    double currentInput = source.Data;

                    double currentPure = 0.0;

                    if (isEmulation)
                        currentPure = ((SourceEmulator)source).DataPure;

                    filter.AddInput(currentInput);

                    double currentOutput = filter.GetOutput();

                    output.Add(currentOutput);
                    pure.Add(currentPure);

                    if (currentPoints < maxPoints)
                    {
                        form.mainChart.Series["input"].Points.AddXY(time, currentInput);
                        form.mainChart.Series["output"].Points.AddXY(time, currentOutput);

                        if (isEmulation)
                            form.mainChart.Series["pure"].Points.AddXY(time, currentPure);

                        time += interval / 1000.0;
                    }
                    else
                    {
                        refreshChart();
                        currentPoints = 0;
                    }

                    currentPoints++;

                    form.labelData.Text = "Input = " + String.Format("{0:0.00}", currentInput)
                        + "\nOutput = " + String.Format("{0:0.00}", currentOutput);

                    if (isEmulation)
                        form.labelData.Text += "\nPure = " + String.Format("{0:0.00}", currentPure);
                }
                else
                    form.labelData.Text = "Not correct";
            }
            else
            {
                form.labelData.Text = "Not working";
            }
        }

        public void AddFourier()
        {
            string s = form.textSourceFourierCoefficients.Text;

            string[] parameters = s.Split(';');

            if (parameters.Length < 2)
                throw new Exception("Not enough parameters");

            aList.Add(Double.Parse(parameters[0], CultureInfo.InvariantCulture));
            bList.Add(Double.Parse(parameters[1], CultureInfo.InvariantCulture));

            updateListBoxFourier();
        }

        public void ClearFourier()
        {
            aList.Clear();
            bList.Clear();

            updateListBoxFourier();
        }

        public void RadioSourceNetwork()
        {
            form.groupBoxEmultaion.Visible = false;
            hideSources();
            form.groupBoxSourceNetwork.Visible = true;

            if (form.radioSourceNetwork.Checked)
                form.groupBoxNoise.Visible = false;
            else
                form.groupBoxNoise.Visible = true;
        }


        public void RadioSourceEmulatorSin()
        {
            form.groupBoxEmultaion.Visible = true;
            hideSources();
            form.groupBoxSourceSin.Visible = true;
        }

        public void RadioSourceEmulatorLinear()
        {
            form.groupBoxEmultaion.Visible = true;
            hideSources();
            form.groupBoxSourceLinear.Visible = true;
        }

        public void RadioSourceEmulatorFourier()
        {
            form.groupBoxEmultaion.Visible = true;
            hideSources();
            form.groupBoxSourceFourier.Visible = true;
        }

        public void CheckBoxFast()
        {
            form.textEmulationRange.Enabled = form.checkBoxFast.Checked;
        }


        #region GuiExtra

        private void setGUI()
        {
            controls = new List<Control>();

            controls.Add(form.radioFilterMovingAverage);
            controls.Add(form.radioFilterSinglePole);
            controls.Add(form.radioSourceEmulatorLinear);
            controls.Add(form.radioSourceEmulatorSin);
            controls.Add(form.radioSourceNetwork);
            controls.Add(form.radioSourcePitch);
            controls.Add(form.radioSourceRoll);
            controls.Add(form.radioSourceYaw);
            controls.Add(form.comboIp);
            controls.Add(form.textSourceSinAmplitude);
            controls.Add(form.textSourceSinAverage);
            controls.Add(form.textSourceLinearMin);
            controls.Add(form.textSourceLinearMax);
            controls.Add(form.radioNoiserIdle);
            controls.Add(form.radioNoiserUniform);
            controls.Add(form.textNoiseUniformMin);
            controls.Add(form.textNoiseUniformMax);
            controls.Add(form.radioNoiserNormal);
            controls.Add(form.textNoiseNormalMean);
            controls.Add(form.textNoiseNormalDeviation);
            controls.Add(form.radioNoiserFunction);
            controls.Add(form.radioSourceEmulatorFourier);
            controls.Add(form.textSourceFourierHalfOffset);
            controls.Add(form.textSourceFourierCoefficients);
            controls.Add(form.buttonSourceFourierClear);
            controls.Add(form.buttonSourceFourierAdd);
            controls.Add(form.checkBoxFast);
            controls.Add(form.textEmulationRange);
            controls.Add(form.textEmulationStep);
            controls.Add(form.textEmulationInterval);
            controls.Add(form.textSourceSinPeriod);
            controls.Add(form.textFilterLength);
            controls.Add(form.radioFilterGaussian);
            controls.Add(form.textFilterSinglePoleK);
            controls.Add(form.textFilterGaussianA);

            sourceGroups = new List<GroupBox>();

            sourceGroups.Add(form.groupBoxSourceLinear);
            sourceGroups.Add(form.groupBoxSourceSin);
            sourceGroups.Add(form.groupBoxSourceNetwork);
            sourceGroups.Add(form.groupBoxSourceFourier);
        }

        private void refreshChart()
        {
            form.mainChart.ChartAreas[0].AxisY.Interval = 25;

            currentPoints = 0;

            foreach (var v in form.mainChart.Series)
                v.Points.Clear();

            form.mainChart.Series.Clear();

            form.mainChart.Series.Add("input");
            form.mainChart.Series["input"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            form.mainChart.Series["input"].BorderWidth = 2;

            form.mainChart.Series.Add("output");
            form.mainChart.Series["output"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            form.mainChart.Series["output"].BorderWidth = 2;

            form.mainChart.Series.Add("pure");
            form.mainChart.Series["pure"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            form.mainChart.Series["pure"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            form.mainChart.Series["pure"].BorderWidth = 2;

            form.mainChart.ChartAreas[0].AxisX.Minimum = Math.Round(time, 1);
            form.mainChart.ChartAreas[0].AxisX.Maximum = Math.Round(time + maxPoints * (double)interval / 1000.0, 1);
            form.mainChart.ChartAreas[0].AxisY.Minimum = -100;
            form.mainChart.ChartAreas[0].AxisY.Maximum = 100;
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

                isEmulation = false;

                if (form.radioSourcePitch.Checked)
                    source = new SourceNetwork(Axis.Pitch, IPAddress.Parse(form.comboIp.Text));
                else if (form.radioSourceRoll.Checked)
                    source = new SourceNetwork(Axis.Roll, IPAddress.Parse(form.comboIp.Text));
                else if (form.radioSourceYaw.Checked)
                    source = new SourceNetwork(Axis.Yaw, IPAddress.Parse(form.comboIp.Text));
            }
            else
            {
                EmulatorSettings settings = new EmulatorSettings(noiser, interval, step, fast, range);

                isEmulation = true;

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
                if (source.IsWorking)
                    source.Stop();

            if (udpThread != null)
                udpThread.Stop();

            udpThread = null;
            filter = null;
            noiser = null;
            source = null;
        }

        private void switchControls(bool value)
        {
            foreach (Control c in controls)
                c.Enabled = value;
        }

        private void hideSources()
        {
            foreach (GroupBox g in sourceGroups)
                g.Visible = false;
        }

        private void updateListBoxFourier()
        {
            form.listBoxSourceFourierCoefficients.Items.Clear();

            for (int i = 0; i < aList.Count; i++)
            {
                string s = "";

                s += (i + 1).ToString();
                s += ": (" + String.Format("{0:0.00}", aList[i]) + ";";
                s += String.Format("{0:0.00}", bList[i]) + ")";

                form.listBoxSourceFourierCoefficients.Items.Add(s);
            }
        }

        #endregion


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

        protected bool isWorking;
        protected bool isEmulation;

        protected List<Control> controls;
        protected List<GroupBox> sourceGroups;

        protected List<double> aList, bList;
        protected List<double> input, output, pure, noise;

        protected Form1 form;
    }
}
