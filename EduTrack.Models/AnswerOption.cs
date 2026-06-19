using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Models;

internal class AnswerOption
{
    public int OptionID { get; set; }
    public int QuestionID { get; set; }
    public string OptionText { get; set; }
    public bool IsCorrect {  get; set; }
}
