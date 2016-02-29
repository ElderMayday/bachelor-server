using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Assets.Backend;
using Assets.Backend.Sources;
using Assets.Backend.Filters;
using System.Net;
using System.Globalization;
using Assets.Backend.Noisers;

namespace Analyzer
{
    public partial class Form1 : Form
    {
        protected Source source;
        protected Filter filter;
        protected Noiser noiser;

        protected UdpThread udpThread;

        protected int interval;
        protected int maxPoints;
        protected int currentPoints;
        protected double time;

        protected bool isWorking;
        protected List<Control> controls;

        #region GuiEvents

        public Form1()
        {
            InitializeComponent();

            interval = 100;
            maxPoints = 50;

            source = null;
            filter = null;

            timerNetwork.Interval = interval;
            timerNetwork.Enabled = false;

            resetChart();

            isWorking = false;      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshChart();

            setControlList();

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

                    filter.AddInput(currentInput);

                    double currentOutput = filter.GetOutput();

                    if (currentPoints < maxPoints)
                    {
                        mainChart.Series["input"].Points.AddXY(time, currentInput);
                        mainChart.Series["output"].Points.AddXY(time, currentOutput);
                        time += 1;
                    }
                    else
                    {
                        refreshChart();
                        currentPoints = 0;
                    }

                    currentPoints++;

                    label1.Text = "Input = " + String.Format("{0:0.00}", currentInput)
                        + "\nOutput = " + String.Format("{0:0.00}", currentOutput);
                }
                else
                    label1.Text = "Not correct";
            }
            else
            {
                label1.Text = "Not working";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (source != null)
                source.Stop();

            if (udpThread != null)
                udpThread.Stop();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (isWorking == false)
            {
                isWorking = true;

                setStrategies();
                switchControls(false);

                buttonSwitch.Text = "Выключить";
                timerNetwork.Enabled = true;

                resetChart();
                refreshChart();
            }
            else
            {
                isWorking = false;

                buttonSwitch.Text = "Включить";

                timerNetwork.Enabled = false;

                source.Stop();

                if (udpThread != null)
                    udpThread.Stop();

                switchControls(true);
            }
        }

        #endregion


        #region GuiExtra

        private void setControlList()
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
            controls.Add(textSourceSinStep);
            controls.Add(textSourceSinAmplitude);
            controls.Add(textSourceSinAverage);
            controls.Add(textSourceLinearMin);
            controls.Add(textSourceLinearMax);
            controls.Add(textSourceLinearStep);
        }

        private void resetChart()
        {
            time = 0;
        }

        private void refreshChart()
        {
            currentPoints = 0;

            foreach (var v in mainChart.Series)
                v.Points.Clear();

            mainChart.Series.Clear();

            mainChart.Series.Add("input");
            mainChart.Series["input"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            mainChart.Series.Add("output");
            mainChart.Series["output"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            mainChart.ChartAreas[0].AxisX.Minimum = time;
            mainChart.ChartAreas[0].AxisX.Maximum = time + maxPoints - 1;
            mainChart.ChartAreas[0].AxisY.Minimum = -100;
            mainChart.ChartAreas[0].AxisY.Maximum = 100;
        }     

        private void setStrategies()
        {
            if (radioFilterMovingAverage.Checked)
                filter = new FilterMovingAverage(5);
            else if (radioFilterSinglePole.Checked)
                filter = new FilterSinglePole(4, 0.5);

            if (radioNoiserIdle.Checked)
                noiser = new NoiserIdle();
            else if (radioNoiserUniform.Checked)
                noiser = new NoiserUniform(float.Parse(textNoiseUniformMin.Text, CultureInfo.InvariantCulture),
                    float.Parse(textNoiseUniformMax.Text, CultureInfo.InvariantCulture));
            else if (radioNoiserNormal.Checked)
                noiser = new NoiserNormal(float.Parse(textNoiseNormalMean.Text, CultureInfo.InvariantCulture),
                    float.Parse(textNoiseNormalDeviation.Text, CultureInfo.InvariantCulture));
            else if (radioNoiserExponential.Checked)
                noiser = new NoiserExponential(float.Parse(textNoiseExponentialLambda.Text, CultureInfo.InvariantCulture));
            else if (radioNoiserErlang.Checked)
                noiser = new NoiserErlang(float.Parse(textNoiseErlangLambda.Text, CultureInfo.InvariantCulture),
                    int.Parse(textNoiseErlangK.Text, CultureInfo.InvariantCulture));

            if (radioSourceNetwork.Checked)
            {
                udpThread = new UdpThread();

                if (radioSourcePitch.Checked)
                    source = new SourceNetwork(Axis.Pitch, IPAddress.Parse(comboIp.Text));
                else if (radioSourceRoll.Checked)
                    source = new SourceNetwork(Axis.Roll, IPAddress.Parse(comboIp.Text));
                else if (radioSourceYaw.Checked)
                    source = new SourceNetwork(Axis.Yaw, IPAddress.Parse(comboIp.Text));
            }
            else if (radioSourceEmulatorSin.Checked)
            {
                source = new SourceEmulatorSin(noiser, double.Parse(textSourceSinStep.Text, CultureInfo.InvariantCulture),
                    double.Parse(textSourceSinAmplitude.Text, CultureInfo.InvariantCulture),
                    double.Parse(textSourceSinAverage.Text, CultureInfo.InvariantCulture));
            }
            else if (radioSourceEmulatorLinear.Checked)
            {
                source = new SourceEmulatorLinear(noiser, double.Parse(textSourceLinearMin.Text, CultureInfo.InvariantCulture),
                    double.Parse(textSourceLinearMax.Text, CultureInfo.InvariantCulture),
                    double.Parse(textSourceLinearStep.Text, CultureInfo.InvariantCulture));
            }
        }

        protected void switchControls(bool value)
        {
            foreach (Control c in controls)
                c.Enabled = value;
        }

        #endregion
    }
}
