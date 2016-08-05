namespace ComputerMetrix
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.refreshButton = new System.Windows.Forms.Button();
            this.computerNameText = new System.Windows.Forms.TextBox();
            this.currentUserText = new System.Windows.Forms.TextBox();
            this.cpuNameText = new System.Windows.Forms.TextBox();
            this.totalRamText = new System.Windows.Forms.TextBox();
            this.videoCardText = new System.Windows.Forms.TextBox();
            this.currentIpText = new System.Windows.Forms.TextBox();
            this.cpuUsageText = new System.Windows.Forms.TextBox();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.ramUsageText = new System.Windows.Forms.TextBox();
            this.freeSpaceText = new System.Windows.Forms.TextBox();
            this.averageQueueText = new System.Windows.Forms.TextBox();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.cpuNameLabel = new System.Windows.Forms.Label();
            this.totalRamLabel = new System.Windows.Forms.Label();
            this.videoCardLabel = new System.Windows.Forms.Label();
            this.currentIpLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.ramUsageLabel = new System.Windows.Forms.Label();
            this.freeSpaceLabel = new System.Windows.Forms.Label();
            this.averageQueueLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(11, 285);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(97, 25);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.cpuButton_Click);
            // 
            // computerNameText
            // 
            this.computerNameText.Location = new System.Drawing.Point(110, 12);
            this.computerNameText.Name = "computerNameText";
            this.computerNameText.Size = new System.Drawing.Size(164, 20);
            this.computerNameText.TabIndex = 1;
            // 
            // currentUserText
            // 
            this.currentUserText.Location = new System.Drawing.Point(110, 38);
            this.currentUserText.Name = "currentUserText";
            this.currentUserText.Size = new System.Drawing.Size(164, 20);
            this.currentUserText.TabIndex = 2;
            // 
            // cpuNameText
            // 
            this.cpuNameText.Location = new System.Drawing.Point(110, 64);
            this.cpuNameText.Name = "cpuNameText";
            this.cpuNameText.Size = new System.Drawing.Size(164, 20);
            this.cpuNameText.TabIndex = 3;
            // 
            // totalRamText
            // 
            this.totalRamText.Location = new System.Drawing.Point(110, 90);
            this.totalRamText.Name = "totalRamText";
            this.totalRamText.Size = new System.Drawing.Size(164, 20);
            this.totalRamText.TabIndex = 4;
            this.totalRamText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // videoCardText
            // 
            this.videoCardText.Location = new System.Drawing.Point(110, 116);
            this.videoCardText.Name = "videoCardText";
            this.videoCardText.Size = new System.Drawing.Size(164, 20);
            this.videoCardText.TabIndex = 5;
            // 
            // currentIpText
            // 
            this.currentIpText.Location = new System.Drawing.Point(110, 142);
            this.currentIpText.Name = "currentIpText";
            this.currentIpText.Size = new System.Drawing.Size(164, 20);
            this.currentIpText.TabIndex = 6;
            // 
            // cpuUsageText
            // 
            this.cpuUsageText.Location = new System.Drawing.Point(110, 168);
            this.cpuUsageText.Name = "cpuUsageText";
            this.cpuUsageText.Size = new System.Drawing.Size(164, 20);
            this.cpuUsageText.TabIndex = 7;
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(8, 15);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(83, 13);
            this.computerNameLabel.TabIndex = 8;
            this.computerNameLabel.Text = "Computer Name";
            // 
            // ramUsageText
            // 
            this.ramUsageText.Location = new System.Drawing.Point(110, 194);
            this.ramUsageText.Name = "ramUsageText";
            this.ramUsageText.Size = new System.Drawing.Size(164, 20);
            this.ramUsageText.TabIndex = 9;
            // 
            // freeSpaceText
            // 
            this.freeSpaceText.Location = new System.Drawing.Point(110, 220);
            this.freeSpaceText.Name = "freeSpaceText";
            this.freeSpaceText.Size = new System.Drawing.Size(164, 20);
            this.freeSpaceText.TabIndex = 10;
            // 
            // averageQueueText
            // 
            this.averageQueueText.Location = new System.Drawing.Point(110, 246);
            this.averageQueueText.Name = "averageQueueText";
            this.averageQueueText.Size = new System.Drawing.Size(164, 20);
            this.averageQueueText.TabIndex = 11;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(8, 41);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(66, 13);
            this.currentUserLabel.TabIndex = 12;
            this.currentUserLabel.Text = "Current User";
            // 
            // cpuNameLabel
            // 
            this.cpuNameLabel.AutoSize = true;
            this.cpuNameLabel.Location = new System.Drawing.Point(8, 67);
            this.cpuNameLabel.Name = "cpuNameLabel";
            this.cpuNameLabel.Size = new System.Drawing.Size(29, 13);
            this.cpuNameLabel.TabIndex = 13;
            this.cpuNameLabel.Text = "CPU";
            // 
            // totalRamLabel
            // 
            this.totalRamLabel.AutoSize = true;
            this.totalRamLabel.Location = new System.Drawing.Point(8, 93);
            this.totalRamLabel.Name = "totalRamLabel";
            this.totalRamLabel.Size = new System.Drawing.Size(31, 13);
            this.totalRamLabel.TabIndex = 14;
            this.totalRamLabel.Text = "RAM";
            // 
            // videoCardLabel
            // 
            this.videoCardLabel.AutoSize = true;
            this.videoCardLabel.Location = new System.Drawing.Point(8, 119);
            this.videoCardLabel.Name = "videoCardLabel";
            this.videoCardLabel.Size = new System.Drawing.Size(30, 13);
            this.videoCardLabel.TabIndex = 15;
            this.videoCardLabel.Text = "GPU";
            // 
            // currentIpLabel
            // 
            this.currentIpLabel.AutoSize = true;
            this.currentIpLabel.Location = new System.Drawing.Point(8, 145);
            this.currentIpLabel.Name = "currentIpLabel";
            this.currentIpLabel.Size = new System.Drawing.Size(58, 13);
            this.currentIpLabel.TabIndex = 16;
            this.currentIpLabel.Text = "IP Address";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(8, 171);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(63, 13);
            this.cpuUsageLabel.TabIndex = 17;
            this.cpuUsageLabel.Text = "CPU Usage";
            // 
            // ramUsageLabel
            // 
            this.ramUsageLabel.AutoSize = true;
            this.ramUsageLabel.Location = new System.Drawing.Point(8, 197);
            this.ramUsageLabel.Name = "ramUsageLabel";
            this.ramUsageLabel.Size = new System.Drawing.Size(65, 13);
            this.ramUsageLabel.TabIndex = 18;
            this.ramUsageLabel.Text = "RAM Usage";
            // 
            // freeSpaceLabel
            // 
            this.freeSpaceLabel.AutoSize = true;
            this.freeSpaceLabel.Location = new System.Drawing.Point(8, 223);
            this.freeSpaceLabel.Name = "freeSpaceLabel";
            this.freeSpaceLabel.Size = new System.Drawing.Size(62, 13);
            this.freeSpaceLabel.TabIndex = 19;
            this.freeSpaceLabel.Text = "Free Space";
            // 
            // averageQueueLabel
            // 
            this.averageQueueLabel.AutoSize = true;
            this.averageQueueLabel.Location = new System.Drawing.Point(8, 249);
            this.averageQueueLabel.Name = "averageQueueLabel";
            this.averageQueueLabel.Size = new System.Drawing.Size(96, 13);
            this.averageQueueLabel.TabIndex = 20;
            this.averageQueueLabel.Text = "Avg. Queue lenght";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(280, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CPU Usage";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RAM Usage";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(506, 254);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "cpuUsage";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 322);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.averageQueueLabel);
            this.Controls.Add(this.freeSpaceLabel);
            this.Controls.Add(this.ramUsageLabel);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.currentIpLabel);
            this.Controls.Add(this.videoCardLabel);
            this.Controls.Add(this.totalRamLabel);
            this.Controls.Add(this.cpuNameLabel);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.averageQueueText);
            this.Controls.Add(this.freeSpaceText);
            this.Controls.Add(this.ramUsageText);
            this.Controls.Add(this.computerNameLabel);
            this.Controls.Add(this.cpuUsageText);
            this.Controls.Add(this.currentIpText);
            this.Controls.Add(this.videoCardText);
            this.Controls.Add(this.totalRamText);
            this.Controls.Add(this.cpuNameText);
            this.Controls.Add(this.currentUserText);
            this.Controls.Add(this.computerNameText);
            this.Controls.Add(this.refreshButton);
            this.Name = "Form1";
            this.Text = "ComputerMetrix ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox computerNameText;
        private System.Windows.Forms.TextBox currentUserText;
        private System.Windows.Forms.TextBox cpuNameText;
        private System.Windows.Forms.TextBox totalRamText;
        private System.Windows.Forms.TextBox videoCardText;
        private System.Windows.Forms.TextBox currentIpText;
        private System.Windows.Forms.TextBox cpuUsageText;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.TextBox ramUsageText;
        private System.Windows.Forms.TextBox freeSpaceText;
        private System.Windows.Forms.TextBox averageQueueText;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label cpuNameLabel;
        private System.Windows.Forms.Label totalRamLabel;
        private System.Windows.Forms.Label videoCardLabel;
        private System.Windows.Forms.Label currentIpLabel;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Label ramUsageLabel;
        private System.Windows.Forms.Label freeSpaceLabel;
        private System.Windows.Forms.Label averageQueueLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

