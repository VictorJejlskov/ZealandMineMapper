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
    public class StudentTests
    {
        Student studentGood = new Student() { Id = 1, Name = "Klamme John", Semester = 3, Gender = Person.GenderType.Male};
        Student studentNullName = new Student() { Id = 2, Semester = 5};
        Student studentBadName = new Student() { Id = 3, Name = "", Semester = 2};
        Student studentHighSemester = new Student() { Id = 4, Name = "Zackarias", Semester = 9};
        Student StudentMaxSemester = new Student() { Id = 5, Name = "Andreas", Semester = 8};
        Student studentLowSemester = new Student() { Id = 6, Name = "Mr Guy", Semester = 0};
        Student studentMinSemester = new Student() { Id = 7, Name = "Frederik", Semester = 1};
        Student studentOKSemester = new Student() { Id = 8, Name = "Martin", Semester = 5};
        Student studentEquals = new Student() { Id = 1, Name = "Klamme John", Semester = 3, Gender = Person.GenderType.Male };


        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("{Semester=3, Id=1, Name=Klamme John, Gender=Male}", studentGood.ToString());
        }
        [TestMethod()]
        public void ValidateNameTest()
        {
            studentGood.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => studentNullName.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentBadName.ValidateName());
        }

        [TestMethod()]
        public void ValidateSemesterTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentHighSemester.ValidateSemester());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentLowSemester.ValidateSemester());
            StudentMaxSemester.ValidateSemester();
            studentMinSemester.ValidateSemester();
            studentOKSemester.ValidateSemester();
        }
        [TestMethod()]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(7)]
        [DataRow(8)]
        public void AlsoValidateSemesterTest(int semester)
        {
            studentOKSemester.Semester = semester;
            studentOKSemester.ValidateSemester();
        }
        [TestMethod]
        public void EqualsTest()
        {
            Assert.AreEqual(studentGood, studentEquals);
            Assert.AreNotEqual(studentGood, studentBadName);
        }
        public void GetHashCodeTest()
        {
            Assert.AreEqual(studentGood.GetHashCode, studentEquals.GetHashCode);
        }

    }
}