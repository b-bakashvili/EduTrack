namespace EduTrack.Desktop
{
    partial class StudentDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblAverageScore = new Label();
            lblCategory = new Label();
            lblTotalAttempts = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Dashboard";
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.BackColor = Color.Transparent;
            lblAverageScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageScore.ForeColor = Color.FromArgb(58, 123, 213);
            lblAverageScore.Location = new Point(20, 70);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(186, 31);
            lblAverageScore.TabIndex = 1;
            lblAverageScore.Text = "Average Score: - ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(27, 42, 74);
            lblCategory.Location = new Point(20, 110);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(138, 31);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category: - ";
            // 
            // lblTotalAttempts
            // 
            lblTotalAttempts.AutoSize = true;
            lblTotalAttempts.BackColor = Color.Transparent;
            lblTotalAttempts.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAttempts.ForeColor = Color.FromArgb(27, 42, 74);
            lblTotalAttempts.Location = new Point(20, 150);
            lblTotalAttempts.Name = "lblTotalAttempts";
            lblTotalAttempts.Size = new Size(185, 25);
            lblTotalAttempts.TabIndex = 3;
            lblTotalAttempts.Text = "Total Quizzes Taken: - ";
            // 
            // StudentDashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 251);
            Controls.Add(lblTotalAttempts);
            Controls.Add(lblCategory);
            Controls.Add(lblAverageScore);
            Controls.Add(lblTitle);
            Name = "StudentDashboardControl";
            Size = new Size(776, 546);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAverageScore;
        private Label lblCategory;
        private Label lblTotalAttempts;
    }
}
