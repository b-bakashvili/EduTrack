using EduTrack.Data;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Core;

public class QuestionService
{
    private readonly QuestionRepository _questionRepository;

    public QuestionService()
    {
        _questionRepository = new QuestionRepository();
    }

    public List<Question> GetByQuizID(int quizID)
    {
        return _questionRepository.GetByQuizID(quizID);
    }

    public int Add(int quizID, string questionText, int orderNumber)
    {
        Question question = new Question
        {
            QuizID = quizID,
            QuestionText = questionText,
            OrderNumber = orderNumber
        };
        return _questionRepository.Add(question);
    }

    public void AddAnswerOption(int QuestionID, string optionText, bool isCorrect)
    {
        AnswerOption option = new AnswerOption
        {
            QuestionID = QuestionID,
            OptionText = optionText,
            IsCorrect = isCorrect
        };
        _questionRepository.AddAnswerOption(option);
    }

    public List<AnswerOption> GetAnswerByQuestionID(int questionID)
    {
        return _questionRepository.GetAnswersByQuestionID(questionID);
    }

    public void Delete(int questionID)
    {
        _questionRepository.DeleteAnswersByQuestionID(questionID);
        _questionRepository.Delete(questionID);
    }

    public void Update(int questionID, string questionText, int orderNumber, List<AnswerOption> options)
    {
        Question question = new Question
        {
            QuestionID = questionID,
            QuestionText = questionText,
            OrderNumber = orderNumber,
        };
        _questionRepository.Update(question);
        _questionRepository.DeleteAnswersByQuestionID(questionID);
        foreach(var option in options)
        {
            _questionRepository.AddAnswerOption(option);
        }
    }
    
}
