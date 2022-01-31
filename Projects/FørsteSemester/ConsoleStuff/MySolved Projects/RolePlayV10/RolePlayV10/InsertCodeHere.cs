using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar");
            Warrior warriorB = new Warrior("Lagertha");
            

            Console.WriteLine($"Warrior A is called {warriorA.Name} and is level {warriorA.Level}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} and is level {warriorB.Level}");

            Console.WriteLine();
            Console.WriteLine("After slaying some monsters, your warriors gained a level each");

            warriorA.LevelUp();
            warriorB.LevelUp();

            Console.WriteLine();
            Console.WriteLine("Their new levels are:");
            Console.WriteLine($"{warriorA.Name} = {warriorA.Level}");
            Console.WriteLine($"{warriorB.Name} = {warriorB.Level}");

            // The LAST line of code should be ABOVE this line
        }
    }
}