namespace EduTrack.Desktop
{
    partial class StudentProfileForm
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
            lblStudentName = new Label();
            lblStats = new Label();
            SuspendLayout();

            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProgress.Location = new System.Drawing.Point(20, 90);
            this.chartProgress.Name = "chartProgress";
            this.chartProgress.Size = new System.Drawing.Size(640, 380);
            this.chartProgress.TabIndex = 0;
            this.Controls.Add(this.chartProgress);

            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.FromArgb(27, 42, 74);
            lblStudentName.Location = new Point(20, 20);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(206, 38);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name";
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.BackColor = Color.Transparent;
            lblStats.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStats.ForeColor = Color.FromArgb(58, 123, 213);
            lblStats.Location = new Point(20, 55);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(287, 23);
            lblStats.TabIndex = 1;
            lblStats.Text = "Average: - | Category: - | Attempts: -";
            // 
            // StudentProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 503);
            Controls.Add(lblStats);
            Controls.Add(lblStudentName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Student Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Label lblStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
    }
}

