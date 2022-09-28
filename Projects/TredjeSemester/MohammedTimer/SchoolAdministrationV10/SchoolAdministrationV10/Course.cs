using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdministrationV10
{
    public class Course
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Course(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
