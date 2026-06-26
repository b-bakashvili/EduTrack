using Microsoft.Data.SqlClient;

namespace EduTrack.Data;

public class DbConnection
{
    private static string _connectionString = 
        "Server=.\\SQLEXPRESS;Database=EduTrack;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=60;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
