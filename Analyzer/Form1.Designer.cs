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
            this.radioSourceEmulatorSin = new System.Windows.Forms.RadioButton();
            this.radioSourceNetwork = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceNetwrok = new System.Windows.Forms.GroupBox();
            this.groupBoxSourceSin = new System.Windows.Forms.GroupBox();
            this.groupBoxSourceLinear = new System.Windows.Forms.GroupBox();
            this.radioSourcePitch = new System.Windows.Forms.RadioButton();
            this.radioSourceRoll = new System.Windows.Forms.RadioButton();
            this.radioSourceYaw = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBoxPanel.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxSourceNetwrok.SuspendLayout();
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
            this.mainChart.Size = new System.Drawing.Size(928, 381);
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
            this.groupBoxPanel.Size = new System.Drawing.Size(928, 169);
            this.groupBoxPanel.TabIndex = 2;
            this.groupBoxPanel.TabStop = false;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFilter.Controls.Add(this.radioFilterSinglePole);
            this.groupBoxFilter.Controls.Add(this.radioFilterMovingAverage);
            this.groupBoxFilter.Location = new System.Drawing.Point(714, 19);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(200, 137);
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
            this.groupBoxData.Size = new System.Drawing.Size(140, 137);
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
            this.groupBoxSource.Controls.Add(this.groupBoxSourceLinear);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceSin);
            this.groupBoxSource.Controls.Add(this.groupBoxSourceNetwrok);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorLinear);
            this.groupBoxSource.Controls.Add(this.radioSourceEmulatorSin);
            this.groupBoxSource.Controls.Add(this.radioSourceNetwork);
            this.groupBoxSource.Location = new System.Drawing.Point(165, 19);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(543, 137);
            this.groupBoxSource.TabIndex = 1;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Источник";
            // 
            // radioSourceEmulatorLinear
            // 
            this.radioSourceEmulatorLinear.AutoSize = true;
            this.radioSourceEmulatorLinear.Location = new System.Drawing.Point(342, 20);
            this.radioSourceEmulatorLinear.Name = "radioSourceEmulatorLinear";
            this.radioSourceEmulatorLinear.Size = new System.Drawing.Size(127, 17);
            this.radioSourceEmulatorLinear.TabIndex = 2;
            this.radioSourceEmulatorLinear.Text = "Эмулятор линейный";
            this.radioSourceEmulatorLinear.UseVisualStyleBackColor = true;
            // 
            // radioSourceEmulatorSin
            // 
            this.radioSourceEmulatorSin.AutoSize = true;
            this.radioSourceEmulatorSin.Checked = true;
            this.radioSourceEmulatorSin.Location = new System.Drawing.Point(181, 19);
            this.radioSourceEmulatorSin.Name = "radioSourceEmulatorSin";
            this.radioSourceEmulatorSin.Size = new System.Drawing.Size(162, 17);
            this.radioSourceEmulatorSin.TabIndex = 1;
            this.radioSourceEmulatorSin.TabStop = true;
            this.radioSourceEmulatorSin.Text = "Эмулятор синусоидальный";
            this.radioSourceEmulatorSin.UseVisualStyleBackColor = true;
            // 
            // radioSourceNetwork
            // 
            this.radioSourceNetwork.AutoSize = true;
            this.radioSourceNetwork.Location = new System.Drawing.Point(24, 20);
            this.radioSourceNetwork.Name = "radioSourceNetwork";
            this.radioSourceNetwork.Size = new System.Drawing.Size(85, 17);
            this.radioSourceNetwork.TabIndex = 0;
            this.radioSourceNetwork.Text = "Устройство";
            this.radioSourceNetwork.UseVisualStyleBackColor = true;
            // 
            // groupBoxSourceNetwrok
            // 
            this.groupBoxSourceNetwrok.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceNetwrok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxSourceNetwrok.Controls.Add(this.radioSourceYaw);
            this.groupBoxSourceNetwrok.Controls.Add(this.radioSourceRoll);
            this.groupBoxSourceNetwrok.Controls.Add(this.radioSourcePitch);
            this.groupBoxSourceNetwrok.Location = new System.Drawing.Point(24, 43);
            this.groupBoxSourceNetwrok.Name = "groupBoxSourceNetwrok";
            this.groupBoxSourceNetwrok.Size = new System.Drawing.Size(151, 77);
            this.groupBoxSourceNetwrok.TabIndex = 3;
            this.groupBoxSourceNetwrok.TabStop = false;
            // 
            // groupBoxSourceSin
            // 
            this.groupBoxSourceSin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceSin.Location = new System.Drawing.Point(181, 42);
            this.groupBoxSourceSin.Name = "groupBoxSourceSin";
            this.groupBoxSourceSin.Size = new System.Drawing.Size(151, 78);
            this.groupBoxSourceSin.TabIndex = 4;
            this.groupBoxSourceSin.TabStop = false;
            // 
            // groupBoxSourceLinear
            // 
            this.groupBoxSourceLinear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSourceLinear.Location = new System.Drawing.Point(342, 42);
            this.groupBoxSourceLinear.Name = "groupBoxSourceLinear";
            this.groupBoxSourceLinear.Size = new System.Drawing.Size(151, 78);
            this.groupBoxSourceLinear.TabIndex = 5;
            this.groupBoxSourceLinear.TabStop = false;
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
            // radioSourceYaw
            // 
            this.radioSourceYaw.AutoSize = true;
            this.radioSourceYaw.Location = new System.Drawing.Point(18, 54);
            this.radioSourceYaw.Name = "radioSourceYaw";
            this.radioSourceYaw.Size = new System.Drawing.Size(76, 17);
            this.radioSourceYaw.TabIndex = 2;
            this.radioSourceYaw.Text = "Рысканье";
            this.radioSourceYaw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 572);
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
            this.groupBoxSourceNetwrok.ResumeLayout(false);
            this.groupBoxSourceNetwrok.PerformLayout();
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
    }
}

