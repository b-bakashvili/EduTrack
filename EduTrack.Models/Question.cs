using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Models;

internal class Question
{
    public int QuestionID { get; set; }
    public int QuizID { get; set; }
    public string QuestionText { get; set; }
    public int OrderNumber { get; set; }
}
