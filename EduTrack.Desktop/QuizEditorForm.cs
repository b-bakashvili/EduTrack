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
    public partial class QuizEditorForm : Form
    {
        private readonly QuizService _quizService;
        private readonly int _teacherID;
        private readonly int _quizID;
        private readonly bool _isEditMode;

        public QuizEditorForm(int teacherID)
        {
            InitializeComponent();
            _quizService = new QuizService();
            _teacherID = teacherID;
            _isEditMode = false;
        }

        public QuizEditorForm(int teacherID, int quizID)
        {
            InitializeComponent();
            _quizService = new QuizService();
            _teacherID = teacherID;
            _quizID = quizID;
            _isEditMode = true;
            LoadQuizData();
        }

        private void LoadQuizData()
        {
            Quiz quiz = _quizService.GetByID(_quizID);
            txtTitle.Text = quiz.Title;
            txtDescription.Text = quiz.Description;
            this.Text = "EduTrack - Edit Quiz";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a quiz title.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isEditMode)
            {
                _quizService.Update(_quizID, title, description, true);
                MessageBox.Show("Quiz updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _quizService.Add(title, description, _teacherID);
                MessageBox.Show("Quiz created successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
