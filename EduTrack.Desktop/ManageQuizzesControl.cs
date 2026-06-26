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
    public partial class ManageQuizzesControl : UserControl
    {
        private readonly QuizService _quizService;
        private readonly int _teacherID;

        public ManageQuizzesControl(int teacherID)
        {
            InitializeComponent();
            _quizService = new QuizService();
            _teacherID = teacherID;
            LoadQuizzes();
        }

        private void LoadQuizzes()
        {
            List<Quiz> quizzes = _quizService.GetAll();
            dgvQuizzes.DataSource = null;
            dgvQuizzes.DataSource = quizzes;
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            QuizEditorForm editor = new QuizEditorForm(_teacherID);
            editor.ShowDialog();
            LoadQuizzes();
        }

        private void btnEditQuiz_Click(object sender, EventArgs e)
        {
            if(dgvQuizzes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to edit.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quizID = (int)dgvQuizzes.SelectedRows[0].Cells["QuizID"].Value;
            QuizEditorForm editor = new QuizEditorForm(_teacherID, quizID);
            editor.ShowDialog();
            LoadQuizzes();
        }

        private void btnDeleteQuiz_Click(object sender, EventArgs e)
        {
            if(dgvQuizzes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to delete.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this quiz?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int quizID = (int)dgvQuizzes.SelectedRows[0].Cells["QuizID"].Value;
                    _quizService.Delete(quizID);
                    LoadQuizzes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //if(result == DialogResult.Yes)
            //{
            //    int quizID = (int)dgvQuizzes.SelectedRows[0].Cells["QuizID"].Value;
            //    LoadQuizzes();
            //}
        }
    }
}
