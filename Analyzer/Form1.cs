using System;
using System.Windows.Forms;

using Assets.Backend.Sources;
using Assets.Backend.Filters;

namespace Analyzer
{
    public partial class Form1 : Form
    {
        protected Source source;
        protected Filter filter;
        protected int interval = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source = new SourceEmulator();
            filter = new FilterMovingAverage(3);

            timerNetwork.Interval = interval;
            timerNetwork.Enabled = true;
        }

        private void timerNetwork_Tick(object sender, EventArgs e)
        {
            if (source.IsWorking)
            {
                if (source.IsCorrect)
                {
                    filter.AddX(source.DataFloat);
                    label1.Text = "X=" + source.DataFloat.ToString() + "\nY=" + filter.GetY();
                }
                else
                    label1.Text = "Not correct";
            }
            else
            {
                label1.Text = "Not working";
            }
        }
    }
}
