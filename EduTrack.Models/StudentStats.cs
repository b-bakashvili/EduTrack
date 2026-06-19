using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Models;

internal class StudentStats
{
    public int StatID { get; set; }
    public int StudentID { get; set; }
    public decimal AverageScore { get; set; }
    public int TotalAttempts { get; set; }
    public string CurrentCategory { get; set; }
    public DateTime LastUpdated { get; set; }
}
