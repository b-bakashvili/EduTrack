using EduTrack.Data;
using EduTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrack.Core;

public class StatsService
{
    private readonly StatsRepository _statsRepository;
    private readonly AttemptRepository _attemptRepository;

    public StatsService()
    {
        _statsRepository = new StatsRepository();
        _attemptRepository = new AttemptRepository();
    }

    public void UpdateStats(int studentID)
    {
        List<QuizAttempt> attempts = _attemptRepository.GetByStudentID(studentID);

        if (attempts.Count == 0) return;

        decimal averageScore = attempts.Average(a => a.Score);
        string category = averageScore >= 75 ? "Strong" :
            averageScore >= 50 ? "Normal" : "Weak";

        StudentStats stats = new StudentStats
        {
            StudentID = studentID,
            AverageScore = Math.Round(averageScore, 2),
            TotalAttempts = attempts.Count,
            CurrentCategory = category,
            LastUpdated = DateTime.Now,
        };

        _statsRepository.Upsert(stats);
    }
}
