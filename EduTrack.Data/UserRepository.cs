using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EduTrack.Models;

namespace EduTrack.Data;

public class UserRepository
{
    public void Register(User user)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"INSERT INTO Users (FullName, Email, Password, Role)
                           VALUES (@FullName, @Email, @Password, @Role)";
            connection.Execute(sql, user);
        }
    }

    public User Login(string email, string password)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = @"SELECT * FROM Users
                           WHERE Email = @Email AND Password = @Password";

            return connection.QueryFirstOrDefault<User>(sql,
                new { Email = email, Password = password });
        }
    }

    public User GetByID(int userID)
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "SELECT * FROM Users WHERE UserID = @UserID";

            return connection.QueryFirstOrDefault<User>(sql,
                new { UserID = userID });
        }
    }

    public List<User> GetAllStudents()
    {
        using (var connection = DbConnection.GetConnection())
        {
            string sql = "SELECT * FROM Users WHERE Role = 'Student'";

            return connection.Query<User>(sql).ToList();
        }
    }
}
