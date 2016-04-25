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
    public partial class AnalyzerForm : Form
    {
        #region GuiEvents

        public AnalyzerForm()
        {
            InitializeComponent();
        }

        private void analyzerForm_Load(object sender, EventArgs e)
        {
            access = new Access(this.mainChart);

            setGUI();

            hideSources();
            groupBoxSourceSin.Visible = true;

            timerNetwork.Enabled = false;

            List<IPAddress> list = access.GetLocalIp();
            foreach (IPAddress ip in list)
                comboIp.Items.Add(ip.ToString());
            comboIp.Text = list[list.Count - 1].ToString();

            aList = new List<double>();
            bList = new List<double>();
        }

        private void analyzerForm_Closing(object sender, FormClosingEventArgs e)
        {
            access.Close();
        }

        private void timerNetwork_Tick(object sender, EventArgs e)
        {
            bool isWorking, isCorrect;
            double currentInput, currentOutput, currentPure;

            access.TimerTick(out isWorking, out isCorrect, out currentInput, out currentOutput, out currentPure);

            if (isWorking && isCorrect)
            {
                labelData.Text = "Вход = " + String.Format("{0:0.00}", currentInput)
                        + "\nВыход = " + String.Format("{0:0.00}", currentOutput);

                if (access.IsEmulation)
                    labelData.Text += "\nИдеал = " + String.Format("{0:0.00}", currentPure);
            }
            else
            {
                if (!isWorking)
                    labelData.Text = "Не работает";

                if (!isCorrect)
                    labelData.Text = "Не корректные данные";
            }


        }
        
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            EmulatorSettings emulatorSettings = new EmulatorSettings();

            emulatorSettings.Fast = checkBoxFast.Checked && !radioSourceNetwork.Checked;
            emulatorSettings.Interval = int.Parse(textEmulationInterval.Text);
            emulatorSettings.Range = double.Parse(textEmulationRange.Text, CultureInfo.InvariantCulture);
            emulatorSettings.Step = double.Parse(textEmulationStep.Text, CultureInfo.InvariantCulture);

            if (!emulatorSettings.Fast)
            {
                if (!access.IsWorking)
                {
                    buttonSwitch.Text = "Выключить";
                    timerNetwork.Enabled = true;
                    timerNetwork.Interval = emulatorSettings.Interval;

                    switchControls(false);
                }
                else
                {
                    buttonSwitch.Text = "Включить";
                    timerNetwork.Enabled = false;

                    switchControls(true);

                    textEmulationRange.Enabled = checkBoxFast.Checked;
                }
            }

            StrategiesParameters parameters = setParameters(emulatorSettings);

            double correlation, minkowski, distance;

            access.Switch(parameters, out correlation, out minkowski, out distance);

            if (access.IsEmulation)
            {
                labelEstimate.Text = "Коэффициент корреляции=" + String.Format("{0:0.000}", correlation) +
                            "\nРасстояние Минковского=" + String.Format("{0:0.000}", minkowski) +
                            "\nРасстояние=" + String.Format("{0:0.000}", distance);
            }
        }

        private void buttonNoiserFourierAdd_Click(object sender, EventArgs e)
        {
            string s = textSourceFourierCoefficients.Text;

            string[] parameters = s.Split(';');

            if (parameters.Length < 2)
                throw new Exception("Not enough parameters");

            double a = Double.Parse(parameters[0], CultureInfo.InvariantCulture);
            double b = Double.Parse(parameters[1], CultureInfo.InvariantCulture);

            aList.Add(a);
            bList.Add(b);

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

        private StrategiesParameters setParameters(EmulatorSettings emulatorSettings)
        {
            StrategiesParameters parameters = new StrategiesParameters();

            parameters.FilterLength = int.Parse(textFilterLength.Text);

            if (radioFilterMovingAverage.Checked)
                parameters.Filter = FilterType.MovingAverage;
            else if (radioFilterSinglePole.Checked)
            {
                parameters.Filter = FilterType.SignlePole;
                parameters.SinglePoleK = double.Parse(textFilterSinglePoleK.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                parameters.Filter = FilterType.Gaussian;
                parameters.GaussianA = double.Parse(textFilterGaussianA.Text, CultureInfo.InvariantCulture);
            }

            if (radioNoiserIdle.Checked)
            {
                parameters.Noiser = NoiserType.Idle;
            }
            else if (radioNoiserUniform.Checked)
            {
                parameters.Noiser = NoiserType.Uniform;
                parameters.UniformMin = double.Parse(textNoiseUniformMin.Text, CultureInfo.InvariantCulture);
                parameters.UniformMax = double.Parse(textNoiseUniformMax.Text, CultureInfo.InvariantCulture);
            }
            else if (radioNoiserNormal.Checked)
            {
                parameters.Noiser = NoiserType.Normal;
                parameters.NormalMean = double.Parse(textNoiseNormalMean.Text, CultureInfo.InvariantCulture);
                parameters.NormalDeviation = double.Parse(textNoiseNormalDeviation.Text, CultureInfo.InvariantCulture);
            }
            else
                parameters.Noiser = NoiserType.Function;

            if (radioSourceNetwork.Checked)
            {
                parameters.Source = SourceType.Network;
                parameters.IP = IPAddress.Parse(comboIp.Text);

                if (radioSourcePitch.Checked)
                    parameters.Axis = RotationAxis.Pitch;
                else if (radioSourceRoll.Checked)
                    parameters.Axis = RotationAxis.Roll;
                else
                    parameters.Axis = RotationAxis.Yaw;
            }
            else if (radioSourceEmulatorSin.Checked)
            {
                parameters.Source = SourceType.Sin;
                parameters.SinAmplitude = double.Parse(textSourceSinAmplitude.Text, CultureInfo.InvariantCulture);
                parameters.SinAverage = double.Parse(textSourceSinAverage.Text, CultureInfo.InvariantCulture);
                parameters.SinPeriod = double.Parse(textSourceSinPeriod.Text, CultureInfo.InvariantCulture);
            }
            else if (radioSourceEmulatorLinear.Checked)
            {
                parameters.Source = SourceType.Linear;
                parameters.LinearMin = double.Parse(textSourceLinearMin.Text, CultureInfo.InvariantCulture);
                parameters.LinearMax = double.Parse(textSourceLinearMax.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                parameters.Source = SourceType.Fourier;
                parameters.HalfOffset = double.Parse(textSourceFourierHalfOffset.Text, CultureInfo.InvariantCulture);
                parameters.aList = aList;
                parameters.bList = bList;
            }

            parameters.EmulatorSetting = emulatorSettings;

            return parameters;
        }

        private void hideSources()
        {
            foreach (GroupBox g in sourceGroups)
                g.Visible = false;
        }

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

        private void switchControls(bool value)
        {
            foreach (Control c in controls)
                c.Enabled = value;
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

        private Access access;

        private List<Control> controls;

        private List<GroupBox> sourceGroups;

        private List<double> aList, bList;
    }
}
