namespace StudentExercises
{
    class Instructor : NSSPerson
    {
        public Cohort Cohort { get; set; }
        public string InstructorSpecialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.ListOfStudentExercises.Add(exercise);
            exercise.ListOfStudents.Add(student);
        }
    }
}