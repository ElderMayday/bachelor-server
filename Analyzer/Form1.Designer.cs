namespace Analyzer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
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
            this.radioFilterSinglePole = new System.Windows.Forms.RadioButton();
            this.radioFilterMovingAverage = new System.Windows.Forms.RadioButton();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.groupBoxSourceFourier = new System.Windows.Forms.GroupBox();
            this.textSourceFourierCoefficients = new System.Windows.Forms.TextBox();
            this.textSourceFourierHalfOffset = new System.Windows.Forms.TextBox();
            this.buttonSourceFourierAdd = new System.Windows.Forms.Button();
            this.labelNoiserFourierHalfOffset = new System.Windows.Forms.Label();
            this.labelNoiserFourierCoefficients = new System.Windows.Forms.Label();
            this.listBoxSourceFourierCoefficients = new System.Windows.Forms.ListBox();
            this.radioSourceEmulatorFourier = new System.Windows.Forms.RadioButton();
            this.radioSourceEmulatorLinear = new System.Windows.Forms.RadioButton();
            this.groupBoxNoise = new System.Windows.Forms.GroupBox();
            this.radioNoiserFunction = new System.Windows.Forms.RadioButton();
            this.labelNoiseErlangLambda = new System.Windows.Forms.Label();
            this.textNoiseErlangLambda = new System.Windows.Forms.TextBox();
            this.labelNoiseErlangK = new System.Windows.Forms.Label();
            this.labelNoiseExponentialLambda = new System.Windows.Forms.Label();
            this.labelNoiseNormalDeviation = new System.Windows.Forms.Label();
            this.labelNoiseNormalMean = new System.Windows.Forms.Label();
            this.labelNoiseIdleMax = new System.Windows.Forms.Label();
            this.labelNoiseIdleMin = new System.Windows.Forms.Label();
            this.textNoiseNormalMean = new System.Windows.Forms.TextBox();
            this.textNoiseErlangK = new System.Windows.Forms.TextBox();
            this.textNoiseExponentialLambda = new System.Windows.Forms.TextBox();
            this.textNoiseNormalDeviation = new System.Windows.Forms.TextBox();
            this.textNoiseUniformMax = new System.Windows.Forms.TextBox();
            this.textNoiseUniformMin = new System.Windows.Forms.TextBox();
            this.radioNoiserErlang = new System.Windows.Forms.RadioButton();
            this.radioNoiserExponential = new System.Windows.Forms.RadioButton();
            this.radioNoiserNormal = new System.Windows.Forms.RadioButton();
            this.radioNoiserUniform = new System.Windows.Forms.RadioButton();
            this.radioNoiserIdle = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceLinear = new System.Windows.Forms.GroupBox();
            this.labelLinearStep = new System.Windows.Forms.Label();
            this.textSourceLinearStep = new System.Windows.Forms.TextBox();
            this.labelLinearMax = new System.Windows.Forms.Label();
            this.labelLinearMin = new System.Windows.Forms.Label();
            this.textSourceLinearMax = new System.Windows.Forms.TextBox();
            this.textSourceLinearMin = new System.Windows.Forms.TextBox();
            this.radioSourceEmulatorSin = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceNetwrok = new System.Windows.Forms.GroupBox();
            this.labelInterface = new System.Windows.Forms.Label();
            this.radioSourceYaw = new System.Windows.Forms.RadioButton();
            this.comboIp = new System.Windows.Forms.ComboBox();
            this.radioSourceRoll = new System.Windows.Forms.RadioButton();
            this.radioSourcePitch = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceSin = new System.Windows.Forms.GroupBox();
            this.labelSinAverage = new System.Windows.Forms.Label();
            this.labelSinAmplitude = new System.Windows.Forms.Label();
            this.labelSinStep = new System.Windows.Forms.Label();
            this.textSourceSinAverage = new System.Windows.Forms.TextBox();
            this.textSourceSinAmplitude = new System.Windows.Forms.TextBox();
            this.textSourceSinStep = new System.Windows.Forms.TextBox();
            this.radioSourceNetwork = new System.Windows.Forms.RadioButton();
            this.buttonSourceFourierClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBoxPanel.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxSourceFourier.SuspendLayout();
            this.groupBoxNoise.SuspendLayout();
            this.groupBoxSourceLinear.SuspendLayout();
            this.groupBoxSourceNetwrok.SuspendLayout();
            this.groupBoxSourceSin.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerNetwork
            // 
            this.timerNetwork.Tick += new System.EventHandler(this.timerNetwork_Tick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(9, 37);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(65, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "No data";
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
            this.mainChart.Size = new System.Drawing.Size(1881, 586);
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
            this.groupBoxPanel.Size = new System.Drawing.Size(1881, 427);
            this.groupBoxPanel.TabIndex = 2;
            this.groupBoxPanel.TabStop = false;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFilter.Controls.Add(this.radioFilterSinglePole);
            this.groupBoxFilter.Controls.Add(this.radioFilterMovingAverage);
            this.groupBoxFilter.Location = new System.Drawing.Point(1585, 20);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilter.Size = new System.Drawing.Size(288, 397);
            this.groupBoxFilter.TabIndex = 3;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Фильтр";
            // 
            // radioFilterSinglePole
            // 
            this.radioFilterSinglePole.AutoSize = true;
            this.radioFilterSinglePole.Location = new System.Drawing.Point(42, 69);
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
            this.radioFilterMovingAverage.Location = new System.Drawing.Point(42, 34);
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
            this.groupBoxData.Controls.Add(this.buttonSwitch);
            this.groupBoxData.Controls.Add(this.labelData);
            this.groupBoxData.Location = new System.Drawing.Point(8, 20);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxData.Size = new System.Drawing.Size(210, 397);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(14, 82);
            this.buttonSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(188, 63);
            this.buttonSwitch.TabIndex = 1;
            this.buttonSwitch.Text = "Включить";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSource.Controls.Add(this.groupBoxSourceFourier);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorFourier);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorLinear);
            this.groupBoxSource.Controls.Add(this.groupBoxNoise);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceLinear);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorSin);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceNetwrok);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceSin);
            this.groupBoxSource.Controls.Add(this.radioSourceNetwork);
            this.groupBoxSource.Location = new System.Drawing.Point(226, 20);
            this.groupBoxSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSource.Size = new System.Drawing.Size(1351, 397);
            this.groupBoxSource.TabIndex = 1;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Источник";
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
            this.groupBoxSourceFourier.Location = new System.Drawing.Point(719, 89);
            this.groupBoxSourceFourier.Name = "groupBoxSourceFourier";
            this.groupBoxSourceFourier.Size = new System.Drawing.Size(237, 253);
            this.groupBoxSourceFourier.TabIndex = 29;
            this.groupBoxSourceFourier.TabStop = false;
            // 
            // textSourceFourierCoefficients
            // 
            this.textSourceFourierCoefficients.Location = new System.Drawing.Point(111, 184);
            this.textSourceFourierCoefficients.Name = "textSourceFourierCoefficients";
            this.textSourceFourierCoefficients.Size = new System.Drawing.Size(117, 26);
            this.textSourceFourierCoefficients.TabIndex = 24;
            this.textSourceFourierCoefficients.Text = "10.0;0.0";
            // 
            // textSourceFourierHalfOffset
            // 
            this.textSourceFourierHalfOffset.Location = new System.Drawing.Point(111, 19);
            this.textSourceFourierHalfOffset.Name = "textSourceFourierHalfOffset";
            this.textSourceFourierHalfOffset.Size = new System.Drawing.Size(120, 26);
            this.textSourceFourierHalfOffset.TabIndex = 21;
            this.textSourceFourierHalfOffset.Text = "0.0";
            // 
            // buttonSourceFourierAdd
            // 
            this.buttonSourceFourierAdd.Location = new System.Drawing.Point(111, 216);
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
            this.labelNoiserFourierHalfOffset.Location = new System.Drawing.Point(9, 19);
            this.labelNoiserFourierHalfOffset.Name = "labelNoiserFourierHalfOffset";
            this.labelNoiserFourierHalfOffset.Size = new System.Drawing.Size(89, 20);
            this.labelNoiserFourierHalfOffset.TabIndex = 20;
            this.labelNoiserFourierHalfOffset.Text = "Смещение";
            // 
            // labelNoiserFourierCoefficients
            // 
            this.labelNoiserFourierCoefficients.AutoSize = true;
            this.labelNoiserFourierCoefficients.Location = new System.Drawing.Point(96, 50);
            this.labelNoiserFourierCoefficients.Name = "labelNoiserFourierCoefficients";
            this.labelNoiserFourierCoefficients.Size = new System.Drawing.Size(132, 20);
            this.labelNoiserFourierCoefficients.TabIndex = 22;
            this.labelNoiserFourierCoefficients.Text = "Коэффициенты";
            // 
            // listBoxSourceFourierCoefficients
            // 
            this.listBoxSourceFourierCoefficients.FormattingEnabled = true;
            this.listBoxSourceFourierCoefficients.ItemHeight = 20;
            this.listBoxSourceFourierCoefficients.Location = new System.Drawing.Point(108, 74);
            this.listBoxSourceFourierCoefficients.Name = "listBoxSourceFourierCoefficients";
            this.listBoxSourceFourierCoefficients.Size = new System.Drawing.Size(120, 104);
            this.listBoxSourceFourierCoefficients.TabIndex = 26;
            // 
            // radioSourceEmulatorFourier
            // 
            this.radioSourceEmulatorFourier.AutoSize = true;
            this.radioSourceEmulatorFourier.Location = new System.Drawing.Point(732, 33);
            this.radioSourceEmulatorFourier.Name = "radioSourceEmulatorFourier";
            this.radioSourceEmulatorFourier.Size = new System.Drawing.Size(83, 24);
            this.radioSourceEmulatorFourier.TabIndex = 27;
            this.radioSourceEmulatorFourier.TabStop = true;
            this.radioSourceEmulatorFourier.Text = "Фурье";
            this.radioSourceEmulatorFourier.UseVisualStyleBackColor = true;
            // 
            // radioSourceEmulatorLinear
            // 
            this.radioSourceEmulatorLinear.AutoSize = true;
            this.radioSourceEmulatorLinear.Location = new System.Drawing.Point(486, 29);
            this.radioSourceEmulatorLinear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceEmulatorLinear.Name = "radioSourceEmulatorLinear";
            this.radioSourceEmulatorLinear.Size = new System.Drawing.Size(189, 24);
            this.radioSourceEmulatorLinear.TabIndex = 2;
            this.radioSourceEmulatorLinear.Text = "Эмулятор линейный";
            this.radioSourceEmulatorLinear.UseVisualStyleBackColor = true;
            // 
            // groupBoxNoise
            // 
            this.groupBoxNoise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNoise.Controls.Add(this.radioNoiserFunction);
            this.groupBoxNoise.Controls.Add(this.labelNoiseErlangLambda);
            this.groupBoxNoise.Controls.Add(this.textNoiseErlangLambda);
            this.groupBoxNoise.Controls.Add(this.labelNoiseErlangK);
            this.groupBoxNoise.Controls.Add(this.labelNoiseExponentialLambda);
            this.groupBoxNoise.Controls.Add(this.labelNoiseNormalDeviation);
            this.groupBoxNoise.Controls.Add(this.labelNoiseNormalMean);
            this.groupBoxNoise.Controls.Add(this.labelNoiseIdleMax);
            this.groupBoxNoise.Controls.Add(this.labelNoiseIdleMin);
            this.groupBoxNoise.Controls.Add(this.textNoiseNormalMean);
            this.groupBoxNoise.Controls.Add(this.textNoiseErlangK);
            this.groupBoxNoise.Controls.Add(this.textNoiseExponentialLambda);
            this.groupBoxNoise.Controls.Add(this.textNoiseNormalDeviation);
            this.groupBoxNoise.Controls.Add(this.textNoiseUniformMax);
            this.groupBoxNoise.Controls.Add(this.textNoiseUniformMin);
            this.groupBoxNoise.Controls.Add(this.radioNoiserErlang);
            this.groupBoxNoise.Controls.Add(this.radioNoiserExponential);
            this.groupBoxNoise.Controls.Add(this.radioNoiserNormal);
            this.groupBoxNoise.Controls.Add(this.radioNoiserUniform);
            this.groupBoxNoise.Controls.Add(this.radioNoiserIdle);
            this.groupBoxNoise.Location = new System.Drawing.Point(963, 29);
            this.groupBoxNoise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNoise.Size = new System.Drawing.Size(380, 313);
            this.groupBoxNoise.TabIndex = 6;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "Шум";
            // 
            // radioNoiserFunction
            // 
            this.radioNoiserFunction.AutoSize = true;
            this.radioNoiserFunction.Location = new System.Drawing.Point(200, 233);
            this.radioNoiserFunction.Name = "radioNoiserFunction";
            this.radioNoiserFunction.Size = new System.Drawing.Size(104, 24);
            this.radioNoiserFunction.TabIndex = 19;
            this.radioNoiserFunction.TabStop = true;
            this.radioNoiserFunction.Text = "Кусочная";
            this.radioNoiserFunction.UseVisualStyleBackColor = true;
            // 
            // labelNoiseErlangLambda
            // 
            this.labelNoiseErlangLambda.AutoSize = true;
            this.labelNoiseErlangLambda.Location = new System.Drawing.Point(196, 190);
            this.labelNoiseErlangLambda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseErlangLambda.Name = "labelNoiseErlangLambda";
            this.labelNoiseErlangLambda.Size = new System.Drawing.Size(70, 20);
            this.labelNoiseErlangLambda.TabIndex = 18;
            this.labelNoiseErlangLambda.Text = "Лямбда";
            // 
            // textNoiseErlangLambda
            // 
            this.textNoiseErlangLambda.Location = new System.Drawing.Point(272, 184);
            this.textNoiseErlangLambda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseErlangLambda.Name = "textNoiseErlangLambda";
            this.textNoiseErlangLambda.Size = new System.Drawing.Size(90, 26);
            this.textNoiseErlangLambda.TabIndex = 17;
            this.textNoiseErlangLambda.Text = "5.0";
            // 
            // labelNoiseErlangK
            // 
            this.labelNoiseErlangK.AutoSize = true;
            this.labelNoiseErlangK.Location = new System.Drawing.Point(196, 154);
            this.labelNoiseErlangK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseErlangK.Name = "labelNoiseErlangK";
            this.labelNoiseErlangK.Size = new System.Drawing.Size(19, 20);
            this.labelNoiseErlangK.TabIndex = 16;
            this.labelNoiseErlangK.Text = "K";
            // 
            // labelNoiseExponentialLambda
            // 
            this.labelNoiseExponentialLambda.AutoSize = true;
            this.labelNoiseExponentialLambda.Location = new System.Drawing.Point(194, 76);
            this.labelNoiseExponentialLambda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseExponentialLambda.Name = "labelNoiseExponentialLambda";
            this.labelNoiseExponentialLambda.Size = new System.Drawing.Size(70, 20);
            this.labelNoiseExponentialLambda.TabIndex = 15;
            this.labelNoiseExponentialLambda.Text = "Лямбда";
            // 
            // labelNoiseNormalDeviation
            // 
            this.labelNoiseNormalDeviation.AutoSize = true;
            this.labelNoiseNormalDeviation.Location = new System.Drawing.Point(1, 235);
            this.labelNoiseNormalDeviation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseNormalDeviation.Name = "labelNoiseNormalDeviation";
            this.labelNoiseNormalDeviation.Size = new System.Drawing.Size(91, 20);
            this.labelNoiseNormalDeviation.TabIndex = 14;
            this.labelNoiseNormalDeviation.Text = "Дисперсия";
            // 
            // labelNoiseNormalMean
            // 
            this.labelNoiseNormalMean.AutoSize = true;
            this.labelNoiseNormalMean.Location = new System.Drawing.Point(9, 204);
            this.labelNoiseNormalMean.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoiseNormalMean.Name = "labelNoiseNormalMean";
            this.labelNoiseNormalMean.Size = new System.Drawing.Size(78, 20);
            this.labelNoiseNormalMean.TabIndex = 13;
            this.labelNoiseNormalMean.Text = "Медиана";
            // 
            // labelNoiseIdleMax
            // 
            this.labelNoiseIdleMax.AutoSize = true;
            this.labelNoiseIdleMax.Location = new System.Drawing.Point(8, 141);
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
            this.textNoiseNormalMean.Location = new System.Drawing.Point(95, 198);
            this.textNoiseNormalMean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseNormalMean.Name = "textNoiseNormalMean";
            this.textNoiseNormalMean.Size = new System.Drawing.Size(93, 26);
            this.textNoiseNormalMean.TabIndex = 10;
            this.textNoiseNormalMean.Text = "0.0";
            // 
            // textNoiseErlangK
            // 
            this.textNoiseErlangK.Location = new System.Drawing.Point(272, 148);
            this.textNoiseErlangK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseErlangK.Name = "textNoiseErlangK";
            this.textNoiseErlangK.Size = new System.Drawing.Size(93, 26);
            this.textNoiseErlangK.TabIndex = 9;
            this.textNoiseErlangK.Text = "10";
            // 
            // textNoiseExponentialLambda
            // 
            this.textNoiseExponentialLambda.Location = new System.Drawing.Point(272, 73);
            this.textNoiseExponentialLambda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseExponentialLambda.Name = "textNoiseExponentialLambda";
            this.textNoiseExponentialLambda.Size = new System.Drawing.Size(93, 26);
            this.textNoiseExponentialLambda.TabIndex = 8;
            this.textNoiseExponentialLambda.Text = "1.0";
            // 
            // textNoiseNormalDeviation
            // 
            this.textNoiseNormalDeviation.Location = new System.Drawing.Point(95, 232);
            this.textNoiseNormalDeviation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseNormalDeviation.Name = "textNoiseNormalDeviation";
            this.textNoiseNormalDeviation.Size = new System.Drawing.Size(93, 26);
            this.textNoiseNormalDeviation.TabIndex = 7;
            this.textNoiseNormalDeviation.Text = "10.0";
            // 
            // textNoiseUniformMax
            // 
            this.textNoiseUniformMax.Location = new System.Drawing.Point(95, 138);
            this.textNoiseUniformMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseUniformMax.Name = "textNoiseUniformMax";
            this.textNoiseUniformMax.Size = new System.Drawing.Size(93, 26);
            this.textNoiseUniformMax.TabIndex = 6;
            this.textNoiseUniformMax.Text = "10.0";
            // 
            // textNoiseUniformMin
            // 
            this.textNoiseUniformMin.Location = new System.Drawing.Point(95, 102);
            this.textNoiseUniformMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoiseUniformMin.Name = "textNoiseUniformMin";
            this.textNoiseUniformMin.Size = new System.Drawing.Size(93, 26);
            this.textNoiseUniformMin.TabIndex = 5;
            this.textNoiseUniformMin.Text = "-10.0";
            // 
            // radioNoiserErlang
            // 
            this.radioNoiserErlang.AutoSize = true;
            this.radioNoiserErlang.Location = new System.Drawing.Point(196, 108);
            this.radioNoiserErlang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNoiserErlang.Name = "radioNoiserErlang";
            this.radioNoiserErlang.Size = new System.Drawing.Size(99, 24);
            this.radioNoiserErlang.TabIndex = 4;
            this.radioNoiserErlang.Text = "Эрланга";
            this.radioNoiserErlang.UseVisualStyleBackColor = true;
            // 
            // radioNoiserExponential
            // 
            this.radioNoiserExponential.AutoSize = true;
            this.radioNoiserExponential.Location = new System.Drawing.Point(198, 38);
            this.radioNoiserExponential.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNoiserExponential.Name = "radioNoiserExponential";
            this.radioNoiserExponential.Size = new System.Drawing.Size(182, 24);
            this.radioNoiserExponential.TabIndex = 3;
            this.radioNoiserExponential.Text = "Экспоненциальный";
            this.radioNoiserExponential.UseVisualStyleBackColor = true;
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
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearStep);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearStep);
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearMax);
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearMin);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearMax);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearMin);
            this.groupBoxSourceLinear.Location = new System.Drawing.Point(486, 82);
            this.groupBoxSourceLinear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceLinear.Name = "groupBoxSourceLinear";
            this.groupBoxSourceLinear.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceLinear.Size = new System.Drawing.Size(226, 171);
            this.groupBoxSourceLinear.TabIndex = 5;
            this.groupBoxSourceLinear.TabStop = false;
            // 
            // labelLinearStep
            // 
            this.labelLinearStep.AutoSize = true;
            this.labelLinearStep.Location = new System.Drawing.Point(9, 89);
            this.labelLinearStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLinearStep.Name = "labelLinearStep";
            this.labelLinearStep.Size = new System.Drawing.Size(38, 20);
            this.labelLinearStep.TabIndex = 5;
            this.labelLinearStep.Text = "Шаг";
            // 
            // textSourceLinearStep
            // 
            this.textSourceLinearStep.Location = new System.Drawing.Point(68, 85);
            this.textSourceLinearStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceLinearStep.Name = "textSourceLinearStep";
            this.textSourceLinearStep.Size = new System.Drawing.Size(148, 26);
            this.textSourceLinearStep.TabIndex = 4;
            this.textSourceLinearStep.Text = "5.0";
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
            this.radioSourceEmulatorSin.Location = new System.Drawing.Point(250, 29);
            this.radioSourceEmulatorSin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceEmulatorSin.Name = "radioSourceEmulatorSin";
            this.radioSourceEmulatorSin.Size = new System.Drawing.Size(241, 24);
            this.radioSourceEmulatorSin.TabIndex = 1;
            this.radioSourceEmulatorSin.TabStop = true;
            this.radioSourceEmulatorSin.Text = "Эмулятор синусоидальный";
            this.radioSourceEmulatorSin.UseVisualStyleBackColor = true;
            // 
            // groupBoxSourceNetwrok
            // 
            this.groupBoxSourceNetwrok.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceNetwrok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxSourceNetwrok.Controls.Add(this.labelInterface);
            this.groupBoxSourceNetwrok.Controls.Add(this.radioSourceYaw);
            this.groupBoxSourceNetwrok.Controls.Add(this.comboIp);
            this.groupBoxSourceNetwrok.Controls.Add(this.radioSourceRoll);
            this.groupBoxSourceNetwrok.Controls.Add(this.radioSourcePitch);
            this.groupBoxSourceNetwrok.Location = new System.Drawing.Point(9, 82);
            this.groupBoxSourceNetwrok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceNetwrok.Name = "groupBoxSourceNetwrok";
            this.groupBoxSourceNetwrok.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceNetwrok.Size = new System.Drawing.Size(226, 169);
            this.groupBoxSourceNetwrok.TabIndex = 3;
            this.groupBoxSourceNetwrok.TabStop = false;
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
            // groupBoxSourceSin
            // 
            this.groupBoxSourceSin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceSin.Controls.Add(this.labelSinAverage);
            this.groupBoxSourceSin.Controls.Add(this.labelSinAmplitude);
            this.groupBoxSourceSin.Controls.Add(this.labelSinStep);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinAverage);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinAmplitude);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinStep);
            this.groupBoxSourceSin.Location = new System.Drawing.Point(250, 82);
            this.groupBoxSourceSin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceSin.Name = "groupBoxSourceSin";
            this.groupBoxSourceSin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSourceSin.Size = new System.Drawing.Size(226, 171);
            this.groupBoxSourceSin.TabIndex = 4;
            this.groupBoxSourceSin.TabStop = false;
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
            // labelSinStep
            // 
            this.labelSinStep.AutoSize = true;
            this.labelSinStep.Location = new System.Drawing.Point(3, 20);
            this.labelSinStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinStep.Name = "labelSinStep";
            this.labelSinStep.Size = new System.Drawing.Size(85, 20);
            this.labelSinStep.TabIndex = 3;
            this.labelSinStep.Text = "Шаг фазы";
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
            // textSourceSinStep
            // 
            this.textSourceSinStep.Location = new System.Drawing.Point(96, 15);
            this.textSourceSinStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSourceSinStep.Name = "textSourceSinStep";
            this.textSourceSinStep.Size = new System.Drawing.Size(120, 26);
            this.textSourceSinStep.TabIndex = 0;
            this.textSourceSinStep.Text = "1.0";
            // 
            // radioSourceNetwork
            // 
            this.radioSourceNetwork.AutoSize = true;
            this.radioSourceNetwork.Location = new System.Drawing.Point(9, 31);
            this.radioSourceNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSourceNetwork.Name = "radioSourceNetwork";
            this.radioSourceNetwork.Size = new System.Drawing.Size(123, 24);
            this.radioSourceNetwork.TabIndex = 0;
            this.radioSourceNetwork.Text = "Устройство";
            this.radioSourceNetwork.UseVisualStyleBackColor = true;
            // 
            // buttonSourceFourierClear
            // 
            this.buttonSourceFourierClear.Location = new System.Drawing.Point(6, 216);
            this.buttonSourceFourierClear.Name = "buttonSourceFourierClear";
            this.buttonSourceFourierClear.Size = new System.Drawing.Size(99, 31);
            this.buttonSourceFourierClear.TabIndex = 29;
            this.buttonSourceFourierClear.Text = "Очистить";
            this.buttonSourceFourierClear.UseVisualStyleBackColor = true;
            this.buttonSourceFourierClear.Click += new System.EventHandler(this.buttonSourceFourierClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1038);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.mainChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Analyzer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.groupBoxSourceFourier.ResumeLayout(false);
            this.groupBoxSourceFourier.PerformLayout();
            this.groupBoxNoise.ResumeLayout(false);
            this.groupBoxNoise.PerformLayout();
            this.groupBoxSourceLinear.ResumeLayout(false);
            this.groupBoxSourceLinear.PerformLayout();
            this.groupBoxSourceNetwrok.ResumeLayout(false);
            this.groupBoxSourceNetwrok.PerformLayout();
            this.groupBoxSourceSin.ResumeLayout(false);
            this.groupBoxSourceSin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerNetwork;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.RadioButton radioSourceEmulatorLinear;
        private System.Windows.Forms.RadioButton radioSourceEmulatorSin;
        private System.Windows.Forms.RadioButton radioSourceNetwork;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.RadioButton radioFilterSinglePole;
        private System.Windows.Forms.RadioButton radioFilterMovingAverage;
        private System.Windows.Forms.GroupBox groupBoxSourceSin;
        private System.Windows.Forms.GroupBox groupBoxSourceNetwrok;
        private System.Windows.Forms.GroupBox groupBoxSourceLinear;
        private System.Windows.Forms.RadioButton radioSourceYaw;
        private System.Windows.Forms.RadioButton radioSourceRoll;
        private System.Windows.Forms.RadioButton radioSourcePitch;
        private System.Windows.Forms.ComboBox comboIp;
        private System.Windows.Forms.Label labelInterface;
        private System.Windows.Forms.TextBox textSourceSinAverage;
        private System.Windows.Forms.TextBox textSourceSinAmplitude;
        private System.Windows.Forms.TextBox textSourceSinStep;
        private System.Windows.Forms.Label labelSinAverage;
        private System.Windows.Forms.Label labelSinAmplitude;
        private System.Windows.Forms.Label labelSinStep;
        private System.Windows.Forms.GroupBox groupBoxNoise;
        private System.Windows.Forms.Label labelLinearStep;
        private System.Windows.Forms.TextBox textSourceLinearStep;
        private System.Windows.Forms.Label labelLinearMax;
        private System.Windows.Forms.Label labelLinearMin;
        private System.Windows.Forms.TextBox textSourceLinearMax;
        private System.Windows.Forms.TextBox textSourceLinearMin;
        private System.Windows.Forms.RadioButton radioNoiserErlang;
        private System.Windows.Forms.RadioButton radioNoiserExponential;
        private System.Windows.Forms.RadioButton radioNoiserNormal;
        private System.Windows.Forms.RadioButton radioNoiserUniform;
        private System.Windows.Forms.RadioButton radioNoiserIdle;
        private System.Windows.Forms.Label labelNoiseErlangLambda;
        private System.Windows.Forms.TextBox textNoiseErlangLambda;
        private System.Windows.Forms.Label labelNoiseErlangK;
        private System.Windows.Forms.Label labelNoiseExponentialLambda;
        private System.Windows.Forms.Label labelNoiseNormalDeviation;
        private System.Windows.Forms.Label labelNoiseNormalMean;
        private System.Windows.Forms.Label labelNoiseIdleMax;
        private System.Windows.Forms.Label labelNoiseIdleMin;
        private System.Windows.Forms.TextBox textNoiseNormalMean;
        private System.Windows.Forms.TextBox textNoiseErlangK;
        private System.Windows.Forms.TextBox textNoiseExponentialLambda;
        private System.Windows.Forms.TextBox textNoiseNormalDeviation;
        private System.Windows.Forms.TextBox textNoiseUniformMax;
        private System.Windows.Forms.TextBox textNoiseUniformMin;
        private System.Windows.Forms.RadioButton radioNoiserFunction;
        private System.Windows.Forms.RadioButton radioSourceEmulatorFourier;
        private System.Windows.Forms.ListBox listBoxSourceFourierCoefficients;
        private System.Windows.Forms.TextBox textSourceFourierCoefficients;
        private System.Windows.Forms.Label labelNoiserFourierCoefficients;
        private System.Windows.Forms.TextBox textSourceFourierHalfOffset;
        private System.Windows.Forms.Label labelNoiserFourierHalfOffset;
        private System.Windows.Forms.Button buttonSourceFourierAdd;
        private System.Windows.Forms.GroupBox groupBoxSourceFourier;
        private System.Windows.Forms.Button buttonSourceFourierClear;
    }
}

