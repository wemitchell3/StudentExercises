CREATE TABLE `Cohort`
(
  `Id` int PRIMARY KEY,
  `CohortName` varchar(255)
);

CREATE TABLE `Student`
(
  `Id` int PRIMARY KEY,
  `FirstName` varchar(255),
  `LastName` varchar(255),
  `SlackHandle` varchar(255),
  `CohortId` int
);

CREATE TABLE `Instructor`
(
  `Id` int PRIMARY KEY,
  `FirstName` varchar(255),
  `LastName` varchar(255),
  `SlackHandle` varchar(255),
  `Specialty` varchar(255),
  `CohortId` int
);

CREATE TABLE `Exercise`
(
  `Id` int PRIMARY KEY,
  `ExerciseName` varchar(255),
  `ExerciseLanguage` varchar(255)
);

CREATE TABLE `ExerciseCollection`
(
  `Id` int PRIMARY KEY,
  `Student_id` int,
  `Exercise` int
);

ALTER TABLE `Student` ADD FOREIGN KEY (`CohortId`) REFERENCES `Cohort` (`Id`);

ALTER TABLE `Instructor` ADD FOREIGN KEY (`CohortId`) REFERENCES `Cohort` (`Id`);

ALTER TABLE `ExerciseCollection` ADD FOREIGN KEY (`Student_id`) REFERENCES `Student` (`Id`);

ALTER TABLE `ExerciseCollection` ADD FOREIGN KEY (`Exercise`) REFERENCES `Exercise` (`Id`);
