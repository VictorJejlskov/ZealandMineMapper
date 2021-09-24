using System;
using System.Collections.Generic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Warrior
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public double StrengthBonus { get; set; }
        public bool IsDead { get { return HitPoints <= 0; } }
        private Random _rnd;
        private Weapon _mainHand;
        private Weapon _offHand;



        public Warrior(string name, int hitPoints, double strengthBonus, Weapon mainHand, Weapon offHand)
        {
            Name = name;
            HitPoints = hitPoints;
            StrengthBonus = strengthBonus;
            _mainHand = mainHand;
            _offHand = offHand;
        }

        public void RecieveDamage(int points)
        {
            HitPoints -= points;
        }

        public double DealDamage()
        {
            if (_offHand != null)
            {
                return (_mainHand.DealDamage() + _offHand.DealDamage()) * StrengthBonus;
            }
            return _mainHand.DealDamage() * StrengthBonus;
        }
    }
}
