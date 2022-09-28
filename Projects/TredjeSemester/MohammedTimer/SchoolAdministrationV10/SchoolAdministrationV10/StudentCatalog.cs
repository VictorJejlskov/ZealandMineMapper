namespace SchoolAdministrationV10
{
    public class StudentCatalog
    {
        private List<Student> _students = new List<Student>();
        public StudentCatalog()
        {

        }
        public List<Student> GetStudents()
        {
            return _students;
        }
        public void AddStudent(Student newStud)
        {
            _students.Add(newStud);
        }
        public Student GetStudentById(int id)
        {
            if(id <= 0) throw new ArgumentOutOfRangeException("id");
            Student foundStud = _students.Find(stud => stud.Id.Equals(id));
            if (foundStud == null) throw new NullReferenceException();
            return foundStud;
        }
    }
}