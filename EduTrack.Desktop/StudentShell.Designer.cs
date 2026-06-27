namespace EduTrack.Desktop
{
    partial class StudentShell
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
            panelSidebar = new Panel();
            btnMyHistory = new Button();
            btnAvailableQuizzes = new Button();
            btnDashboard = new Button();
            lblUserName = new Label();
            lblAppName = new Label();
            panelDivider = new Panel();
            btnLogout = new Button();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 42, 74);
            panelSidebar.Controls.Add(btnMyHistory);
            panelSidebar.Controls.Add(btnAvailableQuizzes);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(lblUserName);
            panelSidebar.Controls.Add(lblAppName);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 612);
            panelSidebar.TabIndex = 0;
            // 
            // btnMyHistory
            // 
            btnMyHistory.Cursor = Cursors.Hand;
            btnMyHistory.FlatAppearance.BorderSize = 0;
            btnMyHistory.FlatStyle = FlatStyle.Flat;
            btnMyHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyHistory.ForeColor = Color.White;
            btnMyHistory.Location = new Point(0, 190);
            btnMyHistory.Name = "btnMyHistory";
            btnMyHistory.Padding = new Padding(15, 0, 0, 0);
            btnMyHistory.Size = new Size(200, 45);
            btnMyHistory.TabIndex = 5;
            btnMyHistory.Text = "My History";
            btnMyHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnMyHistory.UseVisualStyleBackColor = true;
            btnMyHistory.Click += btnMyHistory_Click;
            // 
            // btnAvailableQuizzes
            // 
            btnAvailableQuizzes.Cursor = Cursors.Hand;
            btnAvailableQuizzes.FlatAppearance.BorderSize = 0;
            btnAvailableQuizzes.FlatStyle = FlatStyle.Flat;
            btnAvailableQuizzes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvailableQuizzes.ForeColor = Color.White;
            btnAvailableQuizzes.Location = new Point(0, 145);
            btnAvailableQuizzes.Name = "btnAvailableQuizzes";
            btnAvailableQuizzes.Padding = new Padding(15, 0, 0, 0);
            btnAvailableQuizzes.Size = new Size(200, 45);
            btnAvailableQuizzes.TabIndex = 4;
            btnAvailableQuizzes.Text = "Available Quizzes";
            btnAvailableQuizzes.TextAlign = ContentAlignment.MiddleLeft;
            btnAvailableQuizzes.UseVisualStyleBackColor = true;
            btnAvailableQuizzes.Click += btnAvailableQuizzes_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.ForeColor = Color.FromArgb(174, 198, 230);
            lblUserName.Location = new Point(20, 55);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(129, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Welcome, Student";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(20, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(135, 38);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "EduTrack";
            // 
            // panelDivider
            // 
            panelDivider.BackColor = Color.FromArgb(58, 123, 213);
            panelDivider.Location = new Point(20, 85);
            panelDivider.Name = "panelDivider";
            panelDivider.Size = new Size(180, 1);
            panelDivider.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(27, 42, 74);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(224, 82, 82);
            btnLogout.Location = new Point(0, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(200, 45);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(244, 246, 251);
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(880, 612);
            panelContent.TabIndex = 3;
            // 
            // StudentShell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 603);
            Controls.Add(panelContent);
            Controls.Add(btnLogout);
            Controls.Add(panelDivider);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentShell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Student Dashboard";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblUserName;
        private Label lblAppName;
        private Panel panelDivider;
        private Button btnDashboard;
        private Button btnMyHistory;
        private Button btnAvailableQuizzes;
        private Button btnLogout;
        private Panel panelContent;
    }
}