using EduTrack.Data;
using EduTrack.Models;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduTrack.Desktop
{
    public partial class StudentProfileForm : Form
    {
        private readonly int _studentID;
        private readonly string _studentName;
        private readonly AttemptRepository _attemptRepository;
        private readonly StatsRepository _statsRepository;

        public StudentProfileForm(int studentID, string studentName)
        {
            InitializeComponent();
            _studentID = studentID;
            _studentName = studentName;
            _attemptRepository = new AttemptRepository();
            _statsRepository = new StatsRepository();
            SetupChart();
            LoadProfile();
        }

        private void SetupChart()
        {
            chartProgress.ChartAreas.Clear();
            chartProgress.Series.Clear();
            chartProgress.Legends.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 100;
            chartArea.AxisY.Title = "Score (%)";
            chartArea.AxisX.Title = "Attempt";
            chartArea.AxisY.MajorGrid.LineColor = Color.White;
            chartProgress.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.FromArgb(58, 123, 213);
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.FromArgb(58, 123, 213);
            chartProgress.Series.Add(series);

            chartProgress.BackColor = Color.White;
            chartProgress.BorderlineDashStyle = ChartDashStyle.NotSet;
        }

        private void LoadProfile()
        {
            lblStudentName.Text = _studentName;

            StudentStats stats = _statsRepository.GetByStudentID(_studentID);
            if(stats != null)
            {
                lblStats.Text = $"Average: {stats.AverageScore}% | " +
                                $"Category {stats.CurrentCategory} | " +
                                $"Attempts: {stats.TotalAttempts}";
            }

            List<QuizAttempt> attempts = _attemptRepository.GetByStudentID(_studentID);
            chartProgress.Series[0].Points.Clear();

            for(int i = 0; i < attempts.Count; i++)
            {
                chartProgress.Series[0].Points.AddXY(i + 1, (double)attempts[i].Score);
            }

            StripLine weakLine = new StripLine();
            weakLine.IntervalOffset = 50;
            weakLine.StripWidth = 0.5;
            weakLine.BackColor = Color.FromArgb(224, 82, 82);
            chartProgress.ChartAreas[0].AxisY.StripLines.Add(weakLine);

            StripLine strongLine = new StripLine();
            strongLine.IntervalOffset = 75;
            strongLine.StripWidth = 0.5;
            strongLine.BackColor = Color.FromArgb(61, 190, 108);
            chartProgress.ChartAreas[0].AxisY.StripLines.Add(strongLine);
        }
    }
}
