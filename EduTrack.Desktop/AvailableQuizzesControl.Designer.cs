namespace EduTrack.Desktop
{
    partial class AvailableQuizzesControl
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
            btnTakeQuiz = new Button();
            dgvQuizzes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Available Quizzes";
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.BackColor = Color.FromArgb(58, 123, 213);
            btnTakeQuiz.Cursor = Cursors.Hand;
            btnTakeQuiz.FlatAppearance.BorderSize = 0;
            btnTakeQuiz.FlatStyle = FlatStyle.Flat;
            btnTakeQuiz.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTakeQuiz.ForeColor = Color.White;
            btnTakeQuiz.Location = new Point(720, 20);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Size = new Size(120, 38);
            btnTakeQuiz.TabIndex = 1;
            btnTakeQuiz.Text = "Take Quiz";
            btnTakeQuiz.UseVisualStyleBackColor = false;
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // dgvQuizzes
            // 
            dgvQuizzes.AllowUserToAddRows = false;
            dgvQuizzes.AllowUserToDeleteRows = false;
            dgvQuizzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuizzes.BackgroundColor = Color.White;
            dgvQuizzes.BorderStyle = BorderStyle.None;
            dgvQuizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuizzes.Location = new Point(20, 70);
            dgvQuizzes.Name = "dgvQuizzes";
            dgvQuizzes.ReadOnly = true;
            dgvQuizzes.RowHeadersVisible = false;
            dgvQuizzes.RowHeadersWidth = 51;
            dgvQuizzes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuizzes.Size = new Size(840, 500);
            dgvQuizzes.TabIndex = 2;
            // 
            // AvailableQuizzesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 251);
            Controls.Add(dgvQuizzes);
            Controls.Add(btnTakeQuiz);
            Controls.Add(lblTitle);
            Name = "AvailableQuizzesControl";
            Size = new Size(890, 593);
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnTakeQuiz;
        private DataGridView dgvQuizzes;
    }
}
