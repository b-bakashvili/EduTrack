using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Models;

internal class QuizAttempt
{
    public int AttemptID { get; set; }
    public int StudentID { get; set; }
    public int QuizID { get; set; }
    public decimal Score { get; set; }
    public string Category { get; set; }
    public DateTime CompletedAt { get; set; }
}
