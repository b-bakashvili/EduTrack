using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Models;

internal class Quiz
{
    public int QuizID { get; set; }
    public string Title { get; set;}
    public string Description { get; set;}
    public string CreatedBy { get; set;}
    public bool IsActive { get; set;}
    public DateTime CreatedAt { get; set;}
}
