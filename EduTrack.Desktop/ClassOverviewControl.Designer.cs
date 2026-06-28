namespace EduTrack.Desktop
{
    partial class ClassOverviewControl
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
            btnViewProfile = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            lblTitle.Size = new Size(229, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Class Overview";
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = Color.FromArgb(58, 123, 213);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.FlatStyle = FlatStyle.Flat;
            btnViewProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Location = new Point(660, 20);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(200, 38);
            btnViewProfile.TabIndex = 1;
            btnViewProfile.Text = "View Student Profile";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(20, 70);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(840, 500);
            dgvStudents.TabIndex = 2;
            // 
            // ClassOverviewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 251);
            Controls.Add(dgvStudents);
            Controls.Add(btnViewProfile);
            Controls.Add(lblTitle);
            Name = "ClassOverviewControl";
            Size = new Size(878, 591);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnViewProfile;
        private DataGridView dgvStudents;
    }
}
