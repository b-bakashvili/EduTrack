namespace EduTrack.Models;

public class StudentStats
{
    public int StatID { get; set; }
    public int StudentID { get; set; }
    public decimal AverageScore { get; set; }
    public int TotalAttempts { get; set; }
    public string CurrentCategory { get; set; }
    public DateTime LastUpdated { get; set; }
    public string StudentName { get; set; }
}
