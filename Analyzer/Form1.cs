using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Globalization;

using Assets.Backend.Auxiliary;
using Assets.Backend.Sources;
using Assets.Backend.Filters;
using Assets.Backend.Noisers;
using Assets.Backend.Estimators;

namespace Analyzer
{
    public partial class Form1 : Form
    {
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


        #region GuiEvents

        public Form1()
        {
            InitializeComponent();

            Filter filter = new FilterGaussian(3, 0.5);

            maxPoints = 100;

            source = null;
            filter = null;

            timerNetwork.Enabled = false;

            aList = new List<double>();
            bList = new List<double>();

            isWorking = false;      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshChart();

            setGUI();

            hideSources();

            List<IPAddress> list = AddressProvider.GetLocalIp();
            foreach (IPAddress ip in list)
                comboIp.Items.Add(ip.ToString());
            comboIp.Text = list[list.Count - 1].ToString();
        }

        private void timerNetwork_Tick(object sender, EventArgs e)
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
                        mainChart.Series["input"].Points.AddXY(time, currentInput);
                        mainChart.Series["output"].Points.AddXY(time, currentOutput);

                        if (isEmulation)
                            mainChart.Series["pure"].Points.AddXY(time, currentPure);

                        time += interval / 1000.0;
                    }
                    else
                    {
                        refreshChart();
                        currentPoints = 0;
                    }

                    currentPoints++;

                    labelData.Text = "Input = " + String.Format("{0:0.00}", currentInput)
                        + "\nOutput = " + String.Format("{0:0.00}", currentOutput);

                    if (isEmulation)
                        labelData.Text += "\nPure = " + String.Format("{0:0.00}", currentPure);
                }
                else
                    labelData.Text = "Not correct";
            }
            else
            {
                labelData.Text = "Not working";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (source != null)
                if (source.IsWorking)
                    source.Stop();

            if (udpThread != null)
                udpThread.Stop();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            fast = checkBoxFast.Checked && !radioSourceNetwork.Checked;
            interval = int.Parse(textEmulationInterval.Text);
            range = double.Parse(textEmulationRange.Text, CultureInfo.InvariantCulture);
            step = double.Parse(textEmulationStep.Text, CultureInfo.InvariantCulture);

            if (!fast)
            {
                if (isWorking == false)
                {
                    time = 0.0;

                    isWorking = true;

                    setStrategies();
                    switchControls(false);

                    buttonSwitch.Text = "Выключить";
                    timerNetwork.Enabled = true;
                    timerNetwork.Interval = interval;

                    refreshChart();

                    if ((source != null) && (filter != null) && (noiser != null))
                        source.Start();
                }
                else
                {
                    isWorking = false;

                    buttonSwitch.Text = "Включить";

                    timerNetwork.Enabled = false;

                    unsetStrategies();

                    if (udpThread != null)
                        udpThread.Stop();

                    switchControls(true);

                    if (isEmulation)
                    {
                        Estimator estimatorCorrelation = new EstimatorCorrelation(pure, output);
                        Estimator estimatorMinkowski = new EstimatorMinkowski(pure, output, 2.0);

                        labelEstimate.Text = "Correlation = " + String.Format("{0:0.00}", estimatorCorrelation.Estimate()) +
                            "\nMinkowski = " + String.Format("{0:0.00}", estimatorMinkowski.Estimate());
                    }

                    textEmulationRange.Enabled = checkBoxFast.Checked;
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

                labelEstimate.Text = "Correlation = " + String.Format("{0:0.00}", estimatorCorrelation.Estimate()) +
                    "\nMinkowski = " + String.Format("{0:0.00}", estimatorMinkowski.Estimate());
            }
        }

        private void buttonNoiserFourierAdd_Click(object sender, EventArgs e)
        {
            string s = textSourceFourierCoefficients.Text;

            string[] parameters = s.Split(';');

            if (parameters.Length < 2)
                throw new Exception("Not enough parameters");

            aList.Add(Double.Parse(parameters[0], CultureInfo.InvariantCulture));
            bList.Add(Double.Parse(parameters[1], CultureInfo.InvariantCulture));

            updateListBoxFourier();
        }

        private void buttonSourceFourierClear_Click(object sender, EventArgs e)
        {
            aList.Clear();
            bList.Clear();

            updateListBoxFourier();
        }

        private void radioSourceNetwork_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEmultaion.Visible = false;
            hideSources();
            groupBoxSourceNetwork.Visible = true;

            if (radioSourceNetwork.Checked)
                groupBoxNoise.Visible = false;
            else
                groupBoxNoise.Visible = true;
        }

        private void radioSourceEmulatorSin_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEmultaion.Visible = true;
            hideSources();
            groupBoxSourceSin.Visible = true;
        }

        private void radioSourceEmulatorLinear_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEmultaion.Visible = true;
            hideSources();
            groupBoxSourceLinear.Visible = true;
        }

        private void radioSourceEmulatorFourier_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEmultaion.Visible = true;
            hideSources();
            groupBoxSourceFourier.Visible = true;
        }

        private void checkBoxFast_CheckedChanged(object sender, EventArgs e)
        {
            textEmulationRange.Enabled = checkBoxFast.Checked;
        }

        #endregion


        #region GuiExtra

        private void setGUI()
        {
            controls = new List<Control>();

            controls.Add(radioFilterMovingAverage);
            controls.Add(radioFilterSinglePole);
            controls.Add(radioSourceEmulatorLinear);
            controls.Add(radioSourceEmulatorSin);
            controls.Add(radioSourceNetwork);
            controls.Add(radioSourcePitch);
            controls.Add(radioSourceRoll);
            controls.Add(radioSourceYaw);
            controls.Add(comboIp);
            controls.Add(textSourceSinAmplitude);
            controls.Add(textSourceSinAverage);
            controls.Add(textSourceLinearMin);
            controls.Add(textSourceLinearMax);
            controls.Add(radioNoiserIdle);
            controls.Add(radioNoiserUniform);
            controls.Add(textNoiseUniformMin);
            controls.Add(textNoiseUniformMax);
            controls.Add(radioNoiserNormal);
            controls.Add(textNoiseNormalMean);
            controls.Add(textNoiseNormalDeviation);
            controls.Add(radioNoiserFunction);
            controls.Add(radioSourceEmulatorFourier);
            controls.Add(textSourceFourierHalfOffset);
            controls.Add(textSourceFourierCoefficients);
            controls.Add(buttonSourceFourierClear);
            controls.Add(buttonSourceFourierAdd);
            controls.Add(checkBoxFast);
            controls.Add(textEmulationRange);
            controls.Add(textEmulationStep);
            controls.Add(textEmulationInterval);
            controls.Add(textSourceSinPeriod);
            controls.Add(textFilterLength);
            controls.Add(radioFilterGaussian);
            controls.Add(textFilterSinglePoleK);
            controls.Add(textFilterGaussianA);

            sourceGroups = new List<GroupBox>();

            sourceGroups.Add(groupBoxSourceLinear);
            sourceGroups.Add(groupBoxSourceSin);
            sourceGroups.Add(groupBoxSourceNetwork);
            sourceGroups.Add(groupBoxSourceFourier);
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

            if (radioFilterMovingAverage.Checked)
                filter = new FilterMovingAverage(int.Parse(textFilterLength.Text));
            else if (radioFilterSinglePole.Checked)
                filter = new FilterSinglePole(int.Parse(textFilterLength.Text),
                    double.Parse(textFilterSinglePoleK.Text, CultureInfo.InvariantCulture));
            else
                filter = new FilterGaussian(int.Parse(textFilterLength.Text),
                    double.Parse(textFilterGaussianA.Text, CultureInfo.InvariantCulture));

            if (radioNoiserIdle.Checked)
                noiser = new NoiserIdle();
            else if (radioNoiserUniform.Checked)
                noiser = new NoiserUniform(double.Parse(textNoiseUniformMin.Text, CultureInfo.InvariantCulture),
                    double.Parse(textNoiseUniformMax.Text, CultureInfo.InvariantCulture));
            else if (radioNoiserNormal.Checked)
                noiser = new NoiserNormal(double.Parse(textNoiseNormalMean.Text, CultureInfo.InvariantCulture),
                    double.Parse(textNoiseNormalDeviation.Text, CultureInfo.InvariantCulture));
            else if (radioNoiserFunction.Checked)
                noiser = new NoiserFunction(ExtraMath.PieceWiseExample1);

            if (radioSourceNetwork.Checked)
            {
                udpThread = new UdpThread();
                udpThread.Start();

                isEmulation = false;

                if (radioSourcePitch.Checked)
                    source = new SourceNetwork(Axis.Pitch, IPAddress.Parse(comboIp.Text));
                else if (radioSourceRoll.Checked)
                    source = new SourceNetwork(Axis.Roll, IPAddress.Parse(comboIp.Text));
                else if (radioSourceYaw.Checked)
                    source = new SourceNetwork(Axis.Yaw, IPAddress.Parse(comboIp.Text));
            }
            else
            {
                EmulatorSettings settings = new EmulatorSettings(noiser, interval, step, fast, range);

                isEmulation = true;

                if (radioSourceEmulatorSin.Checked)
                {
                    source = new SourceEmulatorSin(settings,
                        double.Parse(textSourceSinAmplitude.Text, CultureInfo.InvariantCulture),
                        double.Parse(textSourceSinAverage.Text, CultureInfo.InvariantCulture),
                        double.Parse(textSourceSinPeriod.Text, CultureInfo.InvariantCulture));
                }
                else if (radioSourceEmulatorLinear.Checked)
                {
                    source = new SourceEmulatorLinear(settings, double.Parse(textSourceLinearMin.Text, CultureInfo.InvariantCulture),
                        double.Parse(textSourceLinearMax.Text, CultureInfo.InvariantCulture));
                }
                else if (radioSourceEmulatorFourier.Checked)
                {
                    source = new SourceEmulatorFourier(settings,
                        double.Parse(textSourceFourierHalfOffset.Text, CultureInfo.InvariantCulture),
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
            listBoxSourceFourierCoefficients.Items.Clear();

            for (int i = 0; i < aList.Count; i++)
            {
                string s = "";

                s += (i + 1).ToString();
                s += ": (" + String.Format("{0:0.00}", aList[i]) + ";";
                s += String.Format("{0:0.00}", bList[i]) + ")";

                listBoxSourceFourierCoefficients.Items.Add(s);
            }
        }

        #endregion

        
    }
}
