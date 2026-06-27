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
    public partial class StudentShell : Form
    {
        private User _currentUser;
        public StudentShell(User user)
        {
            InitializeComponent();
            _currentUser = user;
            lblUserName.Text = $"Welcome, {user.FullName}";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Load Dashboard control later
        }

        private void btnAvailableQuizzes_Click(object sender, EventArgs e)
        {
            LoadControl(new AvailableQuizzesControl(_currentUser.UserID));
        }

        private void btnMyHistory_Click(object sender, EventArgs e)
        {
            // Load history control later
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void LoadControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }
    }
}
