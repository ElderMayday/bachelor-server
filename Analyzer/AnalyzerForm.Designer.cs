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
            this.labelData.Location = new System.Drawing.Point(9, 28);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(99, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Нет данных";
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(18, 18);
            this.mainChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(1484, 586);
            this.mainChart.TabIndex = 1;
            this.mainChart.Text = "MainChart";
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxPanel.Controls.Add(this.groupBoxFilter);
            this.groupBoxPanel.Controls.Add(this.groupBoxData);
            this.groupBoxPanel.Controls.Add(this.groupBoxSource);
            this.groupBoxPanel.Location = new System.Drawing.Point(18, 614);
            this.groupBoxPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPanel.Size = new System.Drawing.Size(1484, 429);
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
            this.groupBoxFilter.Location = new System.Drawing.Point(1242, 20);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilter.Size = new System.Drawing.Size(232, 400);
            this.groupBoxFilter.TabIndex = 3;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Фильтр";
            // 
            // labelFilterLength
            // 
            this.labelFilterLength.AutoSize = true;
            this.labelFilterLength.Location = new System.Drawing.Point(10, 31);
            this.labelFilterLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterLength.Name = "labelFilterLength";
            this.labelFilterLength.Size = new System.Drawing.Size(76, 20);
            this.labelFilterLength.TabIndex = 8;
            this.labelFilterLength.Text = "Порядок";
            // 
            // textFilterLength
            // 
            this.textFilterLength.Location = new System.Drawing.Point(116, 28);
            this.textFilterLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFilterLength.Name = "textFilterLength";
            this.textFilterLength.Size = new System.Drawing.Size(46, 26);
            this.textFilterLength.TabIndex = 7;
            this.textFilterLength.Text = "5";
            // 
            // labelFilterGaussianA
            // 
            this.labelFilterGaussianA.AutoSize = true;
            this.labelFilterGaussianA.Location = new System.Drawing.Point(10, 274);
            this.labelFilterGaussianA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterGaussianA.Name = "labelFilterGaussianA";
            this.labelFilterGaussianA.Size = new System.Drawing.Size(20, 20);
            this.labelFilterGaussianA.TabIndex = 6;
            this.labelFilterGaussianA.Text = "A";
            // 
            // textFilterGaussianA
            // 
            this.textFilterGaussianA.Location = new System.Drawing.Point(45, 263);
            this.textFilterGaussianA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFilterGaussianA.Name = "textFilterGaussianA";
            this.textFilterGaussianA.Size = new System.Drawing.Size(120, 26);
            this.textFilterGaussianA.TabIndex = 5;
            this.textFilterGaussianA.Text = "0.5";
            // 
            // labelFilterSinglePoleK
            // 
            this.labelFilterSinglePoleK.AutoSize = true;
            this.labelFilterSinglePoleK.Location = new System.Drawing.Point(10, 186);
            this.labelFilterSinglePoleK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterSinglePoleK.Name = "labelFilterSinglePoleK";
            this.labelFilterSinglePoleK.Size = new System.Drawing.Size(19, 20);
            this.labelFilterSinglePoleK.TabIndex = 4;
            this.labelFilterSinglePoleK.Text = "K";
            // 
            // textFilterSinglePoleK
            // 
            this.textFilterSinglePoleK.Location = new System.Drawing.Point(45, 180);
            this.textFilterSinglePoleK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFilterSinglePoleK.Name = "textFilterSinglePoleK";
            this.textFilterSinglePoleK.Size = new System.Drawing.Size(120, 26);
            this.textFilterSinglePoleK.TabIndex = 3;
            this.textFilterSinglePoleK.Text = "0.5";
            // 
            // radioFilterGaussian
            // 
            this.radioFilterGaussian.AutoSize = true;
            this.radioFilterGaussian.Location = new System.Drawing.Point(15, 222);
            this.radioFilterGaussian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFilterGaussian.Name = "radioFilterGaussian";
            this.radioFilterGaussian.Size = new System.Drawing.Size(84, 24);
            this.radioFilterGaussian.TabIndex = 2;
            this.radioFilterGaussian.TabStop = true;
            this.radioFilterGaussian.Text = "Гаусса";
            this.radioFilterGaussian.UseVisualStyleBackColor = true;
            // 
            // radioFilterSinglePole
            // 
            this.radioFilterSinglePole.AutoSize = true;
            this.radioFilterSinglePole.Location = new System.Drawing.Point(15, 143);
            this.radioFilterSinglePole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFilterSinglePole.Name = "radioFilterSinglePole";
            this.radioFilterSinglePole.Size = new System.Drawing.Size(150, 24);
            this.radioFilterSinglePole.TabIndex = 1;
            this.radioFilterSinglePole.Text = "Однополярный";
            this.radioFilterSinglePole.UseVisualStyleBackColor = true;
            // 
            // radioFilterMovingAverage
            // 
            this.radioFilterMovingAverage.AutoSize = true;
            this.radioFilterMovingAverage.Checked = true;
            this.radioFilterMovingAverage.Location = new System.Drawing.Point(15, 105);
            this.radioFilterMovingAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFilterMovingAverage.Name = "radioFilterMovingAverage";
            this.radioFilterMovingAverage.Size = new System.Drawing.Size(197, 24);
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
            this.groupBoxData.Location = new System.Drawing.Point(16, 20);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxData.Size = new System.Drawing.Size(456, 248);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // labelEstimate
            // 
            this.labelEstimate.AutoSize = true;
            this.labelEstimate.Location = new System.Drawing.Point(9, 89);
            this.labelEstimate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstimate.Name = "labelEstimate";
            this.labelEstimate.Size = new System.Drawing.Size(96, 20);
            this.labelEstimate.TabIndex = 2;
            this.labelEstimate.Text = "Нет оценки";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(14, 165);
            this.buttonSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(170, 51);
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
            this.groupBoxSource.Location = new System.Drawing.Point(482, 20);
            this.groupBoxSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSource.Size = new System.Drawing.Size(752, 400);
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
            this.groupBoxEmultaion.Location = new System.Drawing.Point(14, 165);
            this.groupBoxEmultaion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEmultaion.Name = "groupBoxEmultaion";
            this.groupBoxEmultaion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEmultaion.Size = new System.Drawing.Size(225, 191);
            this.groupBoxEmultaion.TabIndex = 31;
            this.groupBoxEmultaion.TabStop = false;
            this.groupBoxEmultaion.Text = "Эмуляция";
            this.groupBoxEmultaion.Visible = false;
            // 
            // labelEmulatorInterval
            // 
            this.labelEmulatorInterval.AutoSize = true;
            this.labelEmulatorInterval.Location = new System.Drawing.Point(8, 151);
            this.labelEmulatorInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmulatorInterval.Name = "labelEmulatorInterval";
            this.labelEmulatorInterval.Size = new System.Drawing.Size(84, 20);
            this.labelEmulatorInterval.TabIndex = 36;
            this.labelEmulatorInterval.Text = "Интервал";
            // 
            // textEmulationInterval
            // 
            this.textEmulationInterval.Location = new System.Drawing.Point(100, 146);
            this.textEmulationInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmulationInterval.Name = "textEmulationInterval";
            this.textEmulationInterval.Size = new System.Drawing.Size(90, 26);
            this.textEmulationInterval.TabIndex = 35;
            this.textEmulationInterval.Text = "100";
            // 
            // labelEmulatorStep
            // 
            this.labelEmulatorStep.AutoSize = true;
            this.labelEmulatorStep.Location = new System.Drawing.Point(8, 115);
            this.labelEmulatorStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmulatorStep.Name = "labelEmulatorStep";
            this.labelEmulatorStep.Size = new System.Drawing.Size(38, 20);
            this.labelEmulatorStep.TabIndex = 34;
            this.labelEmulatorStep.Text = "Шаг";
            // 
            // labelEmulationRange
            // 
            this.labelEmulationRange.AutoSize = true;
            this.labelEmulationRange.Location = new System.Drawing.Point(8, 78);
            this.labelEmulationRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmulationRange.Name = "labelEmulationRange";
            this.labelEmulationRange.Size = new System.Drawing.Size(58, 20);
            this.labelEmulationRange.TabIndex = 33;
            this.labelEmulationRange.Text = "Длина";
            // 
            // textEmulationStep
            // 
            this.textEmulationStep.Location = new System.Drawing.Point(100, 111);
            this.textEmulationStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmulationStep.Name = "textEmulationStep";
            this.textEmulationStep.Size = new System.Drawing.Size(90, 26);
            this.textEmulationStep.TabIndex = 32;
            this.textEmulationStep.Text = "5.0";
            // 
            // textEmulationRange
            // 
            this.textEmulationRange.Enabled = false;
            this.textEmulationRange.Location = new System.Drawing.Point(100, 74);
            this.textEmulationRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmulationRange.Name = "textEmulationRange";
            this.textEmulationRange.Size = new System.Drawing.Size(90, 26);
            this.textEmulationRange.TabIndex = 31;
            this.textEmulationRange.Text = "100.0";
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Location = new System.Drawing.Point(9, 29);
            this.checkBoxFast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(178, 24);
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
            this.groupBoxSourceFourier.Location = new System.Drawing.Point(260, 17);
            this.groupBoxSourceFourier.Name = "groupBoxSourceFourier";
            this.groupBoxSourceFourier.Size = new System.Drawing.Size(248, 338);
            this.groupBoxSourceFourier.TabIndex = 29;
            this.groupBoxSourceFourier.TabStop = false;
            // 
            // buttonSourceFourierClear
            // 
            this.buttonSourceFourierClear.Location = new System.Drawing.Point(10, 237);
            this.buttonSourceFourierClear.Name = "buttonSourceFourierClear";
            this.buttonSourceFourierClear.Size = new System.Drawing.Size(99, 31);
            this.buttonSourceFourierClear.TabIndex = 29;
            this.buttonSourceFourierClear.Text = "Очистить";
            this.buttonSourceFourierClear.UseVisualStyleBackColor = true;
            this.buttonSourceFourierClear.Click += new System.EventHandler(this.buttonSourceFourierClear_Click);
            // 
            // textSourceFourierCoefficients
            // 
            this.textSourceFourierCoefficients.Location = new System.Drawing.Point(122, 200);
            this.textSourceFourierCoefficients.Name = "textSourceFourierCoefficients";
            this.textSourceFourierCoefficients.Size = new System.Drawing.Size(118, 26);
            this.textSourceFourierCoefficients.TabIndex = 24;
            this.textSourceFourierCoefficients.Text = "10.0;0.0";
            // 
            // textSourceFourierHalfOffset
            // 
            this.textSourceFourierHalfOffset.Location = new System.Drawing.Point(122, 20);
            this.textSourceFourierHalfOffset.Name = "textSourceFourierHalfOffset";
            this.textSourceFourierHalfOffset.Size = new System.Drawing.Size(120, 26);
            this.textSourceFourierHalfOffset.TabIndex = 21;
            this.textSourceFourierHalfOffset.Text = "0.0";
            // 
            // buttonSourceFourierAdd
            // 
            this.buttonSourceFourierAdd.Location = new System.Drawing.Point(122, 237);
            this.buttonSourceFourierAdd.Name = "buttonSourceFourierAdd";
            this.buttonSourceFourierAdd.Size = new System.Drawing.Size(120, 31);
            this.buttonSourceFourierAdd.TabIndex = 28;
            this.buttonSourceFourierAdd.Text = "Добавить";
            this.buttonSourceFourierAdd.UseVisualStyleBackColor = true;
            this.buttonSourceFourierAdd.Click += new System.EventHandler(this.buttonNoiserFourierAdd_Click);
            // 
            // labelNoiserFourierHalfOffset
            // 
            this.labelNoiserFourierHalfOffset.AutoSize = true;
            this.labelNoiserFourierHalfOffset.Location = new System.Drawing.Point(18, 25);
            this.labelNoiserFourierHalfOffset.Name = "labelNoiserFourierHalfOffset";
            this.labelNoiserFourierHalfOffset.Size = new System.Drawing.Size(89, 20);
            this.labelNoiserFourierHalfOffset.TabIndex = 20;
            this.labelNoiserFourierHalfOffset.Text = "Смещение";
            // 
            // labelNoiserFourierCoefficients
            // 
            this.labelNoiserFourierCoefficients.AutoSize = true;
            this.labelNoiserFourierCoefficients.Location = new System.Drawing.Point(114, 55);
            this.labelNoiserFourierCoefficients.Name = "labelNoiserFourierCoefficients";
            this.labelNoiserFourierCoefficients.Size = new System.Drawing.Size(132, 20);
            this.labelNoiserFourierCoefficients.TabIndex = 22;
            this.labelNoiserFourierCoefficients.Text = "Коэффициенты";
            // 
            // listBoxSourceFourierCoefficients
            // 
            this.listBoxSourceFourierCoefficients.FormattingEnabled = true;
            this.listBoxSourceFourierCoefficients.ItemHeight = 20;
            this.listBoxSourceFourierCoefficients.Location = new System.Drawing.Point(120, 88);
            this.listBoxSourceFourierCoefficients.Name = "listBoxSourceFourierCoefficients";
            this.listBoxSourceFourierCoefficients.Size = new System.Drawing.Size(120, 104);
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
            this.groupBoxSourceSin.Location = new System.Drawing.Point(260, 17);
            this.groupBoxSourceSin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceSin.Name = "groupBoxSourceSin";
            this.groupBoxSourceSin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceSin.Size = new System.Drawing.Size(249, 312);
            this.groupBoxSourceSin.TabIndex = 4;
            this.groupBoxSourceSin.TabStop = false;
            // 
            // labelSinPeriod
            // 
            this.labelSinPeriod.AutoSize = true;
            this.labelSinPeriod.Location = new System.Drawing.Point(0, 129);
            this.labelSinPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinPeriod.Name = "labelSinPeriod";
            this.labelSinPeriod.Size = new System.Drawing.Size(68, 20);
            this.labelSinPeriod.TabIndex = 7;
            this.labelSinPeriod.Text = "Период";
            // 
            // textSourceSinPeriod
            // 
            this.textSourceSinPeriod.Location = new System.Drawing.Point(96, 125);
            this.textSourceSinPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceSinPeriod.Name = "textSourceSinPeriod";
            this.textSourceSinPeriod.Size = new System.Drawing.Size(120, 26);
            this.textSourceSinPeriod.TabIndex = 6;
            this.textSourceSinPeriod.Text = "6.28";
            // 
            // labelSinAverage
            // 
            this.labelSinAverage.AutoSize = true;
            this.labelSinAverage.Location = new System.Drawing.Point(3, 91);
            this.labelSinAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinAverage.Name = "labelSinAverage";
            this.labelSinAverage.Size = new System.Drawing.Size(76, 20);
            this.labelSinAverage.TabIndex = 5;
            this.labelSinAverage.Text = "Средняя";
            // 
            // labelSinAmplitude
            // 
            this.labelSinAmplitude.AutoSize = true;
            this.labelSinAmplitude.Location = new System.Drawing.Point(3, 55);
            this.labelSinAmplitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinAmplitude.Name = "labelSinAmplitude";
            this.labelSinAmplitude.Size = new System.Drawing.Size(95, 20);
            this.labelSinAmplitude.TabIndex = 4;
            this.labelSinAmplitude.Text = "Амплитуда";
            // 
            // textSourceSinAverage
            // 
            this.textSourceSinAverage.Location = new System.Drawing.Point(96, 86);
            this.textSourceSinAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceSinAverage.Name = "textSourceSinAverage";
            this.textSourceSinAverage.Size = new System.Drawing.Size(120, 26);
            this.textSourceSinAverage.TabIndex = 2;
            this.textSourceSinAverage.Text = "10.0";
            // 
            // textSourceSinAmplitude
            // 
            this.textSourceSinAmplitude.Location = new System.Drawing.Point(96, 51);
            this.textSourceSinAmplitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceSinAmplitude.Name = "textSourceSinAmplitude";
            this.textSourceSinAmplitude.Size = new System.Drawing.Size(120, 26);
            this.textSourceSinAmplitude.TabIndex = 1;
            this.textSourceSinAmplitude.Text = "30.0";
            // 
            // radioSourceEmulatorFourier
            // 
            this.radioSourceEmulatorFourier.AutoSize = true;
            this.radioSourceEmulatorFourier.Location = new System.Drawing.Point(9, 125);
            this.radioSourceEmulatorFourier.Name = "radioSourceEmulatorFourier";
            this.radioSourceEmulatorFourier.Size = new System.Drawing.Size(163, 24);
            this.radioSourceEmulatorFourier.TabIndex = 27;
            this.radioSourceEmulatorFourier.Text = "Эмулятор Фурье";
            this.radioSourceEmulatorFourier.UseVisualStyleBackColor = true;
            this.radioSourceEmulatorFourier.CheckedChanged += new System.EventHandler(this.radioSourceEmulatorFourier_CheckedChanged);
            // 
            // radioSourceEmulatorLinear
            // 
            this.radioSourceEmulatorLinear.AutoSize = true;
            this.radioSourceEmulatorLinear.Location = new System.Drawing.Point(9, 89);
            this.radioSourceEmulatorLinear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceEmulatorLinear.Name = "radioSourceEmulatorLinear";
            this.radioSourceEmulatorLinear.Size = new System.Drawing.Size(189, 24);
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
            this.groupBoxNoise.Location = new System.Drawing.Point(514, 17);
            this.groupBoxNoise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNoise.Size = new System.Drawing.Size(212, 338);
            this.groupBoxNoise.TabIndex = 6;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "Шум";
            // 
            // radioNoiserFunction
            // 
            this.radioNoiserFunction.AutoSize = true;
            this.radioNoiserFunction.Location = new System.Drawing.Point(22, 271);
            this.radioNoiserFunction.Name = "radioNoiserFunction";
            this.radioNoiserFunction.Size = new System.Drawing.Size(104, 24);
            this.radioNoiserFunction.TabIndex = 19;
            this.radioNoiserFunction.TabStop = true;
            this.radioNoiserFunction.Text = "Кусочная";
            this.radioNoiserFunction.UseVisualStyleBackColor = true;
            // 
            // labelNoiseNormalDeviation
            // 
            this.labelNoiseNormalDeviation.AutoSize = true;
            this.labelNoiseNormalDeviation.Location = new System.Drawing.Point(2, 235);
            this.labelNoiseNormalDeviation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseNormalDeviation.Name = "labelNoiseNormalDeviation";
            this.labelNoiseNormalDeviation.Size = new System.Drawing.Size(91, 20);
            this.labelNoiseNormalDeviation.TabIndex = 14;
            this.labelNoiseNormalDeviation.Text = "Дисперсия";
            // 
            // labelNoiseNormalMean
            // 
            this.labelNoiseNormalMean.AutoSize = true;
            this.labelNoiseNormalMean.Location = new System.Drawing.Point(9, 205);
            this.labelNoiseNormalMean.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseNormalMean.Name = "labelNoiseNormalMean";
            this.labelNoiseNormalMean.Size = new System.Drawing.Size(78, 20);
            this.labelNoiseNormalMean.TabIndex = 13;
            this.labelNoiseNormalMean.Text = "Медиана";
            // 
            // labelNoiseIdleMax
            // 
            this.labelNoiseIdleMax.AutoSize = true;
            this.labelNoiseIdleMax.Location = new System.Drawing.Point(8, 142);
            this.labelNoiseIdleMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseIdleMax.Name = "labelNoiseIdleMax";
            this.labelNoiseIdleMax.Size = new System.Drawing.Size(51, 20);
            this.labelNoiseIdleMax.TabIndex = 12;
            this.labelNoiseIdleMax.Text = "Макс.";
            // 
            // labelNoiseIdleMin
            // 
            this.labelNoiseIdleMin.AutoSize = true;
            this.labelNoiseIdleMin.Location = new System.Drawing.Point(9, 108);
            this.labelNoiseIdleMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseIdleMin.Name = "labelNoiseIdleMin";
            this.labelNoiseIdleMin.Size = new System.Drawing.Size(44, 20);
            this.labelNoiseIdleMin.TabIndex = 11;
            this.labelNoiseIdleMin.Text = "Мин.";
            // 
            // textNoiseNormalMean
            // 
            this.textNoiseNormalMean.Location = new System.Drawing.Point(94, 198);
            this.textNoiseNormalMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseNormalMean.Name = "textNoiseNormalMean";
            this.textNoiseNormalMean.Size = new System.Drawing.Size(92, 26);
            this.textNoiseNormalMean.TabIndex = 10;
            this.textNoiseNormalMean.Text = "0.0";
            // 
            // textNoiseNormalDeviation
            // 
            this.textNoiseNormalDeviation.Location = new System.Drawing.Point(94, 232);
            this.textNoiseNormalDeviation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseNormalDeviation.Name = "textNoiseNormalDeviation";
            this.textNoiseNormalDeviation.Size = new System.Drawing.Size(92, 26);
            this.textNoiseNormalDeviation.TabIndex = 7;
            this.textNoiseNormalDeviation.Text = "10.0";
            // 
            // textNoiseUniformMax
            // 
            this.textNoiseUniformMax.Location = new System.Drawing.Point(94, 138);
            this.textNoiseUniformMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseUniformMax.Name = "textNoiseUniformMax";
            this.textNoiseUniformMax.Size = new System.Drawing.Size(92, 26);
            this.textNoiseUniformMax.TabIndex = 6;
            this.textNoiseUniformMax.Text = "10.0";
            // 
            // textNoiseUniformMin
            // 
            this.textNoiseUniformMin.Location = new System.Drawing.Point(94, 102);
            this.textNoiseUniformMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseUniformMin.Name = "textNoiseUniformMin";
            this.textNoiseUniformMin.Size = new System.Drawing.Size(92, 26);
            this.textNoiseUniformMin.TabIndex = 5;
            this.textNoiseUniformMin.Text = "-10.0";
            // 
            // radioNoiserNormal
            // 
            this.radioNoiserNormal.AutoSize = true;
            this.radioNoiserNormal.Location = new System.Drawing.Point(22, 166);
            this.radioNoiserNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNoiserNormal.Name = "radioNoiserNormal";
            this.radioNoiserNormal.Size = new System.Drawing.Size(132, 24);
            this.radioNoiserNormal.TabIndex = 2;
            this.radioNoiserNormal.Text = "Нормальный";
            this.radioNoiserNormal.UseVisualStyleBackColor = true;
            // 
            // radioNoiserUniform
            // 
            this.radioNoiserUniform.AutoSize = true;
            this.radioNoiserUniform.Location = new System.Drawing.Point(22, 74);
            this.radioNoiserUniform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNoiserUniform.Name = "radioNoiserUniform";
            this.radioNoiserUniform.Size = new System.Drawing.Size(138, 24);
            this.radioNoiserUniform.TabIndex = 1;
            this.radioNoiserUniform.Text = "Равномерный";
            this.radioNoiserUniform.UseVisualStyleBackColor = true;
            // 
            // radioNoiserIdle
            // 
            this.radioNoiserIdle.AutoSize = true;
            this.radioNoiserIdle.Checked = true;
            this.radioNoiserIdle.Location = new System.Drawing.Point(22, 38);
            this.radioNoiserIdle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNoiserIdle.Name = "radioNoiserIdle";
            this.radioNoiserIdle.Size = new System.Drawing.Size(64, 24);
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
            this.groupBoxSourceLinear.Location = new System.Drawing.Point(254, 15);
            this.groupBoxSourceLinear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceLinear.Name = "groupBoxSourceLinear";
            this.groupBoxSourceLinear.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceLinear.Size = new System.Drawing.Size(249, 305);
            this.groupBoxSourceLinear.TabIndex = 5;
            this.groupBoxSourceLinear.TabStop = false;
            // 
            // labelLinearMax
            // 
            this.labelLinearMax.AutoSize = true;
            this.labelLinearMax.Location = new System.Drawing.Point(9, 55);
            this.labelLinearMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLinearMax.Name = "labelLinearMax";
            this.labelLinearMax.Size = new System.Drawing.Size(51, 20);
            this.labelLinearMax.TabIndex = 3;
            this.labelLinearMax.Text = "Макс.";
            // 
            // labelLinearMin
            // 
            this.labelLinearMin.AutoSize = true;
            this.labelLinearMin.Location = new System.Drawing.Point(9, 18);
            this.labelLinearMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLinearMin.Name = "labelLinearMin";
            this.labelLinearMin.Size = new System.Drawing.Size(44, 20);
            this.labelLinearMin.TabIndex = 2;
            this.labelLinearMin.Text = "Мин.";
            // 
            // textSourceLinearMax
            // 
            this.textSourceLinearMax.Location = new System.Drawing.Point(68, 49);
            this.textSourceLinearMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceLinearMax.Name = "textSourceLinearMax";
            this.textSourceLinearMax.Size = new System.Drawing.Size(148, 26);
            this.textSourceLinearMax.TabIndex = 1;
            this.textSourceLinearMax.Text = "90.0";
            // 
            // textSourceLinearMin
            // 
            this.textSourceLinearMin.Location = new System.Drawing.Point(68, 15);
            this.textSourceLinearMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceLinearMin.Name = "textSourceLinearMin";
            this.textSourceLinearMin.Size = new System.Drawing.Size(148, 26);
            this.textSourceLinearMin.TabIndex = 0;
            this.textSourceLinearMin.Text = "-90.0";
            // 
            // radioSourceEmulatorSin
            // 
            this.radioSourceEmulatorSin.AutoSize = true;
            this.radioSourceEmulatorSin.Checked = true;
            this.radioSourceEmulatorSin.Location = new System.Drawing.Point(9, 55);
            this.radioSourceEmulatorSin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceEmulatorSin.Name = "radioSourceEmulatorSin";
            this.radioSourceEmulatorSin.Size = new System.Drawing.Size(241, 24);
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
            this.groupBoxSourceNetwork.Location = new System.Drawing.Point(256, 17);
            this.groupBoxSourceNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceNetwork.Name = "groupBoxSourceNetwork";
            this.groupBoxSourceNetwork.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceNetwork.Size = new System.Drawing.Size(250, 312);
            this.groupBoxSourceNetwork.TabIndex = 3;
            this.groupBoxSourceNetwork.TabStop = false;
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Location = new System.Drawing.Point(9, 126);
            this.labelInterface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(24, 20);
            this.labelInterface.TabIndex = 7;
            this.labelInterface.Text = "IP";
            // 
            // radioSourceYaw
            // 
            this.radioSourceYaw.AutoSize = true;
            this.radioSourceYaw.Location = new System.Drawing.Point(27, 86);
            this.radioSourceYaw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceYaw.Name = "radioSourceYaw";
            this.radioSourceYaw.Size = new System.Drawing.Size(107, 24);
            this.radioSourceYaw.TabIndex = 2;
            this.radioSourceYaw.Text = "Рысканье";
            this.radioSourceYaw.UseVisualStyleBackColor = true;
            // 
            // comboIp
            // 
            this.comboIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIp.FormattingEnabled = true;
            this.comboIp.Location = new System.Drawing.Point(44, 122);
            this.comboIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboIp.Name = "comboIp";
            this.comboIp.Size = new System.Drawing.Size(172, 28);
            this.comboIp.TabIndex = 6;
            // 
            // radioSourceRoll
            // 
            this.radioSourceRoll.AutoSize = true;
            this.radioSourceRoll.Location = new System.Drawing.Point(27, 51);
            this.radioSourceRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceRoll.Name = "radioSourceRoll";
            this.radioSourceRoll.Size = new System.Drawing.Size(71, 24);
            this.radioSourceRoll.TabIndex = 1;
            this.radioSourceRoll.Text = "Крен";
            this.radioSourceRoll.UseVisualStyleBackColor = true;
            // 
            // radioSourcePitch
            // 
            this.radioSourcePitch.AutoSize = true;
            this.radioSourcePitch.Checked = true;
            this.radioSourcePitch.Location = new System.Drawing.Point(27, 15);
            this.radioSourcePitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourcePitch.Name = "radioSourcePitch";
            this.radioSourcePitch.Size = new System.Drawing.Size(88, 24);
            this.radioSourcePitch.TabIndex = 0;
            this.radioSourcePitch.TabStop = true;
            this.radioSourcePitch.Text = "Тангаж";
            this.radioSourcePitch.UseVisualStyleBackColor = true;
            // 
            // radioSourceNetwork
            // 
            this.radioSourceNetwork.AutoSize = true;
            this.radioSourceNetwork.Location = new System.Drawing.Point(9, 25);
            this.radioSourceNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceNetwork.Name = "radioSourceNetwork";
            this.radioSourceNetwork.Size = new System.Drawing.Size(123, 24);
            this.radioSourceNetwork.TabIndex = 0;
            this.radioSourceNetwork.Text = "Устройство";
            this.radioSourceNetwork.UseVisualStyleBackColor = true;
            this.radioSourceNetwork.CheckedChanged += new System.EventHandler(this.radioSourceNetwork_CheckedChanged);
            // 
            // AnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1038);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.mainChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

