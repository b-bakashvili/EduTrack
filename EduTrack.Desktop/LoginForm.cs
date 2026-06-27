using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduTrack.Core;
using EduTrack.Models;

namespace EduTrack.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AuthService authService = new AuthService();
            User loggedInUser = authService.Login(email, password);

            if (loggedInUser == null)
            {
                MessageBox.Show("Invalid email or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loggedInUser.Role == "Teacher")
            {
                TeacherShell teacherShell = new TeacherShell(loggedInUser);
                teacherShell.Show();
                this.Hide();
            }
            else
            {
                StudentShell studentShell = new StudentShell(loggedInUser);
                studentShell.Show();
                this.Hide();
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
