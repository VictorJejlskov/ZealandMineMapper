using System;
using System.Collections.Generic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Warrior
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Gold { get; set; }
        public double StrengthBonus { get; set; }
        public bool IsAlive { get; set; }
        private Random _rnd;
        public Weapon MainHandWeapon { get; set; }
        public Weapon OffHandWeapon { get; set; }



        public Warrior(string name, int hitPoints, double strengthBonus, Weapon mainHand, Weapon offHand)
        {
            Name = name;
            HitPoints = hitPoints;
            StrengthBonus = strengthBonus;
            MainHandWeapon = mainHand;
            OffHandWeapon = offHand;
            IsAlive = true;
        }

        public void RecieveDamage(int points)
        {
            HitPoints -= points;
        }

        public int DealDamage()
        {
            if (OffHandWeapon != null)
            {
                return Convert.ToInt32((MainHandWeapon.DealDamage() + OffHandWeapon.DealDamage()) * StrengthBonus);
            }
            return Convert.ToInt32(MainHandWeapon.DealDamage() * StrengthBonus);
        }

        public void IsBelowZero()
        {
            if (HitPoints <= 0)
            {
                HitPoints = 0;
                IsAlive = false;
            }
        }

        public override string ToString()
        {
            if (OffHandWeapon != null)
            {
                return $"Your name: {Name}\n" +
                       $"Current hitpoints: {HitPoints}\n" +
                       $"Current weapons: {MainHandWeapon.Name}({MainHandWeapon.AverageDamage()}) & {OffHandWeapon.Name}({OffHandWeapon.AverageDamage()})\n"+
                       $"Current gold: {Gold}";

            }
            return $"Your name: {Name}\n" +
                   $"Current hitpoints: {HitPoints}\n" +
                   $"Current weapon: {MainHandWeapon.Name}({MainHandWeapon.AverageDamage()})\n"+
                   $"Current gold: {Gold}";
        }
    }
}
