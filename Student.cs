using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> ListOfStudentExercises { get; set; } = new List<Exercise>(); 
    }
}