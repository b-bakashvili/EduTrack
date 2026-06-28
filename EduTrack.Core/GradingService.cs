using EduTrack.Data;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Core;

public class GradingService
{
    private readonly AttemptRepository _attemptRepository;
    private readonly QuestionService _questionService;

    public GradingService()
    {
        _attemptRepository = new AttemptRepository();
        _questionService = new QuestionService();
    }

    public QuizAttempt GradeQuiz(int studentID, int quizID,
        List<Question> questions, Dictionary<int, int> answers)
    {
        int correct = 0;

        foreach (var question in questions)
        {
            List<AnswerOption> options =
                _questionService.GetAnswersByQuestionID(question.QuestionID);
            AnswerOption correctOption = options.First(o => o.IsCorrect);

            if(answers.ContainsKey(question.QuestionID) &&
                answers[question.QuestionID] == correctOption.OptionID)
            {
                correct++;
            }
        }

        decimal score = (decimal)correct / questions.Count * 100;
        string category = score >= 75 ? "Strong" : score >= 50 ? "Normal" : "Weak";

        QuizAttempt attempt = new QuizAttempt
        {
            StudentID = studentID,
            QuizID = quizID,
            Score = Math.Round(score, 2),
            Category = category,
            CompletedAt = DateTime.Now
        };

        int AttemptID = _attemptRepository.SaveAttempt(attempt);
        attempt.AttemptID = AttemptID;

        foreach(var question in questions)
        {
            AttemptAnswer answer = new AttemptAnswer
            {
                AttemptID = AttemptID,
                QuestionID = question.QuestionID,
                SelectedOptionID = answers.ContainsKey(question.QuestionID)
                    ? answers[question.QuestionID] : null
            };
            _attemptRepository.SaveAnswer(answer);
        }

        return attempt;
    }
}
