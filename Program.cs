using System;
using System.Collections.Generic;
using System.Linq;

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
                ExerciseLanguage = "JavaScript"
            };
            Exercise EnglishIdioms = new Exercise()
            {
                ExerciseName = "English Idioms",
                ExerciseLanguage = "C#"
            };
            Exercise RandallsCarLot = new Exercise()
            {
                ExerciseName = "Randalls Car Lot",
                ExerciseLanguage = "JavaScript"
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
                SlackHandle = "William Mitchell",
                ListOfStudentExercises = new List<Exercise>()
            };
            Student Chris = new Student()
            {
                FirstName = "Chris",
                LastName = "Morgan",
                SlackHandle = "Chris Morgan",
                ListOfStudentExercises = new List<Exercise>()
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
                SlackHandle = "Ali Abdulle",
                ListOfStudentExercises = new List<Exercise>()
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
            Cohort31.StudentsInCohort.Add(Ali);
            Ali.Cohort = Cohort31;

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
            Andy.AssignExercise(Billy, EnglishIdioms);
            Leah.AssignExercise(Chris, Dictionaries);
            Leah.AssignExercise(Chris, EnglishIdioms);
            // Jisie.AssignExercise(Brian, EmployeeList);
            // Jisie.AssignExercise(Brian, RandallsCarLot);
            Leah.AssignExercise(Ali, EnglishIdioms);
            Leah.AssignExercise(Ali, RandallsCarLot);

            List<Student> Students = new List<Student>() {
                Billy,
                Chris,
                Brian,
                Ali
            };

            List<Exercise> Exercises = new List<Exercise>() {
                Dictionaries,
                EmployeeList,
                EnglishIdioms,
                RandallsCarLot
            };

            List<Instructor> Instructors = new List<Instructor>() {
                Andy,
                Leah,
                Jisie
            };

            List<Cohort> Cohorts = new List<Cohort>() {
                Cohort31,
                Cohort32,
                Cohort33
            };

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");
            Console.WriteLine("The following students are working these exercises:");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on");
                foreach (Exercise exercise in student.ListOfStudentExercises)
                {
                    Console.WriteLine($"{exercise.ExerciseName} using computer language {exercise.ExerciseLanguage}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

            Console.WriteLine("The following list of exercises use JavaScript:");
            foreach (Exercise exercise in Exercises.Where(exercise => exercise.ExerciseLanguage == "JavaScript"))
            {
                Console.WriteLine(exercise.ExerciseName);
            }
            
            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

            Console.WriteLine("The Day Cohort 31 has the following students:");
            foreach (Student student in Students.Where(student => student.Cohort == Cohort31))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            
            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

            Console.WriteLine("The Day Cohort 31 has the following instructors:");
            foreach (Instructor instructor in Instructors.Where(instructor => instructor.Cohort == Cohort31))
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }
            
            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

            Console.WriteLine("Here is a list of students at NSS in descending order by last name:");
            foreach (Student student in Students.OrderByDescending(name => name.LastName))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

            foreach (Student student in Students.Where(student => student.ListOfStudentExercises.Count == 0))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is currently NOT working on any exercises.");
            }

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

            // List<Student> studentsNumberOfExercises = new List<Student>();
            
            // foreach (Student student in Students.OrderByDescending(s => s.ListOfStudentExercises.Count()))
            // {   
            //     studentsNumberOfExercises.Add(student);
            // }
            //     var studentWithMostExercises = studentsNumberOfExercises.First();
            
            // Console.WriteLine("****");
            // Console.WriteLine("The following student is working on the most exercises:");
            // Console.WriteLine(studentWithMostExercises.FirstName);

            Student studentWithMostExercises = Students.OrderByDescending(student => 
                student.ListOfStudentExercises.Count).ToList()[0];

            Console.WriteLine("The following student is working on the most exercises:");
            Console.WriteLine(studentWithMostExercises.FirstName);

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");
            
            foreach (Cohort cohort in Cohorts)
            {   
                Console.WriteLine($"There are {cohort.StudentsInCohort.Count} students in {cohort.CohortName}");
            }

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("");

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
