namespace EduTrack.Desktop
{
    partial class QuestionEditorForm
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
            lblQuestion = new Label();
            txtQuestion = new TextBox();
            txtOption1 = new TextBox();
            rbOption1 = new RadioButton();
            txtOption2 = new TextBox();
            rbOption2 = new RadioButton();
            txtOption3 = new TextBox();
            rbOption3 = new RadioButton();
            txtOption4 = new TextBox();
            rbOption4 = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(20, 20);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(106, 20);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question Text";
            // 
            // txtQuestion
            // 
            txtQuestion.BorderStyle = BorderStyle.FixedSingle;
            txtQuestion.Location = new Point(20, 45);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(460, 60);
            txtQuestion.TabIndex = 1;
            // 
            // txtOption1
            // 
            txtOption1.Location = new Point(20, 130);
            txtOption1.Name = "txtOption1";
            txtOption1.Size = new Size(370, 27);
            txtOption1.TabIndex = 2;
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(400, 131);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(78, 24);
            rbOption1.TabIndex = 3;
            rbOption1.TabStop = true;
            rbOption1.Text = "Correct";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // txtOption2
            // 
            txtOption2.Location = new Point(20, 170);
            txtOption2.Name = "txtOption2";
            txtOption2.Size = new Size(370, 27);
            txtOption2.TabIndex = 4;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(400, 170);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(78, 24);
            rbOption2.TabIndex = 5;
            rbOption2.TabStop = true;
            rbOption2.Text = "Correct";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // txtOption3
            // 
            txtOption3.Location = new Point(20, 210);
            txtOption3.Name = "txtOption3";
            txtOption3.Size = new Size(370, 27);
            txtOption3.TabIndex = 6;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(400, 210);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(78, 24);
            rbOption3.TabIndex = 7;
            rbOption3.TabStop = true;
            rbOption3.Text = "Correct";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // txtOption4
            // 
            txtOption4.Location = new Point(20, 250);
            txtOption4.Name = "txtOption4";
            txtOption4.Size = new Size(370, 27);
            txtOption4.TabIndex = 8;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(400, 250);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(78, 24);
            rbOption4.TabIndex = 9;
            rbOption4.TabStop = true;
            rbOption4.Text = "Correct";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(58, 123, 213);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 45);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Question";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(244, 246, 251);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(27, 42, 74);
            btnCancel.Location = new Point(280, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 45);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // QuestionEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(502, 433);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rbOption4);
            Controls.Add(txtOption4);
            Controls.Add(rbOption3);
            Controls.Add(txtOption3);
            Controls.Add(rbOption2);
            Controls.Add(txtOption2);
            Controls.Add(rbOption1);
            Controls.Add(txtOption1);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuestionEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EduTrack - Question Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtQuestion;
        private TextBox txtOption1;
        private RadioButton rbOption1;
        private TextBox txtOption2;
        private RadioButton rbOption2;
        private TextBox txtOption3;
        private RadioButton rbOption3;
        private TextBox txtOption4;
        private RadioButton rbOption4;
        private Button btnSave;
        private Button btnCancel;
    }
}