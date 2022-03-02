using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDeligateTest
{
    class Program
    {
        static String _searchName;
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person(1, "Camilla", 20),
                new Person(2, "Nikolaj", 17),
                new Person(3, "Viggo",25)
            };

            _searchName = "Camilla";

            Console.WriteLine("Find() - Predicate Delegate");
            Predicate<Person> myPredicateDeligate = new Predicate<Person>(PersonNameSearch); //Method 1: Traditional, use of Predicate and a search-metod
            Person searchResult = persons.Find(myPredicateDeligate);

            Console.WriteLine(searchResult);
            Console.WriteLine();
  
                     
            _searchName = "Nikolaj";

            Console.WriteLine("Find() - Anonymous Delegate method");
            searchResult = persons.Find(delegate (Person p)                                  //Method 2: Use of anonymous search method
            {
                return p.Name.Equals(_searchName);
            });

            Console.WriteLine(searchResult);
            Console.WriteLine();


            _searchName = "Viggo";

            Console.WriteLine("Find() - Method Group Conversion");
      //    searchResult = persons.Find((p) => PersonNameSearch(p));                        //Method 3.1: Use of lamda with call of "delegate" method
            searchResult = persons.Find(PersonNameSearch);                                  //Now with Method Group Conversion

            Console.WriteLine(searchResult);
            Console.WriteLine();


            Console.WriteLine("Find() - Lambda expressions");
       //   searchResult = persons.Find((p) => p.Name.Equals(_searchName));                 //Method 3.2: Use of lambda-expression
            searchResult = persons.Find(p => p.Name.Equals(_searchName));                   //Notice: we don't need the ( )

            Console.WriteLine(searchResult);
            Console.WriteLine();


            Console.WriteLine("Find() - Func Delegate");
            Func<Person, String, bool> funcDelegatePersonNameSearch = (person, name) => (person.Name.Equals(name));
            searchResult = persons.Find(p =>funcDelegatePersonNameSearch(p, _searchName));

            Console.WriteLine(searchResult);
            Console.WriteLine();


            searchResult = Search(persons, "Viggo");                        //The Func Delegate is wrapped into a method
            Console.WriteLine(searchResult);
            Console.WriteLine();


            Console.WriteLine("FindAll() - Persons Contains 'o'");
            var searchListResult = persons.FindAll(p => p.Name.Contains("o"));
            foreach (var person in searchListResult)
            {
                Console.WriteLine(person);
            }
          
        }



        static bool PersonNameSearch(Person p)
        {
            return p.Name.Equals(_searchName);
        }

        static Person Search(List<Person> persons, String searchName)               //Could it be made Generic?
        {
           Func<Person, String, bool> funcDelegatePersonNameSearch = (person, name) => (person.Name.Equals(name));
           return persons.Find(p => funcDelegatePersonNameSearch(p, searchName));
        }

        

    }
}
