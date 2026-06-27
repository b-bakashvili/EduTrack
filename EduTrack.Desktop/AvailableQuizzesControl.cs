using EduTrack.Core;
using EduTrack.Models;
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
    public partial class AvailableQuizzesControl : UserControl
    {
        private readonly QuizService _quizService;
        private readonly int _studentID;

        public AvailableQuizzesControl(int studentID)
        {
            InitializeComponent();
            _quizService = new QuizService();
            _studentID = studentID;
            LoadQuizzes();
        }

        private void LoadQuizzes()
        {
            List<Quiz> quizzes = _quizService.GetActiveQuizzes();
            dgvQuizzes.DataSource = null;
            dgvQuizzes.DataSource = quizzes;
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            if(dgvQuizzes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to take.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quizID = (int)dgvQuizzes.SelectedRows[0].Cells["QuizID"].Value;
            string quizTitle = dgvQuizzes.SelectedRows[0].Cells["Title"].Value.ToString();

            TakeQuizForm takeQuiz = new TakeQuizForm(quizID, quizTitle, _studentID);
            takeQuiz.ShowDialog();
            LoadQuizzes();
        }
    }
}
