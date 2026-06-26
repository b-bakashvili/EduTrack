using Dapper;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Data;

public class QuestionRepository
{
    public List<Question> GetByQuizID(int quizID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"Select * FROM Questions WHERE QuizID = @QuizID ORDER BY OrderNumber";
            return connection.Query<Question>(sql, new { QuizID = quizID }).ToList();
        }
    }

    public int Add(Question question)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"INSERT INTO Questions (QuizID, QuestionText, OrderNumber)
                         VALUES (@QuizID, @QuestionText, @OrderNumber);
                         SELECT SCOPE_IDENTITY();";
            return connection.ExecuteScalar<int>(sql, question);
        }
    }

    public void Update(Question question)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"Update Questions
                           SET QuestionText = @QuestionText, OrderNumber = @OrderNumber
                           WHERE QuestionID = @QuestionID";
            connection.Execute(sql, question);
        }
    }

    public void Delete(int questionID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "DELETE FROM Questions WHERE QuestionID = @QuestionID";
            connection.Execute(sql, new { QuestionID = questionID });
        }
    }

    public List<AnswerOption> GetAnswersByQuestionID(int questionID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "SELECT * FROM AnswerOptions WHERE QuestionID = @QuestionID";
            return connection.Query<AnswerOption>(sql, new { QuestionID = questionID}).ToList();
        }
    }

    public void AddAnswerOption(AnswerOption option)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"INSERT INTO AnswerOptions (QuestionID, OptionText, IsCorrect)
                          VALUES (@QuestionID, @OptionText, @IsCorrect)";
            connection.Execute(sql, option);
        }
    }

    public void DeleteAnswersByQuestionID(int questionID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "DELETE FROM AnswerOptions WHERE QuestionID = @QuestionID";
            connection.Execute(sql, new { QuestionID = questionID });
        }
    }

    public void DeleteByQuizID(int quizID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "DELETE FROM Questions WHERE QuizID = @QuizID";
            connection.Execute(sql, new { QuizID = quizID });
        }
    }
}
