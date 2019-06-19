CREATE TABLE Cohort
(
  Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
  CohortName VARCHAR(55) NOT NULL,
);

CREATE TABLE Student
(
  Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
  FirstName VARCHAR(55) NOT NULL,
  LastName VARCHAR(55) NOT NULL,
  SlackHandle VARCHAR(55) NOT NULL,
  CohortId INTEGER NOT NULL, 
  CONSTRAINT FK_Student_CohortId FOREIGN KEY (CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Instructor
(
  Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
  FirstName VARCHAR(55) NOT NULL,
  LastName VARCHAR(55) NOT NULL,
  SlackHandle VARCHAR(55) NOT NULL,
  InstructorSpecialty VARCHAR(55) NOT NULL,
  CohortId INTEGER NOT NULL
  CONSTRAINT FK_Instructor_CohortId FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Exercise
(
  Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
  ExerciseName VARCHAR(55) NOT NULL,
  ExerciseLanguage VARCHAR(55) NOT NULL
);

CREATE TABLE ExerciseCollection
(
  Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
  StudentId INTEGER NOT NULL,
  ExerciseId INTEGER NOT NULL,
  CONSTRAINT FK_ExerciseCollection_StudentId FOREIGN KEY(StudentId) REFERENCES Student(Id),
  CONSTRAINT FK_ExerciseCollection_ExerciseId FOREIGN KEY(ExerciseId) REFERENCES Exercise(Id)
);

INSERT INTO Cohort (CohortName) VALUES ('Cohort31');
INSERT INTO Cohort (CohortName) VALUES ('Cohort32');
INSERT INTO Cohort (CohortName) VALUES ('Cohort33');

INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId) VALUES ('Billy', 'Mitchell', 'Billy Mitchell', 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId) VALUES ('Rose', 'Wisotzkey', 'Rose Wisotzkey', 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId) VALUES ('Chris', 'Morgan', 'Chris Morgan', 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId) VALUES ('Billy', 'Mathison', 'Billy Mathison', 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId) VALUES ('Alex', 'Thacker', 'Alex Thacker', 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId) VALUES ('Ali', 'Abdulle', 'Ali Abdulle', 3);

INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorSpecialty, CohortId) VALUES ('Andy', 'Collins', 'Andy Collins', 'Jokes', 1);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorSpecialty, CohortId) VALUES ('Leah', 'Hoefling', 'Leah Hoefling', 'Whiteboarding', 1);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorSpecialty, CohortId) VALUES ('Joe', 'Shepard', 'Joe Shepard', 'Jokes', 2);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorSpecialty, CohortId) VALUES ('Kristen', 'Norris', 'Kristen Norris', 'Baking', 2);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorSpecialty, CohortId) VALUES ('Jisie', 'David', 'Jisie Davide', 'Sass', 3);

INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('kandy-korner', 'JavaScript');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('contact-list', 'JavaScript');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('dictionaries', 'csharp');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('randalls-car-lot', 'csharp');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('try-catch', 'csharp');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('employee-list', 'csharp');

INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (3, 1);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (3, 2);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (4, 1);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (4, 2);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (5, 3);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (5, 4);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (6, 3);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (6, 4);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (7, 5);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (7, 6);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (8, 5);
INSERT INTO ExerciseCollection (StudentId, ExerciseId) VALUES (8, 6);


SELECT * FROM Cohort;
SELECT * FROM Student;
SELECT * FROM Instructor;
SELECT * FROM Exercise;
SELECT * FROM ExerciseCollection;



-- DROP TABLE Cohort;
-- DROP TABLE Student;
-- DROP TABLE Instructor;
-- DROP TABLE Exercise;
-- DROP TABLE ExerciseCollection;