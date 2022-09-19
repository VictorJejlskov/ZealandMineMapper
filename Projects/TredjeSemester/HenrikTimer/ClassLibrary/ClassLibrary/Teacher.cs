using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person, ITeacher
    {
        public int Salary { get; set; }
        public List<string> Classes { get; set; }


        public override void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException("Name is null :(");
            if (String.IsNullOrWhiteSpace(Name)) throw new ArgumentOutOfRangeException("Name is empty :(");
        }
        public void ValidateSalary()
        {
            if (Salary < 0) throw new ArgumentOutOfRangeException("Du betaler løn, kælling :(");
        }
        public void ValidateClasses()
        {
            if (Classes == null) throw new ArgumentNullException("Classes er Null");
            if (Classes.Count <= 0) throw new ArgumentOutOfRangeException("Classes skal være længere end 0");
        }

        public override void Validate()
        {
            ValidateName();
            ValidateSalary();
            ValidateClasses();
        }

        public override bool Equals(object? obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   Id == teacher.Id &&
                   Name == teacher.Name &&
                   Gender == teacher.Gender &&
                   Salary == teacher.Salary;
            //EqualityComparer<List<string>>.Default.Equals(Classes, teacher.Classes);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, Name, Gender, Salary);
        }

        public override string ToString()
        {
            return $"{{{nameof(Salary)}={Salary.ToString()}, {nameof(Classes)}={Classes}, {nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}}}";
        }
    }

}
