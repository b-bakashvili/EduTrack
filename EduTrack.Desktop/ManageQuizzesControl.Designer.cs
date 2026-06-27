namespace EduTrack.Desktop
{
    partial class ManageQuizzesControl
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
            btnAddQuiz = new Button();
            dgvQuizzes = new DataGridView();
            btnEditQuiz = new Button();
            btnDeleteQuiz = new Button();
            btnManageQuestions = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(11, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ManageQuizzes";
            // 
            // btnAddQuiz
            // 
            btnAddQuiz.BackColor = Color.FromArgb(58, 123, 213);
            btnAddQuiz.Cursor = Cursors.Hand;
            btnAddQuiz.FlatAppearance.BorderSize = 0;
            btnAddQuiz.FlatStyle = FlatStyle.Flat;
            btnAddQuiz.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddQuiz.ForeColor = Color.White;
            btnAddQuiz.Location = new Point(720, 20);
            btnAddQuiz.Name = "btnAddQuiz";
            btnAddQuiz.Size = new Size(120, 38);
            btnAddQuiz.TabIndex = 1;
            btnAddQuiz.Text = "+ New Quiz";
            btnAddQuiz.UseVisualStyleBackColor = false;
            btnAddQuiz.Click += btnAddQuiz_Click;
            // 
            // dgvQuizzes
            // 
            dgvQuizzes.AllowUserToAddRows = false;
            dgvQuizzes.AllowUserToDeleteRows = false;
            dgvQuizzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuizzes.Location = new Point(20, 78);
            dgvQuizzes.Name = "dgvQuizzes";
            dgvQuizzes.ReadOnly = true;
            dgvQuizzes.RowHeadersVisible = false;
            dgvQuizzes.RowHeadersWidth = 51;
            dgvQuizzes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuizzes.Size = new Size(820, 500);
            dgvQuizzes.TabIndex = 2;
            // 
            // btnEditQuiz
            // 
            btnEditQuiz.BackColor = Color.FromArgb(27, 42, 74);
            btnEditQuiz.Cursor = Cursors.Hand;
            btnEditQuiz.FlatAppearance.BorderSize = 0;
            btnEditQuiz.FlatStyle = FlatStyle.Flat;
            btnEditQuiz.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditQuiz.ForeColor = Color.White;
            btnEditQuiz.Location = new Point(580, 20);
            btnEditQuiz.Name = "btnEditQuiz";
            btnEditQuiz.Size = new Size(120, 38);
            btnEditQuiz.TabIndex = 3;
            btnEditQuiz.Text = "Edit Quiz";
            btnEditQuiz.UseVisualStyleBackColor = false;
            btnEditQuiz.Click += btnEditQuiz_Click;
            // 
            // btnDeleteQuiz
            // 
            btnDeleteQuiz.BackColor = Color.FromArgb(224, 82, 82);
            btnDeleteQuiz.Cursor = Cursors.Hand;
            btnDeleteQuiz.FlatAppearance.BorderSize = 0;
            btnDeleteQuiz.FlatStyle = FlatStyle.Flat;
            btnDeleteQuiz.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteQuiz.ForeColor = Color.White;
            btnDeleteQuiz.Location = new Point(441, 20);
            btnDeleteQuiz.Name = "btnDeleteQuiz";
            btnDeleteQuiz.Size = new Size(120, 38);
            btnDeleteQuiz.TabIndex = 4;
            btnDeleteQuiz.Text = "Delete Quiz";
            btnDeleteQuiz.UseVisualStyleBackColor = false;
            btnDeleteQuiz.Click += btnDeleteQuiz_Click;
            // 
            // btnManageQuestions
            // 
            btnManageQuestions.BackColor = Color.FromArgb(58, 123, 213);
            btnManageQuestions.Cursor = Cursors.Hand;
            btnManageQuestions.FlatAppearance.BorderSize = 0;
            btnManageQuestions.FlatStyle = FlatStyle.Flat;
            btnManageQuestions.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageQuestions.ForeColor = Color.White;
            btnManageQuestions.Location = new Point(256, 20);
            btnManageQuestions.Name = "btnManageQuestions";
            btnManageQuestions.Size = new Size(170, 38);
            btnManageQuestions.TabIndex = 5;
            btnManageQuestions.Text = "Manage Questions";
            btnManageQuestions.UseVisualStyleBackColor = false;
            btnManageQuestions.Click += btnManageQuestions_Click;
            // 
            // ManageQuizzesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnManageQuestions);
            Controls.Add(btnDeleteQuiz);
            Controls.Add(btnEditQuiz);
            Controls.Add(dgvQuizzes);
            Controls.Add(btnAddQuiz);
            Controls.Add(lblTitle);
            Name = "ManageQuizzesControl";
            Size = new Size(861, 625);
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddQuiz;
        private DataGridView dgvQuizzes;
        private Button btnEditQuiz;
        private Button btnDeleteQuiz;
        private Button btnManageQuestions;
    }
}
