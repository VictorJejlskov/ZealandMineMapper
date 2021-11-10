using System;

namespace RolePlayV12
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Sword swordA = new Sword("Meatcleaver", 50, 100);
            Sword swordB = new Sword("Poke-Stick", 10, 300);

            Warrior warriorA = new Warrior("Ragnar", 200, 1.7, swordA, swordA);
            Warrior warriorB = new Warrior("Lagertha", 240, 1.3, swordB);

            Console.WriteLine("Just after creation:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            double damageFromA = warriorA.DealDamage();
            double damageFromB = warriorB.DealDamage();
            warriorA.ReceiveDamage(Convert.ToInt32(damageFromB));
            warriorB.ReceiveDamage(Convert.ToInt32(damageFromA));

            Console.WriteLine("After damage:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            Console.WriteLine(warriorA.WeaponInfo());
            Console.WriteLine(warriorB.WeaponInfo());

            warriorB.SwapWeapon(swordA);
            Console.WriteLine(warriorB.WeaponInfo());
            // The LAST line of code should be ABOVE this line
        }
    }
}