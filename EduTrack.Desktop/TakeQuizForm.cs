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
    public partial class TakeQuizForm : Form
    {
        private readonly QuestionService _questionService;
        private readonly int _quizID;
        private readonly int _studentID;
        private readonly string _quizTitle;
        private List<Question>? _questions;
        private List<AnswerOption>? _currentOptions;
        private Dictionary<int, int> _answers;
        private int _currentIndex = 0;

        public TakeQuizForm(int quizID, string quizTitle, int studentID)
        {
            InitializeComponent();
            _questionService = new QuestionService();
            _quizID = quizID;
            _quizTitle = quizTitle;
            _studentID = studentID;
            _answers = new Dictionary<int, int>();
            LoadQuiz();
        }

        private void LoadQuiz()
        {
            _questions = _questionService.GetByQuizID(_quizID);

            if (_questions.Count == 0)
            {
                MessageBox.Show("This quiz has no questions yet.",
                    "No Questions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lblQuizTitle.Text = _quizTitle;
            progressBar.Maximum = _questions.Count;
            ShowQuestion(_currentIndex);
        }

        private void ShowQuestion(int index)
        {
            Question question = _questions[index];
            _currentOptions = _questionService.GetAnswersByQuestionID(question.QuestionID);

            lblProgress.Text = $"Question {index + 1} of {_questions.Count}";
            progressBar.Value = index + 1;
            lblQuestion.Text = question.QuestionText;

            rbOption1.Text = _currentOptions[0].OptionText;
            rbOption2.Text = _currentOptions[1].OptionText;
            rbOption3.Text = _currentOptions[2].OptionText;
            rbOption4.Text = _currentOptions[3].OptionText;

            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;

            btnNext.Text = index == _questions.Count - 1 ? "Submit" : "Next";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!rbOption1.Checked && !rbOption2.Checked &&
               !rbOption3.Checked && !rbOption4.Checked)
            {
                MessageBox.Show("Please select an answer before continuing.",
                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedOptionID = 0;
            if (rbOption1.Checked) selectedOptionID = _currentOptions[0].OptionID;
            if (rbOption2.Checked) selectedOptionID = _currentOptions[1].OptionID;
            if (rbOption3.Checked) selectedOptionID = _currentOptions[2].OptionID;
            if (rbOption4.Checked) selectedOptionID = _currentOptions[3].OptionID;

            _answers[_questions[_currentIndex].QuestionID] = selectedOptionID;

            if(_currentIndex < _questions.Count - 1)
            {
                _currentIndex++;
                ShowQuestion(_currentIndex);
            }
            else
            {
                SubmitQuiz();
            }
        }

        private void SubmitQuiz()
        {
            GradingService gradingService = new GradingService();
            StatsService statsService = new StatsService();

            QuizAttempt attempt = gradingService.GradeQuiz(_studentID, _quizID, _questions, _answers);
            statsService.UpdateStats(_studentID);

            QuizResultForm resultForm = new QuizResultForm(attempt, _questions, _answers);
            resultForm.ShowDialog();
            this.Close();
        }
    }
}