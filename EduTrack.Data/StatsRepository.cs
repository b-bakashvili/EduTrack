using Dapper;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Data;

public class StatsRepository
{
    public void Upsert(StudentStats stats)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"IF EXISTS (SELECT 1 FROM StudentStats WHERE StudentID = @StudentID)
                           UPDATE StudentStats
                           SET AverageScore = @AverageScore,
                               TotalAttempts = @TotalAttempts,
                               CurrentCategory = @CurrentCategory,
                               LastUpdated = @LastUpdated
                           WHERE StudentID = @StudentID
                           ELSE
                           INSERT INTO StudentStats
                           (StudentID, AverageScore, TotalAttempts, CurrentCategory, LastUpdated)
                           VALUES (@StudentID, @AverageScore, @TotalAttempts, @CurrentCategory, @LastUpdated)";
            connection.Execute(sql, stats);
        }
    }

    public StudentStats GetByStudentID(int studentID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "SELECT * FROM StudentStats WHERE StudentID = @StudentID";
            return connection.QueryFirstOrDefault<StudentStats>(sql, new { StudentID = studentID });
        }
    }

    public List<StudentStats> GetAll()
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"SELECT ss.*, u.FullName as StudentName
                           FROM StudentStats ss
                           JOIN Users u ON ss.StudentID = u.UserID";
            return connection.Query<StudentStats>(sql).ToList();
        }
    }
}
