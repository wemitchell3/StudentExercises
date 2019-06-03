using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string InstructorSpecialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.ListOfStudentExercises.Add(exercise);
            exercise.ListOfStudents.Add(student);
        }
    }
}