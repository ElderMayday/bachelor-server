using System;
using System.Windows.Forms;

using Backend;

namespace Analyzer
{
    public partial class Form1 : Form
    {
        protected Source networkThread;
        protected int interval = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            networkThread = new SourceEmulator();
            timerNetwork.Interval = interval;
            timerNetwork.Enabled = true;
        }

        private void timerNetwork_Tick(object sender, EventArgs e)
        {
            if (networkThread.IsWorking)
            {
                if (networkThread.IsCorrect)
                    label1.Text = networkThread.DataFloat.ToString();
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
