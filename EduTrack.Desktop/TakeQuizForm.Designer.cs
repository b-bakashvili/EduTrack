namespace EduTrack.Desktop
{
    partial class TakeQuizForm
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
            lblQuizTitle = new Label();
            lblProgress = new Label();
            progressBar = new ProgressBar();
            lblQuestion = new Label();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblQuizTitle
            // 
            lblQuizTitle.AutoSize = true;
            lblQuizTitle.BackColor = Color.Transparent;
            lblQuizTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblQuizTitle.Location = new Point(20, 20);
            lblQuizTitle.Name = "lblQuizTitle";
            lblQuizTitle.Size = new Size(117, 31);
            lblQuizTitle.TabIndex = 0;
            lblQuizTitle.Text = "Quiz Title";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.ForeColor = Color.FromArgb(174, 198, 230);
            lblProgress.Location = new Point(20, 55);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(118, 20);
            lblProgress.TabIndex = 1;
            lblProgress.Text = "Question 1 of 10";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 75);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(540, 10);
            progressBar.TabIndex = 2;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.FromArgb(27, 42, 74);
            lblQuestion.Location = new Point(20, 100);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(540, 60);
            lblQuestion.TabIndex = 3;
            lblQuestion.Text = "Question text here";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.BackColor = Color.Transparent;
            rbOption1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption1.ForeColor = Color.FromArgb(27, 42, 74);
            rbOption1.Location = new Point(20, 180);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(98, 27);
            rbOption1.TabIndex = 4;
            rbOption1.TabStop = true;
            rbOption1.Text = "Option 1";
            rbOption1.UseVisualStyleBackColor = false;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.BackColor = Color.Transparent;
            rbOption2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption2.ForeColor = Color.FromArgb(27, 42, 74);
            rbOption2.Location = new Point(20, 220);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(98, 27);
            rbOption2.TabIndex = 5;
            rbOption2.TabStop = true;
            rbOption2.Text = "Option 2";
            rbOption2.UseVisualStyleBackColor = false;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.BackColor = Color.Transparent;
            rbOption3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption3.ForeColor = Color.FromArgb(27, 42, 74);
            rbOption3.Location = new Point(20, 260);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(98, 27);
            rbOption3.TabIndex = 6;
            rbOption3.TabStop = true;
            rbOption3.Text = "Option 3";
            rbOption3.UseVisualStyleBackColor = false;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.BackColor = Color.Transparent;
            rbOption4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption4.ForeColor = Color.FromArgb(27, 42, 74);
            rbOption4.Location = new Point(20, 300);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(98, 27);
            rbOption4.TabIndex = 7;
            rbOption4.TabStop = true;
            rbOption4.Text = "Option 4";
            rbOption4.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(58, 123, 213);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(410, 380);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 45);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // TakeQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 453);
            Controls.Add(btnNext);
            Controls.Add(rbOption4);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Controls.Add(lblQuestion);
            Controls.Add(progressBar);
            Controls.Add(lblProgress);
            Controls.Add(lblQuizTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TakeQuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Take Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuizTitle;
        private Label lblProgress;
        private ProgressBar progressBar;
        private Label lblQuestion;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private RadioButton rbOption4;
        private Button btnNext;
    }
}