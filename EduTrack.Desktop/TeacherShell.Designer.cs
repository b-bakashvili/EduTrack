namespace EduTrack.Desktop
{
    partial class TeacherShell
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
            btnLogout = new Button();
            btnClassOverview = new Button();
            btnManageQuizzes = new Button();
            btnDashboard = new Button();
            lblUserName = new Label();
            lblAppName = new Label();
            panelDivider = new Panel();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 42, 74);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnClassOverview);
            panelSidebar.Controls.Add(btnManageQuizzes);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(lblUserName);
            panelSidebar.Controls.Add(lblAppName);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 612);
            panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(224, 82, 82);
            btnLogout.Location = new Point(0, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(200, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClassOverview
            // 
            btnClassOverview.Cursor = Cursors.Hand;
            btnClassOverview.FlatAppearance.BorderSize = 0;
            btnClassOverview.FlatStyle = FlatStyle.Flat;
            btnClassOverview.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClassOverview.ForeColor = Color.White;
            btnClassOverview.Location = new Point(0, 190);
            btnClassOverview.Name = "btnClassOverview";
            btnClassOverview.Padding = new Padding(15, 0, 0, 0);
            btnClassOverview.Size = new Size(200, 45);
            btnClassOverview.TabIndex = 4;
            btnClassOverview.Text = "Class Overview";
            btnClassOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnClassOverview.UseVisualStyleBackColor = true;
            btnClassOverview.Click += btnClassOverview_Click;
            // 
            // btnManageQuizzes
            // 
            btnManageQuizzes.Cursor = Cursors.Hand;
            btnManageQuizzes.FlatAppearance.BorderSize = 0;
            btnManageQuizzes.FlatStyle = FlatStyle.Flat;
            btnManageQuizzes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageQuizzes.ForeColor = Color.White;
            btnManageQuizzes.Location = new Point(0, 145);
            btnManageQuizzes.Name = "btnManageQuizzes";
            btnManageQuizzes.Padding = new Padding(15, 0, 0, 0);
            btnManageQuizzes.Size = new Size(200, 45);
            btnManageQuizzes.TabIndex = 3;
            btnManageQuizzes.Text = "Manage Quizzes";
            btnManageQuizzes.TextAlign = ContentAlignment.MiddleLeft;
            btnManageQuizzes.UseVisualStyleBackColor = true;
            btnManageQuizzes.Click += btnManageQuizzes_Click;
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
            btnDashboard.TabIndex = 2;
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
            lblUserName.Location = new Point(37, 55);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(129, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Welcome, Teacher";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(37, 17);
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
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(244, 246, 251);
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(880, 612);
            panelContent.TabIndex = 2;
            // 
            // TeacherShell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 603);
            Controls.Add(panelContent);
            Controls.Add(panelDivider);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TeacherShell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Teacher Dashboard";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblAppName;
        private Label lblUserName;
        private Button btnDashboard;
        private Panel panelDivider;
        private Button btnLogout;
        private Button btnClassOverview;
        private Button btnManageQuizzes;
        private Panel panelContent;
    }
}