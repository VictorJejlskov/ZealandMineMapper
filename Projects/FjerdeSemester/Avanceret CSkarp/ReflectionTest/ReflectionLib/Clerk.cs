using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public class Clerk : Person
    {
        public List<string> Skills { get; set; }


        public Clerk(string name, int birthOfYear, List<string> skills) : base(name, birthOfYear)
        {
            Skills = skills;
        }
    }
}
