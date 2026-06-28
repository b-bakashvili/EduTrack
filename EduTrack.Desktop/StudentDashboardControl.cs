using EduTrack.Core;
using EduTrack.Data;
using EduTrack.Models;
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
    public partial class StudentDashboardControl : UserControl
    {
        private readonly StatsService _statsService;
        private readonly StatsRepository _statsRepository;
        private readonly int _studentID;
        public StudentDashboardControl(int studentID)
        {
            InitializeComponent();
            _statsRepository = new StatsRepository();
            _studentID = studentID;
            LoadStats();
        }

        private void LoadStats()
        {
            EduTrack.Data.StatsRepository statsRepo = new EduTrack.Data.StatsRepository();
            StudentStats stats = statsRepo.GetByStudentID(_studentID);

            if(stats == null)
            {
                lblAverageScore.Text = "Average Score: No quizzes taken yet";
                lblCategory.Text = "Category: -";
                lblTotalAttempts.Text = "Total Quizzes Taken: 0";
                return;
            }

            lblAverageScore.Text = $"Average Score: {stats.AverageScore}%";
            lblTotalAttempts.Text = $"Total Quizzes Taken: {stats.TotalAttempts}";
            lblCategory.Text = $"Category: {stats.CurrentCategory}";

            if(stats.CurrentCategory == "Strong")
            {
                lblCategory.ForeColor = Color.FromArgb(61, 190, 108);
            }
            else if(stats.CurrentCategory == "Normal")
            {
                lblCategory.ForeColor = Color.FromArgb(244, 168, 42);
            }
            else
            {
                lblCategory.ForeColor = Color.FromArgb(224, 82, 82);
            }
        }
    }
}
