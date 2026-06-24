namespace EduTrack.Desktop
{
    partial class RegisterForm
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
            panelLeft = new Panel();
            lblSubtitle = new Label();
            lblAppName = new Label();
            panelRight = new Panel();
            lblLogin = new Label();
            btnRegister = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblTitle = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(27, 42, 74);
            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(lblAppName);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(350, 553);
            panelLeft.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.FromArgb(174, 198, 230);
            lblSubtitle.Location = new Point(67, 98);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(179, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Student Progress Tracking";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(67, 31);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(192, 54);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "EduTrack\r\n";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(lblLogin);
            panelRight.Controls.Add(btnRegister);
            panelRight.Controls.Add(cmbRole);
            panelRight.Controls.Add(lblRole);
            panelRight.Controls.Add(txtPassword);
            panelRight.Controls.Add(lblPassword);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(txtFullName);
            panelRight.Controls.Add(lblFullName);
            panelRight.Controls.Add(lblTitle);
            panelRight.Location = new Point(346, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(536, 553);
            panelRight.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(58, 123, 213);
            lblLogin.Location = new Point(186, 375);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(219, 20);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Already have an account? Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(58, 123, 213);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(127, 316);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(350, 45);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Teacher", "Student" });
            cmbRole.Location = new Point(127, 263);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(350, 31);
            cmbRole.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(27, 42, 74);
            lblRole.Location = new Point(81, 268);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(40, 20);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(127, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(350, 30);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(27, 42, 74);
            lblPassword.Location = new Point(45, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(127, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(350, 30);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(27, 42, 74);
            lblEmail.Location = new Point(74, 165);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(127, 110);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(350, 30);
            txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(27, 42, 74);
            lblFullName.Location = new Point(41, 114);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(154, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Register";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblSubtitle;
        private Label lblAppName;
        private Panel panelRight;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblTitle;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private ComboBox cmbRole;
        private Label lblRole;
        private Button btnRegister;
        private Label lblLogin;
    }
}