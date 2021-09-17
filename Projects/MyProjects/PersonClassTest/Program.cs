using System;

namespace PersonClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person("Henrik", 40);
            //p.Navn = "Henrik";
            //p.Alder = 40;
            Console.WriteLine($"Navn: {p.Navn} og alder: {p.Alder}");
            p.Navn = "Jørgen";
            p.Alder = 78;
            Console.WriteLine($"Navn: {p.Navn} og alder: {p.Alder}");
        }
    }
}
