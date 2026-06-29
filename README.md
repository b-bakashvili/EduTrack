# EduTrack - Student Progress Tracking Platform

## About
A desktop application built with C# WinForms and MSSQL for tracking
student performance across general knowledge quizzes over time.
Teachers create quizzes, students take them, and the system automatically
tracks each student's score progression with graphs

## Texh Stack
- C# / .NET 8 - WinForms
- Microsoft SQL Server (MSSQL)
- Dapper Nuget Package
- Github

## Features
- Role-based registration and login (Teacher / Student)
- Teacher quiz and question management
- Multiple choice quiz engine (4 options, 1 correct)
- Auto-grading with Weak / Normal / Strong categorization
- Running average score updated after every attempt
- Line graph showing student score progression over time
- Class overview dashboard for teachers
- Personal stats and history for students

## Setup
- Clone repo
- Run SQL scripts in /Database/ on your local MSSQL instance
- Set your connection string in EduTrack.Data/DbConnection.cs
- Build and run in Visual Studio 2022

  ## Database
  - Users
  - Quizzes
  - Questions
  - AnswerOptions
  - QuizAttempts
  - AttemptAnswers
  - StudentStats
