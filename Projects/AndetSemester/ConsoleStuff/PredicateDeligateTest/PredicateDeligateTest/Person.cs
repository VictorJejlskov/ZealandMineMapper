using System;

namespace PredicateDeligateTest
{
    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        protected bool Equals(Person other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public int CompareTo(Person other)
        {
            return Id - other.Id;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, Age: {2}", Id, Name, Age);
        }
    }
}
