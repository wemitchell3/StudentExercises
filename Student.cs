using System.Collections.Generic;

namespace StudentExercises
{
    class Student : NSSPerson
    {
        public Cohort Cohort { get; set; }
        public List<Exercise> ListOfStudentExercises { get; set; } = new List<Exercise>(); 
    }
}