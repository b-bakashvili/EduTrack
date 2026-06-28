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
    public partial class MyHistoryControl : UserControl
    {
        private readonly AttemptRepository _attemptRepository;
        private readonly int _studentID;
        public MyHistoryControl(int studentID)
        {
            InitializeComponent();
            _attemptRepository = new AttemptRepository();
            _studentID = studentID;
            LoadHistory();
        }

        private void LoadHistory()
        {
            var attempts = _attemptRepository.GetByStudentID(_studentID);
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = attempts;
        }
    }
}
