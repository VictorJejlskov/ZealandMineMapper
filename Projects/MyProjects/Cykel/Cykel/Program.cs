using System;

namespace Cykel
{
    class Program
    {
        static void Main(string[] args)
        {
            Cykel myCykel = new Cykel("Centurion","Grøn","Wx202116","MountainBike",28);
            //Console.WriteLine($"Brand: {myCykel.Brand}");
            //Console.WriteLine($"Color: {myCykel.Color}");
            //Console.WriteLine($"Serial: {myCykel.Serial}");
            //Console.WriteLine($"Type: {myCykel.Type}");
            //Console.WriteLine($"Size: {myCykel.Size}");
            Console.WriteLine(myCykel);
        }
    }
}
