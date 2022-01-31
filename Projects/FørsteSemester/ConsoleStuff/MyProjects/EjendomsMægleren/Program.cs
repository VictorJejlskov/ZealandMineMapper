using System;
using System.ComponentModel;

namespace EjendomsMægleren
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.StartUp();

            PropertyCatalogue.GetAll();

            PropertyCatalogue.PrintList(PropertyCatalogue.FilteredList(Property.PropertyTypes.Apartment));
            Console.WriteLine($"\nHer er estate");
            PropertyCatalogue.PrintList(PropertyCatalogue.FilteredList(Property.PropertyTypes.Estate));
            Console.WriteLine($"\nFind property 3");
            Console.WriteLine(PropertyCatalogue.GetByID(3));
            Console.WriteLine($"\nProperties billigere end 50.000:");
            PropertyCatalogue.PrintList(PropertyCatalogue.GetByPrice(50000));
            Console.WriteLine($"\nLejligheder større end 35:");
            PropertyCatalogue.PrintList(PropertyCatalogue.GetBySize(35));

        }
    }
}
