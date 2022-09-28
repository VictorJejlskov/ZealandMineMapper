namespace SchoolAdministrationV10
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public Student(int id, string name)
        {
            Courses = new List<Course>();
            Id = id;
            Name = name;
        }

        public void AddTestResult(string courseName, int score)
        {
            Courses.Add(new Course(courseName, score));
        }
        public int GetAverage()
        {
            List<int> Scores = Courses.Select(c => c.Score).ToList();
            return (int)Scores.Average();
        }
    }
}