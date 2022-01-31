using System;
using System.Collections.Generic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Shop
    {
        public static List<Weapon> weapons { get; set; }= new List<Weapon>()
        {
            //name, weaponType, price, minDamage, maxDamage, ID (0-9))
            new Weapon("Stick", 1, 1, 1, 5, 0),
            new Weapon("Dagger", 1, 50, 12, 15, 1),
            new Weapon("Club", 1, 30, 10, 20, 2),
            new Weapon("Shortsword", 1, 50, 10, 30, 3),
            new Weapon("Lille Økse", 1, 50, 20, 30, 4),
            new Weapon("2-Hånds sværd", 2, 200, 50,100, 5),
            new Weapon("Halberd", 2, 400, 75,85, 6),
            new Weapon("Spear", 2,150,50,70, 7),
            new Weapon("Mace", 2,250,70,80, 8),
            new Weapon("Sledgehammer", 2, 1000,100,160, 9)
        };

        public List<Weapon> MyWeapons
        {
            get { return weapons; }
        }

        public void VisitShop(Warrior warrior)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the shop!\n" +
                              $"Take a look around, to buy something, click on the respective button\n" +
                              $"Your current gold: {warrior.Gold} & your current hitpoints: {warrior.HitPoints}\n" +
                              $"Your current weapon(s): {(warrior.OffHandWeapon != null ? $"{warrior.MainHandWeapon.Name} & {warrior.OffHandWeapon.Name}" : $"{warrior.MainHandWeapon.Name}")}\n" +
                              $"\n" +
                              $"H: Healthpotion 80g - Heals you for 100 hitpoints, to a max of 500\n" +
                              $"G: Strength Potion 400g - Gives you 50% more damage done for the next 3 fights\n"+
                              $"Or click 'SPACEBAR' to go back.\n");


            foreach (Weapon wep in weapons)
            {
                Console.WriteLine(wep);
            }
            
        }

        public void HealthPotion(Warrior warrior)
        {
            if (warrior.Gold >= 80)
            {
                warrior.Gold -= 80;
                if (warrior.HitPoints <= 499)
                {
                    warrior.HitPoints += 100;
                    if (warrior.HitPoints > 500)
                    {
                        warrior.HitPoints = 500;
                    }
                }
            }
            else if (warrior.Gold < 80)
            {
                Console.Clear();
                Console.WriteLine("Sorry, you're too poor.");
                Console.ReadKey();
            }
        }

        public void StrengthPotion(Warrior warrior)
        {
            if (warrior.Gold >= 400)
            {
                warrior.Gold -= 400;
                warrior.StrengthBonus = 1.5;
                warrior.StrengthBonusDuration = 3;
            }
            else if (warrior.Gold < 400)
            {
                Console.Clear();
                Console.WriteLine("Sorry, you're too poor.");
                Console.ReadKey();
            }
        }

        public void BuyWeapon(Weapon weapon, Warrior warrior)
        {
            if (weapon.WeaponType == 1 && warrior.Gold >= weapon.Price)
            {
                if (warrior.OffHandWeapon != null)
                {
                    Console.Clear();
                    Console.WriteLine($"Do you want to replace: \n"+
                                      $"1: {warrior.MainHandWeapon.Name} ({warrior.MainHandWeapon.AverageDamage()})"+
                                      $"2: {warrior.OffHandWeapon.Name} ({warrior.OffHandWeapon.AverageDamage()})");
                    string userInput = Convert.ToString(Console.ReadKey());
                    if (userInput == "D1")
                    {
                        warrior.MainHandWeapon = weapon;
                    }
                    if (userInput == "D2")
                    {
                        warrior.OffHandWeapon = weapon;
                    }

                    Console.ReadKey();
                    warrior.Gold -= weapon.Price;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"You've equipped {weapon.Name} in your offhand");
                    Console.ReadKey();
                    warrior.OffHandWeapon = weapon;
                    warrior.Gold -= weapon.Price;
                }

                Console.ReadKey();
            }
            else if (weapon.WeaponType == 2 && warrior.Gold >= weapon.Price)
            {
                Console.Clear();
                Console.WriteLine($"You've equipped {weapon.Name} ({weapon.AverageDamage()}), replacing your weapon(s)");
                Console.ReadKey();
                warrior.Gold -= weapon.Price;
                warrior.MainHandWeapon = weapon;
                warrior.OffHandWeapon = null;
            }
            else if (warrior.Gold < weapon.Price)
            {
                Console.Clear();
                Console.WriteLine("Sorry, you're too poor.");
                Console.ReadKey();
            }
        }
    }

}
