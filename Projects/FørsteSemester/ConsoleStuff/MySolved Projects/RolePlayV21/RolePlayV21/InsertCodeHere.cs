using System;
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression

namespace RolePlayV21
{
    public class InsertCodeHere
    {
        public int WarriorWins { get; set; }
        public int BeastWins { get; set; }
        static NumberGenerator generator = new NumberGenerator();
        static BattleLog log = new BattleLog();

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Fight(100);
            Console.WriteLine($"Warrior won: {WarriorWins} times\nBeasts won {BeastWins} times");
        }

        public void Fight(int amount)
        {
            for (int i = 0; i < amount; i++)
            {

                Hero theHero = new Hero(generator, log, "Olafur", 100, 10, 25);
                BeastArmy beastArmy = new BeastArmy();
                beastArmy.AddBeast(new Beast(generator, log, "Søren", 25, 8, 15));
                beastArmy.AddBeast(new Beast(generator, log, "Benjamin", 25, 8, 15));
                beastArmy.AddBeast(new Beast(generator, log, "Karl", 25, 8, 13));
                while (!theHero.Dead && !beastArmy.Dead)
                {
                    int damageByHero = theHero.DealDamage();
                    beastArmy.ReceiveDamage(damageByHero);

                    if (!beastArmy.Dead)
                    {
                        int damageByBeast = beastArmy.DealDamage();
                        theHero.ReceiveDamage(damageByBeast);
                    }
                }

                if (beastArmy.Dead)
                {
                    WarriorWins++;
                }
                else if (theHero.Dead)
                {
                    BeastWins++;
                }
                theHero.Reset();
                beastArmy.BeastReset();

            }
        }
    }
}