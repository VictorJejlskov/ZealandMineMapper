using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Name = "Unknown";
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
