using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public int Id { get; set; }
        public string CohortName { get; set; }
        public List<Student> StudentsInCohort { get; set; } = new List<Student>();
        public List<Instructor> InstructorsInCohort { get; set; } = new List<Instructor>();
        // public void AssignStudentToCohort(Student student) => StudentsInCohort.Add(student);
        // public void AssignInstructorToCohort(Instructor instructor) => InstructorsInCohort.Add(instructor); 
    }
}