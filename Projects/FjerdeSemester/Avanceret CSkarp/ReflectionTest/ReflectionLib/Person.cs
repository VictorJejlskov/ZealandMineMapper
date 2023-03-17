using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int BirthOfYear { get; set; }

        protected Person(string name, int birthOfYear)
        {
            Name = name;
            BirthOfYear = birthOfYear;
        }

        public int Age { get { return DateTime.Now.Year - BirthOfYear; } }
    }
}
