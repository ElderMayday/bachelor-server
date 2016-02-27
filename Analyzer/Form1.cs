using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Assets.Backend;
using Assets.Backend.Sources;
using Assets.Backend.Filters;

namespace Analyzer
{
    public partial class Form1 : Form
    {
        protected Source source;
        protected Filter filter;
        protected UdpThread udpThread;

        protected int interval;
        protected int maxPoints;
        protected int currentPoints;
        protected double time;

        protected bool isWorking;

        protected List<Control> controls;

        
            
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

            

            udpThread = new UdpThread();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            refreshChart();

            controls = new List<Control>();

            controls.Add(radioFilterMovingAverage);
            controls.Add(radioFilterSinglePole);
            controls.Add(radioSourceEmulatorLinear);
            controls.Add(radioSourceEmulatorSin);
            controls.Add(radioSourceNetwork);
            controls.Add(radioSourcePitch);
            controls.Add(radioSourceRoll);
            controls.Add(radioSourceYaw);
        }


        private void timerNetwork_Tick(object sender, EventArgs e)
        {
            if (source.IsWorking)
            {
                if (source.IsCorrect)
                {
                    double currentInput = source.DataFloat;

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

                buttonSwitch.Text = "Выключить";

                timerNetwork.Enabled = true;

                if (radioFilterMovingAverage.Checked)
                    filter = new FilterMovingAverage(5);
                else if (radioFilterSinglePole.Checked)
                    filter = new FilterSinglePole(4, 0.5);

                if (radioSourceNetwork.Checked)
                {
                    if (radioSourcePitch.Checked)
                        source = new SourceNetwork(Axis.Pitch);
                    else if (radioSourceRoll.Checked)
                        source = new SourceNetwork(Axis.Roll);
                    else if (radioSourceYaw.Checked)
                        source = new SourceNetwork(Axis.Yaw);
                }
                else if (radioSourceEmulatorSin.Checked)
                    source = new SourceEmulatorSin();
                else if (radioSourceEmulatorLinear.Checked)
                    source = new SourceEmulatorLinear();

                switchControls(false);

                resetChart();
                refreshChart();
            }
            else
            {
                isWorking = false;

                buttonSwitch.Text = "Включить";

                timerNetwork.Enabled = false;
                source.Stop();

                switchControls(true);
            }
        }

        protected void switchControls(bool value)
        {
            foreach (Control c in controls)
                c.Enabled = value;
        }
    }
}
