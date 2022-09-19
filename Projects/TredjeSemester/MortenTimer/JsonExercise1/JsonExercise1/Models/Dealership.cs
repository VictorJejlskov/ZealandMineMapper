using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise1.Models
{
    internal class Dealership
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }
        public List<Employee> Employees { get; set; }

        public Dealership(string name, string address, List<Car> cars, List<Employee> employees)
        {
            Name = name;
            Address = address;
            Cars = cars;
            Employees = employees;
        }
        public Dealership()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Cars: {Cars}, Employees: {Employees}";
        }
    }
}
