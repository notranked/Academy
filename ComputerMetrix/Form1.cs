using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using Graph = System.Windows.Forms.DataVisualization.Charting;
using DatabaseTest;

namespace ComputerMetrix
{
    public partial class Form1 : Form
    {
        private ComputerSummary cs;
        private int timer = 0;

        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart1.Series.Add("CPU Usage");
            chart1.Series.Add("RAM Usage");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpuButton_Click(object sender, EventArgs e)
        {
            cs = new DatabaseManager().GetMetrics();
            computerNameText.Text = cs.Name;
            currentUserText.Text = cs.User;
            cpuNameText.Text = cs.Cpu;
            totalRamText.Text = cs.Ram + " MB";
            videoCardText.Text = cs.VideoCard;
            currentIpText.Text = cs.Ip.ToString();
            cpuUsageText.Text = cs.CpuUsage + " %";
            ramUsageText.Text = cs.RamUsage + " %";
            freeSpaceText.Text = cs.AvailableDiskSpaceGb + " MB";
            averageQueueText.Text = cs.AverageDiskQueueLength.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series["CPU Usage"].ChartType = Graph.SeriesChartType.Line;
            chart1.Series["CPU Usage"].Color = Color.Blue;
            chart1.Series["CPU Usage"].Points.AddXY(timer,
                new FullDataManager().GetMetric("cpuusage"));

            chart1.Series["RAM Usage"].ChartType = Graph.SeriesChartType.Line;
            chart1.Series["RAM Usage"].Color = Color.Red;
            chart1.Series["RAM Usage"].Points.AddXY(timer,
                new FullDataManager().GetMetric("ramusage"));

            timer++;
        }
    }
}
