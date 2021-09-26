using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace RoleplayMyRoleplay
{

    class SandboxCode
    {
        public string UserInput { get; set; }
        public static Random rnd = new Random();
        public bool IsFirstTime { get; set; } = true;
        public Warrior warrior { get; set; }= new Warrior("name", 500, 1.0, null, null);
        public Enemies enemies = new Enemies();
        public Enemy CurrEnemy;
        public void MyCode()
        {
            Console.Clear();
            if (IsFirstTime)
            {
                FirstTime();
            }
            Console.WriteLine(warrior);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"You now have 3 options: \n"+
                              $"1: Go fight an enemy!\n"+ 
                              $"2: Go visit the shop!\n"+
                              $"3: Save & Exit (dont do this plz im hopeless)");
            UserInput = Convert.ToString(Console.ReadKey().Key);
            if (UserInput == "D1")
            {
                FightAnEnemy();

            }
            else if (UserInput == "D2")
            {
                VisitShop();
            }
            else if (UserInput == "D3")
            {
                
                //add save method =)
            }
        }

        public void GenerateEnemies()
        {
            List<Enemy> enemies = new List<Enemy>();
            Enemies myEnemies = new Enemies();
            enemies = myEnemies.enemies;
            foreach (Enemy eme in enemies)
            {
                Console.WriteLine(eme);
            }
        }

        public void FirstTime()
        {
            IsFirstTime = false;
            Console.WriteLine($"Welcome to the world of ConsoleCraft\n" +
                              $"Please enter your name:");
            warrior.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {warrior.Name}\n"+
                              $"First of all, let's roll your weapon(s), please click Spacebar when ready");
            try
            {
                UserInput = Convert.ToString(Console.ReadKey().Key);
                if (UserInput == Convert.ToString(ConsoleKey.Spacebar))
                {
                    RollWeapons();
                    Console.Clear();
                }
            }
            catch (NullReferenceException e)
            {
                Console.Clear();
                Console.WriteLine("lul");
            }
        }



        public void RollWeapons()
        {
            int noOfWeps = rnd.Next(1, 3);
            if (noOfWeps == 1)
            {
                warrior.MainHandWeapon = Shop.weapons[rnd.Next(0, 4)];
            }
            else if (noOfWeps == 2)
            {
                warrior.MainHandWeapon = Shop.weapons[rnd.Next(0, 4)];
                warrior.OffHandWeapon = Shop.weapons[rnd.Next(0, 4)];
            }
        }

        public void FightAnEnemy()
        {
            Console.Clear();
            GenerateEnemies();
            Console.WriteLine($"Please select an enemy to fight, 1-5, or  click B to go back");
            UserInput = Convert.ToString(Console.ReadKey().Key);
            if (UserInput == "D1")
            {
                CurrEnemy = enemies.enemies[1];
                Console.Clear();
            }            
            if (UserInput == "D2")
            {
                CurrEnemy = enemies.enemies[2];
                Console.Clear();
            }            
            if (UserInput == "D3")
            {
                CurrEnemy = enemies.enemies[3];
                Console.Clear();
            }            
            if (UserInput == "D4")
            {
                CurrEnemy = enemies.enemies[4];
                Console.Clear();
            }            
            if (UserInput == "D5")
            {
                CurrEnemy = enemies.enemies[5];
                Console.Clear();
            }
            else if (UserInput == "B")
            {
                MyCode();
            }

            Console.WriteLine($"You've chosen {CurrEnemy}\n"+
                              $"When you're ready, click 'Spacebar'");
            UserInput = Convert.ToString(Console.ReadKey().Key);
            if (UserInput == Convert.ToString(ConsoleKey.Spacebar))
            {
                FightEnemy();
            }

        }

        public void VisitShop()
        {
            Shop.VisitShop(warrior);
        }

        public void FightEnemy()
        {
            Console.Clear();
            while (warrior.IsAlive && CurrEnemy.IsAlive)
            {
                CurrEnemy.EnemyHitPoints -= warrior.DealDamage();
                warrior.HitPoints -= CurrEnemy.DealDamage();
                warrior.IsBelowZero();
                CurrEnemy.IsBelowZero();
                Console.WriteLine($"{warrior.Name} has {warrior.HitPoints} health remaining");
                Console.WriteLine($"{CurrEnemy.EnemyName} has {CurrEnemy.EnemyHitPoints} health remaining");
            }
            if (warrior.IsAlive == false && CurrEnemy.IsAlive == true)
            {
                Console.WriteLine();
                Console.WriteLine($"{warrior.Name} died!\n"+
                                  $"{CurrEnemy.EnemyName} is the winner!\n"+
                                  $"Which means you lost! Unlucky.\n"+
                                  $"\n"+
                                  $"Press any key to continue..");
                Console.ReadKey();
                YouLost();
            }
            else if (warrior.IsAlive == true && CurrEnemy.IsAlive == false)
            {
                Console.WriteLine();
                Console.WriteLine($"{CurrEnemy.EnemyName} died!");
                Console.WriteLine($"{warrior.Name} is the winner!\n" +
                                  $"\n" +
                                  $"Press any key to continue..");
                Console.ReadKey();
                YouWon();
            }
            else if (warrior.IsAlive == false && CurrEnemy.IsAlive == false)
            {
                Console.WriteLine();
                Console.WriteLine("Both fighters died, it's a draw!\n" +
                                  $"\n" +
                                  $"Press any key to continue..");
                Console.ReadKey();
                YouLost();
            }
            
        }

        public void YouWon()
        {
            Console.Clear();
            warrior.Gold += CurrEnemy.GoldReward;
            Console.WriteLine($"Congratulations, you earned {CurrEnemy.GoldReward} gold\n"+
                              $"You now have: {warrior.Gold} gold!\n"+
                              $"\n"+
                              $"Press any key to continue..");
            Console.ReadKey();
            MyCode();
        }

        public void YouLost()
        {
            IsFirstTime = true;
            warrior = new Warrior("name", 500, 1.0, null, null);
            Console.WriteLine($"You've died!\n"+
                              $"To try again, press 'SPACEBAR', otherwise, click any other key to close the program");
            UserInput = Convert.ToString(Console.ReadKey().Key);
            if (UserInput == Convert.ToString(ConsoleKey.Spacebar))
            {
                MyCode();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
