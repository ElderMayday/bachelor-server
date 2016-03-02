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
            this.label1 = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.radioFilterSinglePole = new System.Windows.Forms.RadioButton();
            this.radioFilterMovingAverage = new System.Windows.Forms.RadioButton();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.radioSourceEmulatorLinear = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBoxPanel.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSourceLinear.SuspendLayout();
            this.groupBoxSourceNetwrok.SuspendLayout();
            this.groupBoxSourceSin.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerNetwork
            // 
            this.timerNetwork.Tick += new System.EventHandler(this.timerNetwork_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No data";
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
            this.mainChart.Size = new System.Drawing.Size(1124, 381);
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
            this.groupBoxPanel.Size = new System.Drawing.Size(1124, 380);
            this.groupBoxPanel.TabIndex = 2;
            this.groupBoxPanel.TabStop = false;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFilter.Controls.Add(this.radioFilterSinglePole);
            this.groupBoxFilter.Controls.Add(this.radioFilterMovingAverage);
            this.groupBoxFilter.Location = new System.Drawing.Point(909, 19);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(192, 349);
            this.groupBoxFilter.TabIndex = 3;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Фильтр";
            // 
            // radioFilterSinglePole
            // 
            this.radioFilterSinglePole.AutoSize = true;
            this.radioFilterSinglePole.Location = new System.Drawing.Point(28, 45);
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
            this.radioFilterMovingAverage.Location = new System.Drawing.Point(28, 22);
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
            this.groupBoxData.Controls.Add(this.buttonSwitch);
            this.groupBoxData.Controls.Add(this.label1);
            this.groupBoxData.Location = new System.Drawing.Point(19, 19);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(140, 349);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(9, 53);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(125, 41);
            this.buttonSwitch.TabIndex = 1;
            this.buttonSwitch.Text = "Включить";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorLinear);
            this.groupBoxSource.Controls.Add(this.groupBox2);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceLinear);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorSin);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceNetwrok);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceSin);
            this.groupBoxSource.Controls.Add(this.radioSourceNetwork);
            this.groupBoxSource.Location = new System.Drawing.Point(165, 19);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(738, 349);
            this.groupBoxSource.TabIndex = 1;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Источник";
            // 
            // radioSourceEmulatorLinear
            // 
            this.radioSourceEmulatorLinear.AutoSize = true;
            this.radioSourceEmulatorLinear.Location = new System.Drawing.Point(324, 19);
            this.radioSourceEmulatorLinear.Name = "radioSourceEmulatorLinear";
            this.radioSourceEmulatorLinear.Size = new System.Drawing.Size(127, 17);
            this.radioSourceEmulatorLinear.TabIndex = 2;
            this.radioSourceEmulatorLinear.Text = "Эмулятор линейный";
            this.radioSourceEmulatorLinear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.radioNoiserFunction);
            this.groupBox2.Controls.Add(this.labelNoiseErlangLambda);
            this.groupBox2.Controls.Add(this.textNoiseErlangLambda);
            this.groupBox2.Controls.Add(this.labelNoiseErlangK);
            this.groupBox2.Controls.Add(this.labelNoiseExponentialLambda);
            this.groupBox2.Controls.Add(this.labelNoiseNormalDeviation);
            this.groupBox2.Controls.Add(this.labelNoiseNormalMean);
            this.groupBox2.Controls.Add(this.labelNoiseIdleMax);
            this.groupBox2.Controls.Add(this.labelNoiseIdleMin);
            this.groupBox2.Controls.Add(this.textNoiseNormalMean);
            this.groupBox2.Controls.Add(this.textNoiseErlangK);
            this.groupBox2.Controls.Add(this.textNoiseExponentialLambda);
            this.groupBox2.Controls.Add(this.textNoiseNormalDeviation);
            this.groupBox2.Controls.Add(this.textNoiseUniformMax);
            this.groupBox2.Controls.Add(this.textNoiseUniformMin);
            this.groupBox2.Controls.Add(this.radioNoiserErlang);
            this.groupBox2.Controls.Add(this.radioNoiserExponential);
            this.groupBox2.Controls.Add(this.radioNoiserNormal);
            this.groupBox2.Controls.Add(this.radioNoiserUniform);
            this.groupBox2.Controls.Add(this.radioNoiserIdle);
            this.groupBox2.Location = new System.Drawing.Point(481, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 323);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шум";
            // 
            // radioNoiserFunction
            // 
            this.radioNoiserFunction.AutoSize = true;
            this.radioNoiserFunction.Location = new System.Drawing.Point(128, 24);
            this.radioNoiserFunction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNoiserFunction.Name = "radioNoiserFunction";
            this.radioNoiserFunction.Size = new System.Drawing.Size(72, 17);
            this.radioNoiserFunction.TabIndex = 19;
            this.radioNoiserFunction.TabStop = true;
            this.radioNoiserFunction.Text = "Кусочная";
            this.radioNoiserFunction.UseVisualStyleBackColor = true;
            // 
            // labelNoiseErlangLambda
            // 
            this.labelNoiseErlangLambda.AutoSize = true;
            this.labelNoiseErlangLambda.Location = new System.Drawing.Point(15, 300);
            this.labelNoiseErlangLambda.Name = "labelNoiseErlangLambda";
            this.labelNoiseErlangLambda.Size = new System.Drawing.Size(47, 13);
            this.labelNoiseErlangLambda.TabIndex = 18;
            this.labelNoiseErlangLambda.Text = "Лямбда";
            // 
            // textNoiseErlangLambda
            // 
            this.textNoiseErlangLambda.Location = new System.Drawing.Point(76, 297);
            this.textNoiseErlangLambda.Name = "textNoiseErlangLambda";
            this.textNoiseErlangLambda.Size = new System.Drawing.Size(86, 20);
            this.textNoiseErlangLambda.TabIndex = 17;
            this.textNoiseErlangLambda.Text = "5.0";
            // 
            // labelNoiseErlangK
            // 
            this.labelNoiseErlangK.AutoSize = true;
            this.labelNoiseErlangK.Location = new System.Drawing.Point(15, 271);
            this.labelNoiseErlangK.Name = "labelNoiseErlangK";
            this.labelNoiseErlangK.Size = new System.Drawing.Size(14, 13);
            this.labelNoiseErlangK.TabIndex = 16;
            this.labelNoiseErlangK.Text = "K";
            // 
            // labelNoiseExponentialLambda
            // 
            this.labelNoiseExponentialLambda.AutoSize = true;
            this.labelNoiseExponentialLambda.Location = new System.Drawing.Point(15, 225);
            this.labelNoiseExponentialLambda.Name = "labelNoiseExponentialLambda";
            this.labelNoiseExponentialLambda.Size = new System.Drawing.Size(47, 13);
            this.labelNoiseExponentialLambda.TabIndex = 15;
            this.labelNoiseExponentialLambda.Text = "Лямбда";
            // 
            // labelNoiseNormalDeviation
            // 
            this.labelNoiseNormalDeviation.AutoSize = true;
            this.labelNoiseNormalDeviation.Location = new System.Drawing.Point(6, 179);
            this.labelNoiseNormalDeviation.Name = "labelNoiseNormalDeviation";
            this.labelNoiseNormalDeviation.Size = new System.Drawing.Size(64, 13);
            this.labelNoiseNormalDeviation.TabIndex = 14;
            this.labelNoiseNormalDeviation.Text = "Дисперсия";
            // 
            // labelNoiseNormalMean
            // 
            this.labelNoiseNormalMean.AutoSize = true;
            this.labelNoiseNormalMean.Location = new System.Drawing.Point(6, 153);
            this.labelNoiseNormalMean.Name = "labelNoiseNormalMean";
            this.labelNoiseNormalMean.Size = new System.Drawing.Size(52, 13);
            this.labelNoiseNormalMean.TabIndex = 13;
            this.labelNoiseNormalMean.Text = "Медиана";
            // 
            // labelNoiseIdleMax
            // 
            this.labelNoiseIdleMax.AutoSize = true;
            this.labelNoiseIdleMax.Location = new System.Drawing.Point(6, 104);
            this.labelNoiseIdleMax.Name = "labelNoiseIdleMax";
            this.labelNoiseIdleMax.Size = new System.Drawing.Size(37, 13);
            this.labelNoiseIdleMax.TabIndex = 12;
            this.labelNoiseIdleMax.Text = "Макс.";
            // 
            // labelNoiseIdleMin
            // 
            this.labelNoiseIdleMin.AutoSize = true;
            this.labelNoiseIdleMin.Location = new System.Drawing.Point(6, 78);
            this.labelNoiseIdleMin.Name = "labelNoiseIdleMin";
            this.labelNoiseIdleMin.Size = new System.Drawing.Size(31, 13);
            this.labelNoiseIdleMin.TabIndex = 11;
            this.labelNoiseIdleMin.Text = "Мин.";
            // 
            // textNoiseNormalMean
            // 
            this.textNoiseNormalMean.Location = new System.Drawing.Point(76, 150);
            this.textNoiseNormalMean.Name = "textNoiseNormalMean";
            this.textNoiseNormalMean.Size = new System.Drawing.Size(86, 20);
            this.textNoiseNormalMean.TabIndex = 10;
            this.textNoiseNormalMean.Text = "0.0";
            // 
            // textNoiseErlangK
            // 
            this.textNoiseErlangK.Location = new System.Drawing.Point(76, 271);
            this.textNoiseErlangK.Name = "textNoiseErlangK";
            this.textNoiseErlangK.Size = new System.Drawing.Size(86, 20);
            this.textNoiseErlangK.TabIndex = 9;
            this.textNoiseErlangK.Text = "10";
            // 
            // textNoiseExponentialLambda
            // 
            this.textNoiseExponentialLambda.Location = new System.Drawing.Point(76, 225);
            this.textNoiseExponentialLambda.Name = "textNoiseExponentialLambda";
            this.textNoiseExponentialLambda.Size = new System.Drawing.Size(86, 20);
            this.textNoiseExponentialLambda.TabIndex = 8;
            this.textNoiseExponentialLambda.Text = "1.0";
            // 
            // textNoiseNormalDeviation
            // 
            this.textNoiseNormalDeviation.Location = new System.Drawing.Point(76, 176);
            this.textNoiseNormalDeviation.Name = "textNoiseNormalDeviation";
            this.textNoiseNormalDeviation.Size = new System.Drawing.Size(86, 20);
            this.textNoiseNormalDeviation.TabIndex = 7;
            this.textNoiseNormalDeviation.Text = "10.0";
            // 
            // textNoiseUniformMax
            // 
            this.textNoiseUniformMax.Location = new System.Drawing.Point(76, 97);
            this.textNoiseUniformMax.Name = "textNoiseUniformMax";
            this.textNoiseUniformMax.Size = new System.Drawing.Size(86, 20);
            this.textNoiseUniformMax.TabIndex = 6;
            this.textNoiseUniformMax.Text = "10.0";
            // 
            // textNoiseUniformMin
            // 
            this.textNoiseUniformMin.Location = new System.Drawing.Point(76, 71);
            this.textNoiseUniformMin.Name = "textNoiseUniformMin";
            this.textNoiseUniformMin.Size = new System.Drawing.Size(86, 20);
            this.textNoiseUniformMin.TabIndex = 5;
            this.textNoiseUniformMin.Text = "-10.0";
            // 
            // radioNoiserErlang
            // 
            this.radioNoiserErlang.AutoSize = true;
            this.radioNoiserErlang.Location = new System.Drawing.Point(15, 251);
            this.radioNoiserErlang.Name = "radioNoiserErlang";
            this.radioNoiserErlang.Size = new System.Drawing.Size(67, 17);
            this.radioNoiserErlang.TabIndex = 4;
            this.radioNoiserErlang.Text = "Эрланга";
            this.radioNoiserErlang.UseVisualStyleBackColor = true;
            // 
            // radioNoiserExponential
            // 
            this.radioNoiserExponential.AutoSize = true;
            this.radioNoiserExponential.Location = new System.Drawing.Point(15, 202);
            this.radioNoiserExponential.Name = "radioNoiserExponential";
            this.radioNoiserExponential.Size = new System.Drawing.Size(124, 17);
            this.radioNoiserExponential.TabIndex = 3;
            this.radioNoiserExponential.Text = "Экспоненциальный";
            this.radioNoiserExponential.UseVisualStyleBackColor = true;
            // 
            // radioNoiserNormal
            // 
            this.radioNoiserNormal.AutoSize = true;
            this.radioNoiserNormal.Location = new System.Drawing.Point(15, 123);
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
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearStep);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearStep);
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearMax);
            this.groupBoxSourceLinear.Controls.Add(this.labelLinearMin);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearMax);
            this.groupBoxSourceLinear.Controls.Add(this.textSourceLinearMin);
            this.groupBoxSourceLinear.Location = new System.Drawing.Point(324, 53);
            this.groupBoxSourceLinear.Name = "groupBoxSourceLinear";
            this.groupBoxSourceLinear.Size = new System.Drawing.Size(151, 111);
            this.groupBoxSourceLinear.TabIndex = 5;
            this.groupBoxSourceLinear.TabStop = false;
            // 
            // labelLinearStep
            // 
            this.labelLinearStep.AutoSize = true;
            this.labelLinearStep.Location = new System.Drawing.Point(6, 58);
            this.labelLinearStep.Name = "labelLinearStep";
            this.labelLinearStep.Size = new System.Drawing.Size(27, 13);
            this.labelLinearStep.TabIndex = 5;
            this.labelLinearStep.Text = "Шаг";
            // 
            // textSourceLinearStep
            // 
            this.textSourceLinearStep.Location = new System.Drawing.Point(45, 55);
            this.textSourceLinearStep.Name = "textSourceLinearStep";
            this.textSourceLinearStep.Size = new System.Drawing.Size(100, 20);
            this.textSourceLinearStep.TabIndex = 4;
            this.textSourceLinearStep.Text = "5.0";
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
            this.radioSourceEmulatorSin.Location = new System.Drawing.Point(167, 19);
            this.radioSourceEmulatorSin.Name = "radioSourceEmulatorSin";
            this.radioSourceEmulatorSin.Size = new System.Drawing.Size(162, 17);
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
            this.groupBoxSourceNetwrok.Location = new System.Drawing.Point(6, 53);
            this.groupBoxSourceNetwrok.Name = "groupBoxSourceNetwrok";
            this.groupBoxSourceNetwrok.Size = new System.Drawing.Size(151, 110);
            this.groupBoxSourceNetwrok.TabIndex = 3;
            this.groupBoxSourceNetwrok.TabStop = false;
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
            // groupBoxSourceSin
            // 
            this.groupBoxSourceSin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceSin.Controls.Add(this.labelSinAverage);
            this.groupBoxSourceSin.Controls.Add(this.labelSinAmplitude);
            this.groupBoxSourceSin.Controls.Add(this.labelSinStep);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinAverage);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinAmplitude);
            this.groupBoxSourceSin.Controls.Add(this.textSourceSinStep);
            this.groupBoxSourceSin.Location = new System.Drawing.Point(167, 53);
            this.groupBoxSourceSin.Name = "groupBoxSourceSin";
            this.groupBoxSourceSin.Size = new System.Drawing.Size(151, 111);
            this.groupBoxSourceSin.TabIndex = 4;
            this.groupBoxSourceSin.TabStop = false;
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
            // labelSinStep
            // 
            this.labelSinStep.AutoSize = true;
            this.labelSinStep.Location = new System.Drawing.Point(2, 13);
            this.labelSinStep.Name = "labelSinStep";
            this.labelSinStep.Size = new System.Drawing.Size(58, 13);
            this.labelSinStep.TabIndex = 3;
            this.labelSinStep.Text = "Шаг фазы";
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
            // textSourceSinStep
            // 
            this.textSourceSinStep.Location = new System.Drawing.Point(64, 10);
            this.textSourceSinStep.Name = "textSourceSinStep";
            this.textSourceSinStep.Size = new System.Drawing.Size(81, 20);
            this.textSourceSinStep.TabIndex = 0;
            this.textSourceSinStep.Text = "1.0";
            // 
            // radioSourceNetwork
            // 
            this.radioSourceNetwork.AutoSize = true;
            this.radioSourceNetwork.Location = new System.Drawing.Point(6, 20);
            this.radioSourceNetwork.Name = "radioSourceNetwork";
            this.radioSourceNetwork.Size = new System.Drawing.Size(85, 17);
            this.radioSourceNetwork.TabIndex = 0;
            this.radioSourceNetwork.Text = "Устройство";
            this.radioSourceNetwork.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 782);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.mainChart);
            this.Name = "Form1";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

