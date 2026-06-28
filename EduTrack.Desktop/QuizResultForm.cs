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
    public partial class QuizResultForm : Form
    {
        private readonly QuizAttempt _attempt;
        private readonly List<Question> _questions;
        private readonly Dictionary<int, int> _answers;
        private readonly QuestionService _questionService;

        public QuizResultForm(QuizAttempt attempt, List<Question> questions, Dictionary<int, int> answers)
        {
            InitializeComponent();
            _attempt = attempt;
            _questions = questions;
            _answers = answers;
            _questionService = new QuestionService();
            LoadResults();
        }

        private void LoadResults()
        {
            lblScore.Text = $"Score: {_attempt.Score}%";
            lblCategory.Text = $"Category: {_attempt.Category}";

            if(_attempt.Category == "Strong")
            {
                lblCategory.ForeColor = Color.FromArgb(61, 190, 108);
            }
            else if(_attempt.Category == "Normal")
            {
                lblCategory.ForeColor = Color.FromArgb(244, 168, 42);
            }
            else
            {
                lblCategory.ForeColor = Color.FromArgb(224, 82, 82);
            }

            var resultData = new List<dynamic>();

            foreach(var question in _questions)
            {
                List<AnswerOption> options =
                    _questionService.GetAnswersByQuestionID(question.QuestionID);
                AnswerOption correctOption = options.First(o => o.IsCorrect);

                string selectedText = "Skipped";
                bool isCorrect = false;

                if (_answers.ContainsKey(question.QuestionID))
                {
                    int selectedID = _answers[question.QuestionID];
                    AnswerOption selected = options.First(o => o.OptionID == selectedID);
                    selectedText = selected.OptionText;
                    isCorrect = selected.IsCorrect;
                }

                resultData.Add(new
                {
                    Question = question.QuestionText,
                    YourAnswer = selectedText,
                    CorrectAnswer = correctOption.OptionText,
                    Result = isCorrect ? "Correct" : "Wrong"
                });
            }

            dgvAnswers.DataSource = resultData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
