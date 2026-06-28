using EduTrack.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduTrack.Desktop
{
    public partial class ClassOverviewControl : UserControl
    {
        private readonly StatsRepository _statsRepository;
        public ClassOverviewControl()
        {
            InitializeComponent();
            _statsRepository = new StatsRepository();
            LoadStudents();
        }

        private void LoadStudents()
        {
            var stats = _statsRepository.GetAll();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = stats;
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if(dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to view.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentID = (int)dgvStudents.SelectedRows[0].Cells["StudentID"].Value;
            string studentName = dgvStudents.SelectedRows[0].Cells["StudentName"].Value.ToString();

            StudentProfileForm profileForm = new StudentProfileForm(studentID, studentName);
            profileForm.ShowDialog();
        }
    }
}
