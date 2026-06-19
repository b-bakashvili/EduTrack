-- Create database only if it doesn't exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'EduTrack')
BEGIN
	CREATE DATABASE EduTrack;
END
GO

USE EduTrack;
GO

-- Users (teachers and students)
-- Role column determines acces level
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Users' AND xType = 'U')
BEGIN
CREATE TABLE Users
(
	UserID INT PRIMARY KEY IDENTITY(1,1),
	FullName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	_Password NVARCHAR(256) NOT NULL,
	_Role NVARCHAR(20) NOT NULL,
	CreatedAt DateTime DEFAULT GETDATE()
);
END
GO

-- Quizzes
--IsActive controls visibility to students
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Quizzes' AND xType = 'U')
BEGIN
CREATE TABLE Quizzes
(
	QuizID INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(100) NOT NULL,
	_Description NVARCHAR(500),
	CreatedBy INT NOT NULL REFERENCES Users(UserID),
	IsActive BIT DEFAULT 1,
	CreatedAt DateTime DEFAULT GETDATE()
);
END
GO

--Questions
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Questions' AND xType = 'U')
BEGIN
CREATE TABLE Questions
(
	QuestionID INT PRIMARY KEY IDENTITY(1,1),
	QuizID INT NOT NULL REFERENCES Quizzes(QuizID),
	QuestionText NVARCHAR(500) NOT NULL,
	OrderNumber INT NOT NULL
);
END
GO

--Answer Options (4 per question, 1 correct)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'AnswerOptions' AND xType = 'U')
BEGIN
CREATE TABLE AnswerOptions
(
	OptionID INT PRIMARY KEY IDENTITY(1,1),
	QuestionID INT NOT NULL REFERENCES Questions(QuestionID),
	OptionText NVARCHAR(300) NOT NULL,
	IsCorrect BIT NOT NULL DEFAULT 0
);
END
GO

--Quiz Attempts (Many-to-Many relationship between Students and Quizzes)
--Score is stored as percentage, Category is calculated by GradingService
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'QuizAttempts' AND xType = 'U')
BEGIN
CREATE TABLE QuizAttempts
(
	AttemptID INT PRIMARY KEY IDENTITY(1,1),
	StudentID INT NOT NULL REFERENCES Users(UserID),
	QuizID INT NOT NULL REFERENCES Quizzes(QuizID),
	Score DECIMAL(5,2) NOT NULL,
	Category NVARCHAR(20) NOT NULL,
	CompletedAt DATETIME DEFAULT GETDATE()
);
END
GO

--Answers given per attempt
--SelectedOptionID can be null if question was skipped
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'AttemptAnswers' AND xType = 'U')
BEGIN
CREATE TABLE AttemptAnswers
(
	AnswerID INT PRIMARY KEY IDENTITY(1,1),
	AttemptID INT NOT NULL REFERENCES QuizAttempts(AttemptID),
	QuestionID INT NOT NULL REFERENCES Questions(QuestionID),
	SelectedOptionID INT REFERENCES AnswerOptions(OptionID),
);
END
GO

--Overall Student stats
--Tracks overall average and current performance category
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'StudentStats' AND xType = 'U')
BEGIN
CREATE TABLE StudentStats
(
	StatID INT PRIMARY KEY IDENTITY(1,1),
	StudentID INT NOT NULL REFERENCES Users(UserID) UNIQUE,
	AverageScore DECIMAL(5,2) NOT NULL DEFAULT 0,
	TotalAttempts INT NOT NULL DEFAULT 0,
	CurrentCategory NVARCHAR(20) NOT NULL DEFAULT 'NORMAL',
	LastUpdated DATETIME DEFAULT GETDATE()
);
END
GO