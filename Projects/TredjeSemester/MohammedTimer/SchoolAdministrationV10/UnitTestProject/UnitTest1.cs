using SchoolAdministrationV10;

namespace UnitTestProject
{
    [TestClass]
    public class StudentCatalogTest
    {
        private StudentCatalog _students;

        public void TestSetup()
        {
            _students = new StudentCatalog();

            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");
            Student diana = new Student(295, "Diana");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            _students.AddStudent(anna);
            _students.AddStudent(betty);
            _students.AddStudent(carl);
            _students.AddStudent(diana);
        }

        [TestMethod]
        public void TestAddStudent()
        {
            // Arrange
            TestSetup();
            int expected = _students.GetStudents().Count +1;


            // Act
            _students.AddStudent(new Student(1, "Søren"));
            int actual = _students.GetStudents().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetStudent_ExistingStudent()
        {
            // Arrange
            TestSetup();
            string expectedName = "Anna";
            // Act
            string actualName = _students.GetStudentById(12).Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [TestMethod]
        public void TestGetStudent_NonExistingStudent()
        {
            // Arrange
            TestSetup();
            // Act

            // Assert
            Assert.ThrowsException<NullReferenceException>(() => _students.GetStudentById(100));

        }

        [TestMethod]
        public void TestGetAverageForStudent_ExistingStudent()
        {
            // Arrange
            TestSetup();
            int expected = 297/4;
            // Act
            int actual = _students.GetStudentById(12).GetAverage();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetAverageForStudent_NonExistingStudent()
        {
            // Arrange
            TestSetup();
            // Act

            // Assert
            Assert.ThrowsException<NullReferenceException>(() => _students.GetStudentById(5));
        }
    }
}
