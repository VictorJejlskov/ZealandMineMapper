using System;

namespace RolePlayV12
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Sword swordA = new Sword("Meatcleaver", 100, 130);
            Sword swordB = new Sword("Poke-Stick", 10, 300);

            Warrior warriorA = new Warrior("Ragnar", 200, swordA);
            Warrior warriorB = new Warrior("Lagertha", 240, swordB);

            Console.WriteLine("Just after creation:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            int damageFromA = warriorA.DealDamage();
            int damageFromB = warriorB.DealDamage();
            warriorA.ReceiveDamage(damageFromB);
            warriorB.ReceiveDamage(damageFromA);

            Console.WriteLine("After damage:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}