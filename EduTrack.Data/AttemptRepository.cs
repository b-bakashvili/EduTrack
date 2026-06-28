using Dapper;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Data;

public class AttemptRepository
{
    public int SaveAttempt(QuizAttempt attempt)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"INSERT INTO QuizAttempts
                          (StudentID, QuizID, Score, Category, CompletedAt)
                          VALUES (@StudentID, @QuizID, @Score, @Category, @CompletedAt);
                          SELECT SCOPE_IDENTITY();";
            return connection.ExecuteScalar<int>(sql, attempt);
        }
    }

    public void SaveAnswer(AttemptAnswer answer)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"INSERT INTO AttemptAnswers
                          (AttemptID, QuestionID, SelectedOptionID)
                          VALUES (@AttemptID, @QuestionID, @SelectedOptionID)";
            connection.Execute(sql, new
            {
                answer.AttemptID,
                answer.QuestionID,
                answer.SelectedOptionID
            });
        }
    }

    public List<QuizAttempt> GetByStudentID(int studentID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"SELECT qa.*, q.Title as QuizTitle
                          FROM QuizAttempts qa
                          JOIN Quizzes q ON qa.QuizID = q.QuizID
                          WHERE qa.StudentID = @StudentID
                          ORDER BY qa.CompletedAt DESC";
            return connection.Query<QuizAttempt>(sql, new { StudentID = studentID }).ToList();
        }
    }

    public List<QuizAttempt> GetAllAttempts()
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"SELECT qa.*, q.Title as QuizTitle, u.FullName as StudentName
                          FROM QuizAttempts qa
                          JOIN Quizzes q ON qa.QuizID = q.QuizID
                          JOIN Users u ON qa.StudentID = u.UsedID
                          ORDER BY qa.CompletedAt DESC";
            return connection.Query<QuizAttempt>(sql).ToList();
        }
    }
}
