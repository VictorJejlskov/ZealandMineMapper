using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum GenderType
        {
            Unknown = 0,
            Male = 1,
            Female = 2
        };
        public GenderType Gender { get; set; }

        public virtual void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException("Name is null :(");
            if (String.IsNullOrWhiteSpace(Name)) throw new ArgumentOutOfRangeException("Name is empty :(");
        }
        public virtual void Validate()
        {
            ValidateName();
        }

        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   Id == person.Id &&
                   Name == person.Name &&
                   Gender == person.Gender;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Gender);
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}}}";
        }
    }
}
