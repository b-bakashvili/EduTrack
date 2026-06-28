namespace EduTrack.Models;

public class QuizAttempt
{
    public int AttemptID { get; set; }
    public int StudentID { get; set; }
    public int QuizID { get; set; }
    public decimal Score { get; set; }
    public string Category { get; set; }
    public DateTime CompletedAt { get; set; }
    public string QuizTitle { get; set; }
    public string StudentName { get; set;}
}
