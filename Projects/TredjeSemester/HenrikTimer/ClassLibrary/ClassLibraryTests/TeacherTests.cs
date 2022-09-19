using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private List<string> courses = new List<string>() { "Math", "Historie", "Programming" };
        private Teacher teacher = new Teacher() { Id = 1, Name = "Victor Jejlskov", Salary = 50000, Classes = new List<string>() { "Math", "Historie", "Programming" }, Gender = Person.GenderType.Male };
        private Teacher teacherNullname = new Teacher() { Id = 2, Salary = 35000, Classes = new List<string>() { "Math", "Historie", "Programming" } };
        private Teacher teacherEmptyName = new Teacher() { Id = 3, Name = "", Salary = 35000, Classes = new List<string>() { "Math", "Historie", "Programming" } };
        private Teacher teacherNonValidSalary = new Teacher() { Id = 4, Name = "Victor Jejlskov", Salary = -5, Classes = new List<string>() { "Math", "Historie", "Programming" } };
        private Teacher teacherNoClasses = new Teacher() { Id = 5, Name = "Yeet", Salary = 50000, Classes = new List<string>() {} };
        private Teacher teacherNullClasses = new Teacher() { Id = 6, Name = "Yote", Salary = 50000 };
        private Teacher teacherEquals = new Teacher() { Id = 1, Name = "Victor Jejlskov", Salary = 50000, Classes = new List<string>() { "Math", "Historie", "Programming" }, Gender = Person.GenderType.Male };

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("{Salary=50000, Classes=System.Collections.Generic.List`1[System.String], Id=1, Name=Victor Jejlskov, Gender=Male}", teacher.ToString());
        }
        [TestMethod()]
        public void ValidateNameTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => teacherNullname.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacherEmptyName.ValidateName());    
        }

        [TestMethod()]
        public void ValidateSalaryTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> teacherNonValidSalary.ValidateSalary());
        }

        [TestMethod]
        public void ValidateClassesTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacherNoClasses.ValidateClasses());
            Assert.ThrowsException<ArgumentNullException>(() => teacherNullClasses.ValidateClasses());
        }
        [TestMethod()]
        public void ValidateTest()
        {
            teacher.Validate();
        }
        [TestMethod]
        public void EqualsMethod()
        {
            Assert.AreNotEqual(teacher, teacherNullClasses);
            Assert.AreEqual(teacher, teacherEquals);
        }
        public void GetHashCodeTest()
        {
            Assert.AreEqual(teacher.GetHashCode, teacherEquals.GetHashCode);
        }
    }
}