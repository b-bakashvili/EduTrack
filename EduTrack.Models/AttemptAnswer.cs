using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Models;

internal class AttemptAnswer
{
    public int AnswerID { get; set; }
    public int AttemptID { get; set; }
    public int QuestionID { get; set; }
    public int? SelectedOptionID { get; set; }
}
