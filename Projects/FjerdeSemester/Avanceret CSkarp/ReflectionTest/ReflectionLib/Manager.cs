using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public class Manager : Person
    {
        public List<Person> Employees { get; set; }
        public Manager(string name, int birthOfYear, List<Person> employees) : base(name, birthOfYear)
        {
            Employees = employees;
        }
    }
}
