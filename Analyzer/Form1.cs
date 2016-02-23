using System;
using System.Windows.Forms;
using System.Drawing;

using Assets.Backend.Sources;
using Assets.Backend.Filters;

namespace Analyzer
{
    public partial class Form1 : Form
    {
        protected Source source;
        protected Filter filter;
        protected int interval = 100;

        protected int maxPoints = 50;
        protected int currentPoints;
        protected double time;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source = new SourceEmulatorSin();
            filter = new FilterSinglePole(4, 0.5);

            timerNetwork.Interval = interval;
            timerNetwork.Enabled = true;

            time = 0;

            refreshChart();
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

                    label1.Text = "X=" + currentInput + "\nY=" + currentOutput;
                }
                else
                    label1.Text = "Not correct";
            }
            else
            {
                label1.Text = "Not working";
            }
        }

        private void refreshChart()
        {
            currentPoints = 0;
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
            source.Stop();
        }
    }
}
