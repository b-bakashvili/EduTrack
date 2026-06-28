namespace EduTrack.Desktop
{
    partial class QuizResultForm
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
            lblResult = new Label();
            lblScore = new Label();
            lblCategory = new Label();
            dgvAnswers = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).BeginInit();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(27, 42, 74);
            lblResult.Location = new Point(20, 20);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(266, 46);
            lblResult.TabIndex = 0;
            lblResult.Text = "Quiz Complete!";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.FromArgb(58, 123, 213);
            lblScore.Location = new Point(20, 70);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(45, 31);
            lblScore.TabIndex = 1;
            lblScore.Text = "0%";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(27, 42, 74);
            lblCategory.Location = new Point(20, 110);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(95, 31);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Normal";
            // 
            // dgvAnswers
            // 
            dgvAnswers.AllowUserToAddRows = false;
            dgvAnswers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnswers.BackgroundColor = Color.White;
            dgvAnswers.BorderStyle = BorderStyle.None;
            dgvAnswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnswers.Location = new Point(20, 160);
            dgvAnswers.Name = "dgvAnswers";
            dgvAnswers.ReadOnly = true;
            dgvAnswers.RowHeadersVisible = false;
            dgvAnswers.RowHeadersWidth = 51;
            dgvAnswers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnswers.Size = new Size(540, 250);
            dgvAnswers.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(58, 123, 213);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(420, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 45);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // QuizResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 453);
            Controls.Add(btnClose);
            Controls.Add(dgvAnswers);
            Controls.Add(lblCategory);
            Controls.Add(lblScore);
            Controls.Add(lblResult);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuizResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Quiz Result";
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Label lblScore;
        private Label lblCategory;
        private DataGridView dgvAnswers;
        private Button btnClose;
    }
}