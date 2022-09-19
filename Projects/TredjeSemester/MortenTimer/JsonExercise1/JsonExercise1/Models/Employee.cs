using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise1.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int MonthsEmployed { get; set; }
        public List<string> JobAreas { get; set; }

        public Employee(string name, int salary, int monthsEmployed, List<string> jobAreas)
        {
            Name = name;
            Salary = salary;
            MonthsEmployed = monthsEmployed;
            JobAreas = jobAreas;
        }
        public Employee()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}, MonthsEmployed: {MonthsEmployed}, JobAreas: {JobAreas}";
        }
    }
}
