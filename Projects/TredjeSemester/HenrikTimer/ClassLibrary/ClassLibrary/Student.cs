using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person, IStudent
    {
        public int Semester { get; set; }


        public override void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException("Name is null :(");
            if (String.IsNullOrWhiteSpace(Name)) throw new ArgumentOutOfRangeException("Name is empty :(");

        }
        public void ValidateSemester()
        {
            if (Semester < 1) throw new ArgumentOutOfRangeException("Semester kan ikke være under 1");
            if (Semester > 8) throw new ArgumentOutOfRangeException("Semester kan ikke være over 8");
        }
        public override void Validate()
        {
            ValidateName();
            ValidateSemester();
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Gender == student.Gender &&
                   Semester == student.Semester;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, Name, Gender, Semester);
        }

        public override string ToString()
        {
            return $"{{{nameof(Semester)}={Semester.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}}}";
        }
    }
}
