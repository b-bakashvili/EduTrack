namespace EduTrack.Models;

public class AttemptAnswer
{
    public int AnswerID { get; set; }
    public int AttemptID { get; set; }
    public int QuestionID { get; set; }
    public int? SelectedOptionID { get; set; }
}
