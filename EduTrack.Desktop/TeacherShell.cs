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
    public partial class TeacherShell : Form
    {
        private User _currentUser;
        public TeacherShell(User user)
        {
            InitializeComponent();
            _currentUser = user;
            lblUserName.Text = $"Welcome, {user.FullName}";
        }

        private void LoadControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // We will load dashboard UserControl here later
        }

        private void btnManageQuizzes_Click(object sender, EventArgs e)
        {
            // We will load quiz management UserControl here later
        }

        private void btnClassOverview_Click(object sender, EventArgs e)
        {
            // We will load class overview UserControl here later
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
