using EduTrack.Data;
using EduTrack.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Core;

public class QuizService
{
    private readonly QuizRepository _quizRepository;
    private readonly QuestionRepository _questionRepository;

    public QuizService()
    {
        _quizRepository = new QuizRepository();
        _questionRepository = new QuestionRepository();
    }

    public List<Quiz> GetAll()
    {
        return _quizRepository.GetAll();
    }

    public Quiz GetByID(int quizID)
    {
        return _quizRepository.GetByID(quizID);
    }

    public int Add(string title, string description, int createdBy)
    {
        Quiz quiz = new Quiz
        {
            Title = title,
            Description = description,
            CreatedBy = createdBy,
            IsActive = true
        };
        return _quizRepository.Add(quiz);
    }

    public void Update(int quizID, string title, string description, bool IsActive)
    {
        Quiz quiz = new Quiz
        {
            QuizID = quizID,
            Title = title,
            Description = description,
            IsActive = IsActive
        };
        _quizRepository.Update(quiz);
    }

    public void Delete(int quizID)
    {
        _quizRepository.DeleteCascade(quizID);
    }

    public List<Quiz> GetActiveQuizzes()
    {
        return _quizRepository.GetActiveQuizzes();
    }

    public int GetQuestionCount(int quizID)
    {
        return _questionRepository.GetByQuizID(quizID).Count;
    }
}
