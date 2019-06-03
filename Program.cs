using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main()
        {
            // Creating a few exercises
            Exercise Dictionaries = new Exercise()
            {
                ExerciseName = "Dictionaries",
                ExerciseLanguage = "C#"
            };
            Exercise EmployeeList = new Exercise()
            {
                ExerciseName = "Employee List",
                ExerciseLanguage = "C#"
            };
            Exercise EnglishIdioms = new Exercise()
            {
                ExerciseName = "English Idioms",
                ExerciseLanguage = "C#"
            };
            Exercise RandallsCarLot = new Exercise()
            {
                ExerciseName = "Randalls Car Lot",
                ExerciseLanguage = "C#"
            };
            
            // Creating a few cohorts
            Cohort Cohort31 = new Cohort()
            {
                CohortName = "Day Cohort 31"
            };
            Cohort Cohort32 = new Cohort()
            {
                CohortName = "Day Cohort 32"
            };
            Cohort Cohort33 = new Cohort()
            {
                CohortName = "Day Cohort 33"
            };

            // Creating a few students
            Student Billy = new Student()
            {
                FirstName = "Billy",
                LastName = "Mitchell",
                SlackHandle = "William Mitchell"
            };
            Student Chris = new Student()
            {
                FirstName = "Chris",
                LastName = "Morgan",
                SlackHandle = "Chris Morgan"
            };
            Student Brian = new Student()
            {
                FirstName = "Brian",
                LastName = "Jobe",
                SlackHandle = "Brian Jobe"
            };
            Student Ali = new Student()
            {
                FirstName = "Ali",
                LastName = "Abdulle",
                SlackHandle = "Ali Abdulle"
            };

            // Creating a few instructors
            Instructor Andy = new Instructor()
            {
                FirstName = "Andy",
                LastName = "Collins",
                SlackHandle = "Andy Collins",
                InstructorSpecialty = "Jokes"
            };
            Instructor Leah = new Instructor()
            {
                FirstName = "Leah",
                LastName = "Hoefling",
                SlackHandle = "Leah Hoefling",
                InstructorSpecialty = "Baking"
            };
            Instructor Jisie = new Instructor()
            {
                FirstName = "Jisie",
                LastName = "David",
                SlackHandle = "Jisie David",
                InstructorSpecialty = "JavaScript"
            };

            //Assigning students to cohorts
            Cohort31.StudentsInCohort.Add(Billy);
            Billy.Cohort = Cohort31;
            Cohort32.StudentsInCohort.Add(Chris);
            Chris.Cohort = Cohort32;
            Cohort33.StudentsInCohort.Add(Brian);
            Brian.Cohort = Cohort33;
            Cohort32.StudentsInCohort.Add(Ali);
            Ali.Cohort = Cohort32;

            //Assigning instructors to cohorts
            Cohort31.InstructorsInCohort.Add(Andy);
            Andy.Cohort = Cohort31;
            Cohort32.InstructorsInCohort.Add(Leah);
            Leah.Cohort = Cohort32;
            Cohort33.InstructorsInCohort.Add(Jisie);
            Jisie.Cohort = Cohort33;

            //Assigning Exercises to Students
            Andy.AssignExercise(Billy, Dictionaries);
            Andy.AssignExercise(Billy, EmployeeList);
            Leah.AssignExercise(Chris, Dictionaries);
            Leah.AssignExercise(Chris, EnglishIdioms);
            Jisie.AssignExercise(Brian, EmployeeList);
            Jisie.AssignExercise(Brian, RandallsCarLot);
            Leah.AssignExercise(Ali, EnglishIdioms);
            Leah.AssignExercise(Ali, RandallsCarLot);

            List<Student> Students = new List<Student>() {
                Billy, Chris, Brian, Ali
            };

            List<Exercise> Exercises = new List<Exercise>() {
                Dictionaries, EmployeeList, EnglishIdioms, RandallsCarLot
            };

            foreach(Student student in Students) {
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on");
                foreach(Exercise exercise in student.ListOfStudentExercises) {
                    Console.WriteLine($"{exercise.ExerciseName} using computer language {exercise.ExerciseLanguage}");
                }
            }

            // //Assigning students to cohorts
            // Cohort31.AssignStudentToCohort(Billy);
            // Cohort32.AssignStudentToCohort(Chris);
            // Cohort33.AssignStudentToCohort(Brian);
            // Cohort32.AssignStudentToCohort(Ali);

            // //Assigning instructors to cohorts
            // Cohort31.AssignInstructorToCohort(Andy);
            // Cohort32.AssignInstructorToCohort(Leah);
            // Cohort33.AssignInstructorToCohort(Jisie);

            // //Assigning exercises to students
            // Billy.AssignExerciseToStudent(Dictionaries);
            // Billy.AssignExerciseToStudent(EmployeeList);

            // Chris.AssignExerciseToStudent(Dictionaries);
            // Chris.AssignExerciseToStudent(EnglishIdioms);

            // Brian.AssignExerciseToStudent(EmployeeList);
            // Brian.AssignExerciseToStudent(RandallsCarLot);

            // Ali.AssignExerciseToStudent(EnglishIdioms);
            // Ali.AssignExerciseToStudent(RandallsCarLot);

            // Billy.AddStudent(Billy);
            // Student2.AddStudent(Student2);
            // Brian.AddStudent(Brian);
            // Ali.AddStudent(Ali);

            // Dictionaries.AddExercise(Dictionaries);
            // EmployeeList.AddExercise(EmployeeList);
            // EnglishIdioms.AddExercise(EnglishIdioms);
            // RandallsCarLot.AddExercise(RandallsCarLot);
        }
    }
}
