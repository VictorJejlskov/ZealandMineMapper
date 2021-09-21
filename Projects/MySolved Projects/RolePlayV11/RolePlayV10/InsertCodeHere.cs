using System;

namespace RolePlayV11
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            
            Warrior warriorA = new Warrior("Ragnar", 120, true);
            Warrior warriorB = new Warrior("Lagertha", 120, true);

            Console.WriteLine($"Warrior A is called {warriorA.Name} is level {warriorA.Level} and has {warriorA.Hitpoints} hitpoints and is currently alive: {warriorA.IsAlive}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} is level {warriorB.Level} and has {warriorB.Hitpoints} hitpoints and is currently alive: {warriorB.IsAlive}");
            Console.WriteLine();
            Console.WriteLine("Your warriors begin to fight eachother");
            Console.WriteLine();

            //Random rnd = new Random();

            while (warriorA.IsAlive && warriorB.IsAlive)
            {
                //int damageA = rnd.Next(1, 31);
                //warriorA.HitPointChange(damageA);
                //int damageB = rnd.Next(1, 31);
                //warriorB.HitPointChange(damageB);
                warriorA.DealDamage();
                warriorB.DealDamage();
                warriorA.IsBelowZero();
                warriorB.IsBelowZero();
                Console.WriteLine($"{warriorA.Name} has {warriorA.Hitpoints} health remaining");
                Console.WriteLine($"{warriorB.Name} has {warriorB.Hitpoints} health remaining");
            }

            if (warriorA.IsAlive == false && warriorB.IsAlive == true)
            {
                Console.WriteLine();
                Console.WriteLine($"{warriorA.Name} died!");
                Console.WriteLine($"{warriorB.Name} is the winner!");
            }
            else if (warriorA.IsAlive == true && warriorB.IsAlive == false)
            {
                Console.WriteLine();
                Console.WriteLine($"{warriorB.Name} died!");
                Console.WriteLine($"{warriorA.Name} is the winner!");
            }
            else if (warriorA.IsAlive == false && warriorB.IsAlive == false)
            {
                Console.WriteLine();
                Console.WriteLine("Both warriors died, it's a draw!");
            }


            // The LAST line of code should be ABOVE this line
        }
    }
}