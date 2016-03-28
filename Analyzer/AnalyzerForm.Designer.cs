namespace Analyzer
{
    partial class AnalyzerForm
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timerNetwork = new System.Windows.Forms.Timer(this.components);
            this.labelData = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.labelFilterLength = new System.Windows.Forms.Label();
            this.textFilterLength = new System.Windows.Forms.TextBox();
            this.labelFilterGaussianA = new System.Windows.Forms.Label();
            this.textFilterGaussianA = new System.Windows.Forms.TextBox();
            this.labelFilterSinglePoleK = new System.Windows.Forms.Label();
            this.textFilterSinglePoleK = new System.Windows.Forms.TextBox();
            this.radioFilterGaussian = new System.Windows.Forms.RadioButton();
            this.radioFilterSinglePole = new System.Windows.Forms.RadioButton();
            this.radioFilterMovingAverage = new System.Windows.Forms.RadioButton();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelEstimate = new System.Windows.Forms.Label();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.groupBoxEmultaion = new System.Windows.Forms.GroupBox();
            this.labelEmulatorInterval = new System.Windows.Forms.Label();
            this.textEmulationInterval = new System.Windows.Forms.TextBox();
            this.labelEmulatorStep = new System.Windows.Forms.Label();
            this.labelEmulationRange = new System.Windows.Forms.Label();
            this.textEmulationStep = new System.Windows.Forms.TextBox();
            this.textEmulationRange = new System.Windows.Forms.TextBox();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            this.groupBoxSourceFourier = new System.Windows.Forms.GroupBox();
            this.buttonSourceFourierClear = new System.Windows.Forms.Button();
            this.textSourceFourierCoefficients = new System.Windows.Forms.TextBox();
            this.textSourceFourierHalfOffset = new System.Windows.Forms.TextBox();
            this.buttonSourceFourierAdd = new System.Windows.Forms.Button();
            this.labelNoiserFourierHalfOffset = new System.Windows.Forms.Label();
            this.labelNoiserFourierCoefficients = new System.Windows.Forms.Label();
            this.listBoxSourceFourierCoefficients = new System.Windows.Forms.ListBox();
            this.groupBoxSourceSin = new System.Windows.Forms.GroupBox();
            this.labelSinPeriod = new System.Windows.Forms.Label();
            this.textSourceSinPeriod = new System.Windows.Forms.TextBox();
            this.labelSinAverage = new System.Windows.Forms.Label();
            this.labelSinAmplitude = new System.Windows.Forms.Label();
            this.textSourceSinAverage = new System.Windows.Forms.TextBox();
            this.textSourceSinAmplitude = new System.Windows.Forms.TextBox();
            this.radioSourceEmulatorFourier = new System.Windows.Forms.RadioButton();
            this.radioSourceEmulatorLinear = new System.Windows.Forms.RadioButton();
            this.groupBoxNoise = new System.Windows.Forms.GroupBox();
            this.radioNoiserFunction = new System.Windows.Forms.RadioButton();
            this.labelNoiseNormalDeviation = new System.Windows.Forms.Label();
            this.labelNoiseNormalMean = new System.Windows.Forms.Label();
            this.labelNoiseIdleMax = new System.Windows.Forms.Label();
            this.labelNoiseIdleMin = new System.Windows.Forms.Label();
            this.textNoiseNormalMean = new System.Windows.Forms.TextBox();
            this.textNoiseNormalDeviation = new System.Windows.Forms.TextBox();
            this.textNoiseUniformMax = new System.Windows.Forms.TextBox();
            this.textNoiseUniformMin = new System.Windows.Forms.TextBox();
            this.radioNoiserNormal = new System.Windows.Forms.RadioButton();
            this.radioNoiserUniform = new System.Windows.Forms.RadioButton();
            this.radioNoiserIdle = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceLinear = new System.Windows.Forms.GroupBox();
            this.labelLinearMax = new System.Windows.Forms.Label();
            this.labelLinearMin = new System.Windows.Forms.Label();
            this.textSourceLinearMax = new System.Windows.Forms.TextBox();
            this.textSourceLinearMin = new System.Windows.Forms.TextBox();
            this.radioSourceEmulatorSin = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceNetwork = new System.Windows.Forms.GroupBox();
            this.labelInterface = new System.Windows.Forms.Label();
            this.radioSourceYaw = new System.Windows.Forms.RadioButton();
            this.comboIp = new System.Windows.Forms.ComboBox();
            this.radioSourceRoll = new System.Windows.Forms.RadioButton();
            this.radioSourcePitch = new System.Windows.Forms.RadioButton();
            this.radioSourceNetwork = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBoxPanel.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxEmultaion.SuspendLayout();
            this.groupBoxSourceFourier.SuspendLayout();
            this.groupBoxSourceSin.SuspendLayout();
            this.groupBoxNoise.SuspendLayout();
            this.groupBoxSourceLinear.SuspendLayout();
            this.groupBoxSourceNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerNetwork
            // 
            this.timerNetwork.Tick += new System.EventHandler(this.timerNetwork_Tick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(6, 18);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(45, 13);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "No data";
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(12, 12);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(989, 381);
            this.mainChart.TabIndex = 1;
            this.mainChart.Text = "MainChart";
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxPanel.Controls.Add(this.groupBoxFilter);
            this.groupBoxPanel.Controls.Add(this.groupBoxData);
            this.groupBoxPanel.Controls.Add(this.groupBoxSource);
            this.groupBoxPanel.Location = new System.Drawing.Point(12, 399);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(989, 279);
            this.groupBoxPanel.TabIndex = 2;
            this.groupBoxPanel.TabStop = false;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFilter.Controls.Add(this.labelFilterLength);
            this.groupBoxFilter.Controls.Add(this.textFilterLength);
            this.groupBoxFilter.Controls.Add(this.labelFilterGaussianA);
            this.groupBoxFilter.Controls.Add(this.textFilterGaussianA);
            this.groupBoxFilter.Controls.Add(this.labelFilterSinglePoleK);
            this.groupBoxFilter.Controls.Add(this.textFilterSinglePoleK);
            this.groupBoxFilter.Controls.Add(this.radioFilterGaussian);
            this.groupBoxFilter.Controls.Add(this.radioFilterSinglePole);
            this.groupBoxFilter.Controls.Add(this.radioFilterMovingAverage);
            this.groupBoxFilter.Location = new System.Drawing.Point(828, 13);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(155, 260);
            this.groupBoxFilter.TabIndex = 3;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Фильтр";
            // 
            // labelFilterLength
            // 
            this.labelFilterLength.AutoSize = true;
            this.labelFilterLength.Location = new System.Drawing.Point(7, 20);
            this.labelFilterLength.Name = "labelFilterLength";
            this.labelFilterLength.Size = new System.Drawing.Size(51, 13);
            this.labelFilterLength.TabIndex = 8;
            this.labelFilterLength.Text = "Порядок";
            // 
            // textFilterLength
            // 
            this.textFilterLength.Location = new System.Drawing.Point(77, 18);
            this.textFilterLength.Name = "textFilterLength";
            this.textFilterLength.Size = new System.Drawing.Size(32, 20);
            this.textFilterLength.TabIndex = 7;
            this.textFilterLength.Text = "5";
            // 
            // labelFilterGaussianA
            // 
            this.labelFilterGaussianA.AutoSize = true;
            this.labelFilterGaussianA.Location = new System.Drawing.Point(7, 178);
            this.labelFilterGaussianA.Name = "labelFilterGaussianA";
            this.labelFilterGaussianA.Size = new System.Drawing.Size(14, 13);
            this.labelFilterGaussianA.TabIndex = 6;
            this.labelFilterGaussianA.Text = "A";
            // 
            // textFilterGaussianA
            // 
            this.textFilterGaussianA.Location = new System.Drawing.Point(30, 171);
            this.textFilterGaussianA.Name = "textFilterGaussianA";
            this.textFilterGaussianA.Size = new System.Drawing.Size(81, 20);
            this.textFilterGaussianA.TabIndex = 5;
            this.textFilterGaussianA.Text = "0.5";
            // 
            // labelFilterSinglePoleK
            // 
            this.labelFilterSinglePoleK.AutoSize = true;
            this.labelFilterSinglePoleK.Location = new System.Drawing.Point(7, 121);
            this.labelFilterSinglePoleK.Name = "labelFilterSinglePoleK";
            this.labelFilterSinglePoleK.Size = new System.Drawing.Size(14, 13);
            this.labelFilterSinglePoleK.TabIndex = 4;
            this.labelFilterSinglePoleK.Text = "K";
            // 
            // textFilterSinglePoleK
            // 
            this.textFilterSinglePoleK.Location = new System.Drawing.Point(30, 117);
            this.textFilterSinglePoleK.Name = "textFilterSinglePoleK";
            this.textFilterSinglePoleK.Size = new System.Drawing.Size(81, 20);
            this.textFilterSinglePoleK.TabIndex = 3;
            this.textFilterSinglePoleK.Text = "0.5";
            // 
            // radioFilterGaussian
            // 
            this.radioFilterGaussian.AutoSize = true;
            this.radioFilterGaussian.Location = new System.Drawing.Point(10, 144);
            this.radioFilterGaussian.Name = "radioFilterGaussian";
            this.radioFilterGaussian.Size = new System.Drawing.Size(60, 17);
            this.radioFilterGaussian.TabIndex = 2;
            this.radioFilterGaussian.TabStop = true;
            this.radioFilterGaussian.Text = "Гаусса";
            this.radioFilterGaussian.UseVisualStyleBackColor = true;
            // 
            // radioFilterSinglePole
            // 
            this.radioFilterSinglePole.AutoSize = true;
            this.radioFilterSinglePole.Location = new System.Drawing.Point(10, 93);
            this.radioFilterSinglePole.Name = "radioFilterSinglePole";
            this.radioFilterSinglePole.Size = new System.Drawing.Size(101, 17);
            this.radioFilterSinglePole.TabIndex = 1;
            this.radioFilterSinglePole.Text = "Однополярный";
            this.radioFilterSinglePole.UseVisualStyleBackColor = true;
            // 
            // radioFilterMovingAverage
            // 
            this.radioFilterMovingAverage.AutoSize = true;
            this.radioFilterMovingAverage.Checked = true;
            this.radioFilterMovingAverage.Location = new System.Drawing.Point(10, 68);
            this.radioFilterMovingAverage.Name = "radioFilterMovingAverage";
            this.radioFilterMovingAverage.Size = new System.Drawing.Size(134, 17);
            this.radioFilterMovingAverage.TabIndex = 0;
            this.radioFilterMovingAverage.TabStop = true;
            this.radioFilterMovingAverage.Text = "Скользящая средняя";
            this.radioFilterMovingAverage.UseVisualStyleBackColor = true;
            // 
            // groupBoxData
            // 
            this.groupBoxData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxData.Controls.Add(this.labelEstimate);
            this.groupBoxData.Controls.Add(this.buttonSwitch);
            this.groupBoxData.Controls.Add(this.labelData);
            this.groupBoxData.Location = new System.Drawing.Point(11, 13);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(304, 161);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // labelEstimate
            // 
            this.labelEstimate.AutoSize = true;
            this.labelEstimate.Location = new System.Drawing.Point(6, 58);
            this.labelEstimate.Name = "labelEstimate";
            this.labelEstimate.Size = new System.Drawing.Size(63, 13);
            this.labelEstimate.TabIndex = 2;
            this.labelEstimate.Text = "No estimate";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(9, 107);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(113, 33);
            this.buttonSwitch.TabIndex = 1;
            this.buttonSwitch.Text = "Включить";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSource.Controls.Add(this.groupBoxEmultaion);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceFourier);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceSin);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorFourier);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorLinear);
            this.groupBoxSource.Controls.Add(this.groupBoxNoise);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceLinear);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorSin);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceNetwork);
            this.groupBoxSource.Controls.Add(this.radioSourceNetwork);
            this.groupBoxSource.Location = new System.Drawing.Point(321, 13);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(501, 260);
            this.groupBoxSource.TabIndex = 1;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Источник";
            // 
            // groupBoxEmultaion
            // 
            this.groupBoxEmultaion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxEmultaion.Controls.Add(this.labelEmulatorInterval);
            this.groupBoxEmultaion.Controls.Add(this.textEmulationInterval);
            this.groupBoxEmultaion.Controls.Add(this.labelEmulatorStep);
            this.groupBoxEmultaion.Controls.Add(this.labelEmulationRange);
            this.groupBoxEmultaion.Controls.Add(this.textEmulationStep);
            this.groupBoxEmultaion.Controls.Add(this.textEmulationRange);
            this.groupBoxEmultaion.Controls.Add(this.checkBoxFast);
            this.groupBoxEmultaion.Location = new System.Drawing.Point(9, 107);
            this.groupBoxEmultaion.Name = "groupBoxEmultaion";
            this.groupBoxEmultaion.Size = new System.Drawing.Size(150, 124);
            this.groupBoxEmultaion.TabIndex = 31;
            this.groupBoxEmultaion.TabStop = false;
            this.groupBoxEmultaion.Text = "Эмуляция";
            this.groupBoxEmultaion.Visible = false;
            // 
            // labelEmulatorInterval
            // 
            this.labelEmulatorInterval.AutoSize = true;
            this.labelEmulatorInterval.Location = new System.Drawing.Point(5, 98);
            this.labelEmulatorInterval.Name = "labelEmulatorInterval";
            this.labelEmulatorInterval.Size = new System.Drawing.Size(56, 13);
            this.labelEmulatorInterval.TabIndex = 36;
            this.labelEmulatorInterval.Text = "Интервал";
            // 
            // textEmulationInterval
            // 
            this.textEmulationInterval.Location = new System.Drawing.Point(67, 95);
            this.textEmulationInterval.Name = "textEmulationInterval";
            this.textEmulationInterval.Size = new System.Drawing.Size(61, 20);
            this.textEmulationInterval.TabIndex = 35;
            this.textEmulationInterval.Text = "100";
            // 
            // labelEmulatorStep
            // 
            this.labelEmulatorStep.AutoSize = true;
            this.labelEmulatorStep.Location = new System.Drawing.Point(5, 75);
            this.labelEmulatorStep.Name = "labelEmulatorStep";
            this.labelEmulatorStep.Size = new System.Drawing.Size(27, 13);
            this.labelEmulatorStep.TabIndex = 34;
            this.labelEmulatorStep.Text = "Шаг";
            // 
            // labelEmulationRange
            // 
            this.labelEmulationRange.AutoSize = true;
            this.labelEmulationRange.Location = new System.Drawing.Point(5, 51);
            this.labelEmulationRange.Name = "labelEmulationRange";
            this.labelEmulationRange.Size = new System.Drawing.Size(40, 13);
            this.labelEmulationRange.TabIndex = 33;
            this.labelEmulationRange.Text = "Длина";
            // 
            // textEmulationStep
            // 
            this.textEmulationStep.Location = new System.Drawing.Point(67, 72);
            this.textEmulationStep.Name = "textEmulationStep";
            this.textEmulationStep.Size = new System.Drawing.Size(61, 20);
            this.textEmulationStep.TabIndex = 32;
            this.textEmulationStep.Text = "5.0";
            // 
            // textEmulationRange
            // 
            this.textEmulationRange.Enabled = false;
            this.textEmulationRange.Location = new System.Drawing.Point(67, 48);
            this.textEmulationRange.Name = "textEmulationRange";
            this.textEmulationRange.Size = new System.Drawing.Size(61, 20);
            this.textEmulationRange.TabIndex = 31;
            this.textEmulationRange.Text = "100.0";
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(122, 17);
            this.checkBoxFast.TabIndex = 30;
            this.checkBoxFast.Text = "Быстрая эмуляция";
            this.checkBoxFast.UseVisualStyleBackColor = true;
            this.checkBoxFast.CheckedChanged += new System.EventHandler(this.checkBoxFast_CheckedChanged);
            // 
            // groupBoxSourceFourier
            // 
            this.groupBoxSourceFourier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceFourier.Controls.Add(this.buttonSourceFourierClear);
            this.groupBoxSourceFourier.Controls.Add(this.textSourceFourierCoefficients);
            this.groupBoxSourceFourier.Controls.Add(this.textSourceFourierHalfOffset);
            this.groupBoxSourceFourier.Controls.Add(this.buttonSourceFourierAdd);
            this.groupBoxSourceFourier.Controls.Add(this.labelNoiserFourierHalfOffset);
            this.groupBoxSourceFourier.Controls.Add(this.labelNoiserFourierCoefficients);
            this.groupBoxSourceFourier.Controls.Add(this.listBoxSourceFourierCoefficients);
            this.groupBoxSourceFourier.Location = new System.Drawing.Point(173, 11);
            this.groupBoxSourceFourier.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSourceFourier.Name = "groupBoxSourceFourier";
            this.groupBoxSourceFourier.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSourceFourier.Size = new System.Drawing.Size(165, 220);
            this.groupBoxSourceFourier.TabIndex = 29;
            this.groupBoxSourceFourier.TabStop = false;
            // 
            // buttonSourceFourierClear
            // 
            this.buttonSourceFourierClear.Location = new System.Drawing.Point(7, 154);
            this.buttonSourceFourierClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSourceFourierClear.Name = "buttonSourceFourierClear";
            this.buttonSourceFourierClear.Size = new System.Drawing.Size(66, 20);
            this.buttonSourceFourierClear.TabIndex = 29;
            this.buttonSourceFourierClear.Text = "Очистить";
            this.buttonSourceFourierClear.UseVisualStyleBackColor = true;
            this.buttonSourceFourierClear.Click += new System.EventHandler(this.buttonSourceFourierClear_Click);
            // 
            // textSourceFourierCoefficients
            // 
            this.textSourceFourierCoefficients.Location = new System.Drawing.Point(81, 130);
            this.textSourceFourierCoefficients.Margin = new System.Windows.Forms.Padding(2);
            this.textSourceFourierCoefficients.Name = "textSourceFourierCoefficients";
            this.textSourceFourierCoefficients.Size = new System.Drawing.Size(80, 20);
            this.textSourceFourierCoefficients.TabIndex = 24;
            this.textSourceFourierCoefficients.Text = "10.0;0.0";
            // 
            // textSourceFourierHalfOffset
            // 
            this.textSourceFourierHalfOffset.Location = new System.Drawing.Point(81, 13);
            this.textSourceFourierHalfOffset.Margin = new System.Windows.Forms.Padding(2);
            this.textSourceFourierHalfOffset.Name = "textSourceFourierHalfOffset";
            this.textSourceFourierHalfOffset.Size = new System.Drawing.Size(81, 20);
            this.textSourceFourierHalfOffset.TabIndex = 21;
            this.textSourceFourierHalfOffset.Text = "0.0";
            // 
            // buttonSourceFourierAdd
            // 
            this.buttonSourceFourierAdd.Location = new System.Drawing.Point(81, 154);
            this.buttonSourceFourierAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSourceFourierAdd.Name = "buttonSourceFourierAdd";
            this.buttonSourceFourierAdd.Size = new System.Drawing.Size(80, 20);
            this.buttonSourceFourierAdd.TabIndex = 28;
            this.buttonSourceFourierAdd.Text = "Добавить";
            this.buttonSourceFourierAdd.UseVisualStyleBackColor = true;
            this.buttonSourceFourierAdd.Click += new System.EventHandler(this.buttonNoiserFourierAdd_Click);
            // 
            // labelNoiserFourierHalfOffset
            // 
            this.labelNoiserFourierHalfOffset.AutoSize = true;
            this.labelNoiserFourierHalfOffset.Location = new System.Drawing.Point(12, 16);
            this.labelNoiserFourierHalfOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoiserFourierHalfOffset.Name = "labelNoiserFourierHalfOffset";
            this.labelNoiserFourierHalfOffset.Size = new System.Drawing.Size(61, 13);
            this.labelNoiserFourierHalfOffset.TabIndex = 20;
            this.labelNoiserFourierHalfOffset.Text = "Смещение";
            // 
            // labelNoiserFourierCoefficients
            // 
            this.labelNoiserFourierCoefficients.AutoSize = true;
            this.labelNoiserFourierCoefficients.Location = new System.Drawing.Point(76, 36);
            this.labelNoiserFourierCoefficients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoiserFourierCoefficients.Name = "labelNoiserFourierCoefficients";
            this.labelNoiserFourierCoefficients.Size = new System.Drawing.Size(85, 13);
            this.labelNoiserFourierCoefficients.TabIndex = 22;
            this.labelNoiserFourierCoefficients.Text = "Коэффициенты";
            // 
            // listBoxSourceFourierCoefficients
            // 
            this.listBoxSourceFourierCoefficients.FormattingEnabled = true;
            this.listBoxSourceFourierCoefficients.Location = new System.Drawing.Point(80, 57);
            this.listBoxSourceFourierCoefficients.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSourceFourierCoefficients.Name = "listBoxSourceFourierCoefficients";
            this.listBoxSourceFourierCoefficients.Size = new System.Drawing.Size(81, 69);
            this.listBoxSourceFourierCoefficients.TabIndex = 26;
            // 
            // groupBoxSourceSin
            // 
            this.groupBoxSourceSin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceSin.Controls.Add(this.labelSinPeriod);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinPeriod);
            this.groupBoxSourceSin.Controls.Add(this.labelSinAverage);
            this.groupBoxSourceSin.Controls.Add(this.labelSinAmplitude);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinAverage);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinAmplitude);
            this.groupBoxSourceSin.Location = new System.Drawing.Point(173, 11);
            this.groupBoxSourceSin.Name = "groupBoxSourceSin";
            this.groupBoxSourceSin.Size = new System.Drawing.Size(166, 203);
            this.groupBoxSourceSin.TabIndex = 4;
            this.groupBoxSourceSin.TabStop = false;
            // 
            // labelSinPeriod
            // 
            this.labelSinPeriod.AutoSize = true;
            this.labelSinPeriod.Location = new System.Drawing.Point(0, 84);
            this.labelSinPeriod.Name = "labelSinPeriod";
            this.labelSinPeriod.Size = new System.Drawing.Size(45, 13);
            this.labelSinPeriod.TabIndex = 7;
            this.labelSinPeriod.Text = "Период";
            // 
            // textSourceSinPeriod
            // 
            this.textSourceSinPeriod.Location = new System.Drawing.Point(64, 81);
            this.textSourceSinPeriod.Name = "textSourceSinPeriod";
            this.textSourceSinPeriod.Size = new System.Drawing.Size(81, 20);
            this.textSourceSinPeriod.TabIndex = 6;
            this.textSourceSinPeriod.Text = "6.28";
            // 
            // labelSinAverage
            // 
            this.labelSinAverage.AutoSize = true;
            this.labelSinAverage.Location = new System.Drawing.Point(2, 59);
            this.labelSinAverage.Name = "labelSinAverage";
            this.labelSinAverage.Size = new System.Drawing.Size(50, 13);
            this.labelSinAverage.TabIndex = 5;
            this.labelSinAverage.Text = "Средняя";
            // 
            // labelSinAmplitude
            // 
            this.labelSinAmplitude.AutoSize = true;
            this.labelSinAmplitude.Location = new System.Drawing.Point(2, 36);
            this.labelSinAmplitude.Name = "labelSinAmplitude";
            this.labelSinAmplitude.Size = new System.Drawing.Size(62, 13);
            this.labelSinAmplitude.TabIndex = 4;
            this.labelSinAmplitude.Text = "Амплитуда";
            // 
            // textSourceSinAverage
            // 
            this.textSourceSinAverage.Location = new System.Drawing.Point(64, 56);
            this.textSourceSinAverage.Name = "textSourceSinAverage";
            this.textSourceSinAverage.Size = new System.Drawing.Size(81, 20);
            this.textSourceSinAverage.TabIndex = 2;
            this.textSourceSinAverage.Text = "10.0";
            // 
            // textSourceSinAmplitude
            // 
            this.textSourceSinAmplitude.Location = new System.Drawing.Point(64, 33);
            this.textSourceSinAmplitude.Name = "textSourceSinAmplitude";
            this.textSourceSinAmplitude.Size = new System.Drawing.Size(81, 20);
            this.textSourceSinAmplitude.TabIndex = 1;
            this.textSourceSinAmplitude.Text = "30.0";
            // 
            // radioSourceEmulatorFourier
            // 
            this.radioSourceEmulatorFourier.AutoSize = true;
            this.radioSourceEmulatorFourier.Location = new System.Drawing.Point(6, 81);
            this.radioSourceEmulatorFourier.Margin = new System.Windows.Forms.Padding(2);
            this.radioSourceEmulatorFourier.Name = "radioSourceEmulatorFourier";
            this.radioSourceEmulatorFourier.Size = new System.Drawing.Size(111, 17);
            this.radioSourceEmulatorFourier.TabIndex = 27;
            this.radioSourceEmulatorFourier.Text = "Эмулятор Фурье";
            this.radioSourceEmulatorFourier.UseVisualStyleBackColor = true;
            this.radioSourceEmulatorFourier.CheckedChanged += new System.EventHandler(this.radioSourceEmulatorFourier_CheckedChanged);
            // 
            // radioSourceEmulatorLinear
            // 
            this.radioSourceEmulatorLinear.AutoSize = true;
            this.radioSourceEmulatorLinear.Location = new System.Drawing.Point(6, 58);
            this.radioSourceEmulatorLinear.Name = "radioSourceEmulatorLinear";
            this.radioSourceEmulatorLinear.Size = new System.Drawing.Size(127, 17);
            this.radioSourceEmulatorLinear.TabIndex = 2;
            this.radioSourceEmulatorLinear.Text = "Эмулятор линейный";
            this.radioSourceEmulatorLinear.UseVisualStyleBackColor = true;
            this.radioSourceEmulatorLinear.CheckedChanged += new System.EventHandler(this.radioSourceEmulatorLinear_CheckedChanged);
            // 
            // groupBoxNoise
            // 
            this.groupBoxNoise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNoise.Controls.Add(this.radioNoiserFunction);
            this.groupBoxNoise.Controls.Add(this.labelNoiseNormalDeviation);
            this.groupBoxNoise.Controls.Add(this.labelNoiseNormalMean);
            this.groupBoxNoise.Controls.Add(this.labelNoiseIdleMax);
            this.groupBoxNoise.Controls.Add(this.labelNoiseIdleMin);
            this.groupBoxNoise.Controls.Add(this.textNoiseNormalMean);
            this.groupBoxNoise.Controls.Add(this.textNoiseNormalDeviation);
            this.groupBoxNoise.Controls.Add(this.textNoiseUniformMax);
            this.groupBoxNoise.Controls.Add(this.textNoiseUniformMin);
            this.groupBoxNoise.Controls.Add(this.radioNoiserNormal);
            this.groupBoxNoise.Controls.Add(this.radioNoiserUniform);
            this.groupBoxNoise.Controls.Add(this.radioNoiserIdle);
            this.groupBoxNoise.Location = new System.Drawing.Point(343, 11);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Size = new System.Drawing.Size(141, 220);
            this.groupBoxNoise.TabIndex = 6;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "Шум";
            // 
            // radioNoiserFunction
            // 
            this.radioNoiserFunction.AutoSize = true;
            this.radioNoiserFunction.Location = new System.Drawing.Point(15, 176);
            this.radioNoiserFunction.Margin = new System.Windows.Forms.Padding(2);
            this.radioNoiserFunction.Name = "radioNoiserFunction";
            this.radioNoiserFunction.Size = new System.Drawing.Size(72, 17);
            this.radioNoiserFunction.TabIndex = 19;
            this.radioNoiserFunction.TabStop = true;
            this.radioNoiserFunction.Text = "Кусочная";
            this.radioNoiserFunction.UseVisualStyleBackColor = true;
            // 
            // labelNoiseNormalDeviation
            // 
            this.labelNoiseNormalDeviation.AutoSize = true;
            this.labelNoiseNormalDeviation.Location = new System.Drawing.Point(1, 153);
            this.labelNoiseNormalDeviation.Name = "labelNoiseNormalDeviation";
            this.labelNoiseNormalDeviation.Size = new System.Drawing.Size(64, 13);
            this.labelNoiseNormalDeviation.TabIndex = 14;
            this.labelNoiseNormalDeviation.Text = "Дисперсия";
            // 
            // labelNoiseNormalMean
            // 
            this.labelNoiseNormalMean.AutoSize = true;
            this.labelNoiseNormalMean.Location = new System.Drawing.Point(6, 133);
            this.labelNoiseNormalMean.Name = "labelNoiseNormalMean";
            this.labelNoiseNormalMean.Size = new System.Drawing.Size(52, 13);
            this.labelNoiseNormalMean.TabIndex = 13;
            this.labelNoiseNormalMean.Text = "Медиана";
            // 
            // labelNoiseIdleMax
            // 
            this.labelNoiseIdleMax.AutoSize = true;
            this.labelNoiseIdleMax.Location = new System.Drawing.Point(5, 92);
            this.labelNoiseIdleMax.Name = "labelNoiseIdleMax";
            this.labelNoiseIdleMax.Size = new System.Drawing.Size(37, 13);
            this.labelNoiseIdleMax.TabIndex = 12;
            this.labelNoiseIdleMax.Text = "Макс.";
            // 
            // labelNoiseIdleMin
            // 
            this.labelNoiseIdleMin.AutoSize = true;
            this.labelNoiseIdleMin.Location = new System.Drawing.Point(6, 70);
            this.labelNoiseIdleMin.Name = "labelNoiseIdleMin";
            this.labelNoiseIdleMin.Size = new System.Drawing.Size(31, 13);
            this.labelNoiseIdleMin.TabIndex = 11;
            this.labelNoiseIdleMin.Text = "Мин.";
            // 
            // textNoiseNormalMean
            // 
            this.textNoiseNormalMean.Location = new System.Drawing.Point(63, 129);
            this.textNoiseNormalMean.Name = "textNoiseNormalMean";
            this.textNoiseNormalMean.Size = new System.Drawing.Size(63, 20);
            this.textNoiseNormalMean.TabIndex = 10;
            this.textNoiseNormalMean.Text = "0.0";
            // 
            // textNoiseNormalDeviation
            // 
            this.textNoiseNormalDeviation.Location = new System.Drawing.Point(63, 151);
            this.textNoiseNormalDeviation.Name = "textNoiseNormalDeviation";
            this.textNoiseNormalDeviation.Size = new System.Drawing.Size(63, 20);
            this.textNoiseNormalDeviation.TabIndex = 7;
            this.textNoiseNormalDeviation.Text = "10.0";
            // 
            // textNoiseUniformMax
            // 
            this.textNoiseUniformMax.Location = new System.Drawing.Point(63, 90);
            this.textNoiseUniformMax.Name = "textNoiseUniformMax";
            this.textNoiseUniformMax.Size = new System.Drawing.Size(63, 20);
            this.textNoiseUniformMax.TabIndex = 6;
            this.textNoiseUniformMax.Text = "10.0";
            // 
            // textNoiseUniformMin
            // 
            this.textNoiseUniformMin.Location = new System.Drawing.Point(63, 66);
            this.textNoiseUniformMin.Name = "textNoiseUniformMin";
            this.textNoiseUniformMin.Size = new System.Drawing.Size(63, 20);
            this.textNoiseUniformMin.TabIndex = 5;
            this.textNoiseUniformMin.Text = "-10.0";
            // 
            // radioNoiserNormal
            // 
            this.radioNoiserNormal.AutoSize = true;
            this.radioNoiserNormal.Location = new System.Drawing.Point(15, 108);
            this.radioNoiserNormal.Name = "radioNoiserNormal";
            this.radioNoiserNormal.Size = new System.Drawing.Size(91, 17);
            this.radioNoiserNormal.TabIndex = 2;
            this.radioNoiserNormal.Text = "Нормальный";
            this.radioNoiserNormal.UseVisualStyleBackColor = true;
            // 
            // radioNoiserUniform
            // 
            this.radioNoiserUniform.AutoSize = true;
            this.radioNoiserUniform.Location = new System.Drawing.Point(15, 48);
            this.radioNoiserUniform.Name = "radioNoiserUniform";
            this.radioNoiserUniform.Size = new System.Drawing.Size(96, 17);
            this.radioNoiserUniform.TabIndex = 1;
            this.radioNoiserUniform.Text = "Равномерный";
            this.radioNoiserUniform.UseVisualStyleBackColor = true;
            // 
            // radioNoiserIdle
            // 
            this.radioNoiserIdle.AutoSize = true;
            this.radioNoiserIdle.Checked = true;
            this.radioNoiserIdle.Location = new System.Drawing.Point(15, 25);
            this.radioNoiserIdle.Name = "radioNoiserIdle";
            this.radioNoiserIdle.Size = new System.Drawing.Size(44, 17);
            this.radioNoiserIdle.TabIndex = 0;
            this.radioNoiserIdle.TabStop = true;
            this.radioNoiserIdle.Text = "Нет";
            this.radioNoiserIdle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSourceLinear
            // 
            this.groupBoxSourceLinear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearMax);
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearMin);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearMax);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearMin);
            this.groupBoxSourceLinear.Location = new System.Drawing.Point(169, 10);
            this.groupBoxSourceLinear.Name = "groupBoxSourceLinear";
            this.groupBoxSourceLinear.Size = new System.Drawing.Size(166, 198);
            this.groupBoxSourceLinear.TabIndex = 5;
            this.groupBoxSourceLinear.TabStop = false;
            // 
            // labelLinearMax
            // 
            this.labelLinearMax.AutoSize = true;
            this.labelLinearMax.Location = new System.Drawing.Point(6, 36);
            this.labelLinearMax.Name = "labelLinearMax";
            this.labelLinearMax.Size = new System.Drawing.Size(37, 13);
            this.labelLinearMax.TabIndex = 3;
            this.labelLinearMax.Text = "Макс.";
            // 
            // labelLinearMin
            // 
            this.labelLinearMin.AutoSize = true;
            this.labelLinearMin.Location = new System.Drawing.Point(6, 12);
            this.labelLinearMin.Name = "labelLinearMin";
            this.labelLinearMin.Size = new System.Drawing.Size(31, 13);
            this.labelLinearMin.TabIndex = 2;
            this.labelLinearMin.Text = "Мин.";
            // 
            // textSourceLinearMax
            // 
            this.textSourceLinearMax.Location = new System.Drawing.Point(45, 32);
            this.textSourceLinearMax.Name = "textSourceLinearMax";
            this.textSourceLinearMax.Size = new System.Drawing.Size(100, 20);
            this.textSourceLinearMax.TabIndex = 1;
            this.textSourceLinearMax.Text = "90.0";
            // 
            // textSourceLinearMin
            // 
            this.textSourceLinearMin.Location = new System.Drawing.Point(45, 10);
            this.textSourceLinearMin.Name = "textSourceLinearMin";
            this.textSourceLinearMin.Size = new System.Drawing.Size(100, 20);
            this.textSourceLinearMin.TabIndex = 0;
            this.textSourceLinearMin.Text = "-90.0";
            // 
            // radioSourceEmulatorSin
            // 
            this.radioSourceEmulatorSin.AutoSize = true;
            this.radioSourceEmulatorSin.Checked = true;
            this.radioSourceEmulatorSin.Location = new System.Drawing.Point(6, 36);
            this.radioSourceEmulatorSin.Name = "radioSourceEmulatorSin";
            this.radioSourceEmulatorSin.Size = new System.Drawing.Size(162, 17);
            this.radioSourceEmulatorSin.TabIndex = 1;
            this.radioSourceEmulatorSin.TabStop = true;
            this.radioSourceEmulatorSin.Text = "Эмулятор синусоидальный";
            this.radioSourceEmulatorSin.UseVisualStyleBackColor = true;
            this.radioSourceEmulatorSin.CheckedChanged += new System.EventHandler(this.radioSourceEmulatorSin_CheckedChanged);
            // 
            // groupBoxSourceNetwork
            // 
            this.groupBoxSourceNetwork.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxSourceNetwork.Controls.Add(this.labelInterface);
            this.groupBoxSourceNetwork.Controls.Add(this.radioSourceYaw);
            this.groupBoxSourceNetwork.Controls.Add(this.comboIp);
            this.groupBoxSourceNetwork.Controls.Add(this.radioSourceRoll);
            this.groupBoxSourceNetwork.Controls.Add(this.radioSourcePitch);
            this.groupBoxSourceNetwork.Location = new System.Drawing.Point(171, 11);
            this.groupBoxSourceNetwork.Name = "groupBoxSourceNetwork";
            this.groupBoxSourceNetwork.Size = new System.Drawing.Size(167, 203);
            this.groupBoxSourceNetwork.TabIndex = 3;
            this.groupBoxSourceNetwork.TabStop = false;
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Location = new System.Drawing.Point(6, 82);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(17, 13);
            this.labelInterface.TabIndex = 7;
            this.labelInterface.Text = "IP";
            // 
            // radioSourceYaw
            // 
            this.radioSourceYaw.AutoSize = true;
            this.radioSourceYaw.Location = new System.Drawing.Point(18, 56);
            this.radioSourceYaw.Name = "radioSourceYaw";
            this.radioSourceYaw.Size = new System.Drawing.Size(76, 17);
            this.radioSourceYaw.TabIndex = 2;
            this.radioSourceYaw.Text = "Рысканье";
            this.radioSourceYaw.UseVisualStyleBackColor = true;
            // 
            // comboIp
            // 
            this.comboIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIp.FormattingEnabled = true;
            this.comboIp.Location = new System.Drawing.Point(29, 79);
            this.comboIp.Name = "comboIp";
            this.comboIp.Size = new System.Drawing.Size(116, 21);
            this.comboIp.TabIndex = 6;
            // 
            // radioSourceRoll
            // 
            this.radioSourceRoll.AutoSize = true;
            this.radioSourceRoll.Location = new System.Drawing.Point(18, 33);
            this.radioSourceRoll.Name = "radioSourceRoll";
            this.radioSourceRoll.Size = new System.Drawing.Size(50, 17);
            this.radioSourceRoll.TabIndex = 1;
            this.radioSourceRoll.Text = "Крен";
            this.radioSourceRoll.UseVisualStyleBackColor = true;
            // 
            // radioSourcePitch
            // 
            this.radioSourcePitch.AutoSize = true;
            this.radioSourcePitch.Checked = true;
            this.radioSourcePitch.Location = new System.Drawing.Point(18, 10);
            this.radioSourcePitch.Name = "radioSourcePitch";
            this.radioSourcePitch.Size = new System.Drawing.Size(63, 17);
            this.radioSourcePitch.TabIndex = 0;
            this.radioSourcePitch.TabStop = true;
            this.radioSourcePitch.Text = "Тангаж";
            this.radioSourcePitch.UseVisualStyleBackColor = true;
            // 
            // radioSourceNetwork
            // 
            this.radioSourceNetwork.AutoSize = true;
            this.radioSourceNetwork.Location = new System.Drawing.Point(6, 16);
            this.radioSourceNetwork.Name = "radioSourceNetwork";
            this.radioSourceNetwork.Size = new System.Drawing.Size(85, 17);
            this.radioSourceNetwork.TabIndex = 0;
            this.radioSourceNetwork.Text = "Устройство";
            this.radioSourceNetwork.UseVisualStyleBackColor = true;
            this.radioSourceNetwork.CheckedChanged += new System.EventHandler(this.radioSourceNetwork_CheckedChanged);
            // 
            // AnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 690);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.mainChart);
            this.Name = "AnalyzerForm";
            this.Text = "Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.groupBoxPanel.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.groupBoxEmultaion.ResumeLayout(false);
            this.groupBoxEmultaion.PerformLayout();
            this.groupBoxSourceFourier.ResumeLayout(false);
            this.groupBoxSourceFourier.PerformLayout();
            this.groupBoxSourceSin.ResumeLayout(false);
            this.groupBoxSourceSin.PerformLayout();
            this.groupBoxNoise.ResumeLayout(false);
            this.groupBoxNoise.PerformLayout();
            this.groupBoxSourceLinear.ResumeLayout(false);
            this.groupBoxSourceLinear.PerformLayout();
            this.groupBoxSourceNetwork.ResumeLayout(false);
            this.groupBoxSourceNetwork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timerNetwork;
        public System.Windows.Forms.Label labelData;
        public System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        public System.Windows.Forms.GroupBox groupBoxPanel;
        public System.Windows.Forms.GroupBox groupBoxData;
        public System.Windows.Forms.GroupBox groupBoxSource;
        public System.Windows.Forms.RadioButton radioSourceEmulatorLinear;
        public System.Windows.Forms.RadioButton radioSourceEmulatorSin;
        public System.Windows.Forms.RadioButton radioSourceNetwork;
        public System.Windows.Forms.Button buttonSwitch;
        public System.Windows.Forms.GroupBox groupBoxFilter;
        public System.Windows.Forms.RadioButton radioFilterSinglePole;
        public System.Windows.Forms.RadioButton radioFilterMovingAverage;
        public System.Windows.Forms.GroupBox groupBoxSourceSin;
        public System.Windows.Forms.GroupBox groupBoxSourceNetwork;
        public System.Windows.Forms.GroupBox groupBoxSourceLinear;
        public System.Windows.Forms.RadioButton radioSourceYaw;
        public System.Windows.Forms.RadioButton radioSourceRoll;
        public System.Windows.Forms.RadioButton radioSourcePitch;
        public System.Windows.Forms.ComboBox comboIp;
        public System.Windows.Forms.Label labelInterface;
        public System.Windows.Forms.TextBox textSourceSinAverage;
        public System.Windows.Forms.TextBox textSourceSinAmplitude;
        public System.Windows.Forms.Label labelSinAverage;
        public System.Windows.Forms.Label labelSinAmplitude;
        public System.Windows.Forms.GroupBox groupBoxNoise;
        public System.Windows.Forms.Label labelLinearMax;
        public System.Windows.Forms.Label labelLinearMin;
        public System.Windows.Forms.TextBox textSourceLinearMax;
        public System.Windows.Forms.TextBox textSourceLinearMin;
        public System.Windows.Forms.RadioButton radioNoiserNormal;
        public System.Windows.Forms.RadioButton radioNoiserUniform;
        public System.Windows.Forms.RadioButton radioNoiserIdle;
        public System.Windows.Forms.Label labelNoiseNormalDeviation;
        public System.Windows.Forms.Label labelNoiseNormalMean;
        public System.Windows.Forms.Label labelNoiseIdleMax;
        public System.Windows.Forms.Label labelNoiseIdleMin;
        public System.Windows.Forms.TextBox textNoiseNormalMean;
        public System.Windows.Forms.TextBox textNoiseNormalDeviation;
        public System.Windows.Forms.TextBox textNoiseUniformMax;
        public System.Windows.Forms.TextBox textNoiseUniformMin;
        public System.Windows.Forms.RadioButton radioNoiserFunction;
        public System.Windows.Forms.RadioButton radioSourceEmulatorFourier;
        public System.Windows.Forms.ListBox listBoxSourceFourierCoefficients;
        public System.Windows.Forms.TextBox textSourceFourierCoefficients;
        public System.Windows.Forms.Label labelNoiserFourierCoefficients;
        public System.Windows.Forms.TextBox textSourceFourierHalfOffset;
        public System.Windows.Forms.Label labelNoiserFourierHalfOffset;
        public System.Windows.Forms.Button buttonSourceFourierAdd;
        public System.Windows.Forms.GroupBox groupBoxSourceFourier;
        public System.Windows.Forms.Button buttonSourceFourierClear;
        public System.Windows.Forms.GroupBox groupBoxEmultaion;
        public System.Windows.Forms.Label labelEmulatorStep;
        public System.Windows.Forms.Label labelEmulationRange;
        public System.Windows.Forms.TextBox textEmulationStep;
        public System.Windows.Forms.TextBox textEmulationRange;
        public System.Windows.Forms.CheckBox checkBoxFast;
        public System.Windows.Forms.Label labelEmulatorInterval;
        public System.Windows.Forms.TextBox textEmulationInterval;
        public System.Windows.Forms.Label labelSinPeriod;
        public System.Windows.Forms.TextBox textSourceSinPeriod;
        public System.Windows.Forms.Label labelEstimate;
        public System.Windows.Forms.Label labelFilterGaussianA;
        public System.Windows.Forms.TextBox textFilterGaussianA;
        public System.Windows.Forms.Label labelFilterSinglePoleK;
        public System.Windows.Forms.TextBox textFilterSinglePoleK;
        public System.Windows.Forms.RadioButton radioFilterGaussian;
        public System.Windows.Forms.Label labelFilterLength;
        public System.Windows.Forms.TextBox textFilterLength;
        private System.ComponentModel.IContainer components;
    }
}

