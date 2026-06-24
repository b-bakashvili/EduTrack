using Dapper;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Data;

public class QuizRepository
{
    public List<Quiz> GetAll()
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "SELECT * FROM Quizzes";
            return connection.Query<Quiz>(sql).ToList();
        }
    }

    public Quiz GetByID(int quizID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"Select * FROM Quizzes WHERE QuizID = @QuizID";
            return connection.QueryFirstOrDefault<Quiz>(sql, new { QuizID = quizID });
        }
    }

    public int Add(Quiz quiz)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"INSERT INTO Quizzes (Title, Description, CreatedBy, IsActive)
                         VALUES (@Title, @Description, @CreatedBy, @IsActive);
                         SELECT SCOPE_IDENTITY();";
            return connection.ExecuteScalar<int>(sql, quiz);
        }
    }

    public void Update(Quiz quiz)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"Update Quizzes
                           SET Title = @Title, Description = @Description,
                           IsActive = @IsActive
                           WHERE QuizID = @QuizID";
            connection.Execute(sql, quiz);
        }
    }

    public void Delete(int quizID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "DELETE FROM Quizzes WHERE QuizID = @QuizID";
            connection.Execute(sql, new { QuizID = quizID });
        }
    }

    public List<Quiz> GetActiveQuizzes()
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "SELECT * FROM Quizzes WHERE IsActive = 1";
            return connection.Query<Quiz>(sql).ToList();
        }
    }
}
