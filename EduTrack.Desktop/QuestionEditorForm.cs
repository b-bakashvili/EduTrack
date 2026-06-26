using EduTrack.Core;
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
    public partial class QuestionEditorForm : Form
    {
        private readonly QuestionService _questionService;
        private readonly int _quizID;
        private readonly int _orderNumber;

        public QuestionEditorForm(int quizID, int orderNumber)
        {
            InitializeComponent();
            _questionService = new QuestionService();
            _quizID = quizID;
            _orderNumber = orderNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string questionText = txtQuestion.Text.Trim();
            string option1 = txtOption1.Text.Trim();
            string option2 = txtOption2.Text.Trim();
            string option3 = txtOption3.Text.Trim();
            string option4 = txtOption4.Text.Trim();

            if(string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(option1) ||
               string.IsNullOrEmpty(option2) || string.IsNullOrEmpty(option3) ||
               string.IsNullOrEmpty(option4))
            {
                MessageBox.Show("Please fill in the question and all 4 options.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!rbOption1.Checked && !rbOption2.Checked && !rbOption3.Checked && !rbOption4.Checked)
            {
                MessageBox.Show("Please select the correct answer.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int questionID = _questionService.Add(_quizID, questionText, _orderNumber);

            _questionService.AddAnswerOption(questionID, option1, rbOption1.Checked);
            _questionService.AddAnswerOption(questionID, option2, rbOption2.Checked);
            _questionService.AddAnswerOption(questionID, option3, rbOption3.Checked);
            _questionService.AddAnswerOption(questionID, option4, rbOption4.Checked);

            MessageBox.Show("Question saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
