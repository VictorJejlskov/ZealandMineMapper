using System;
using System.Collections.Generic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Weapon : IEquatable<Weapon>
    {

        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int WeaponType { get; set; }
        public int WeaponID { get; set; } = 0;
        public int Price { get; set; }
        private Random _rnd;

        public Weapon(string name, int weaponType, int price, int minDamage, int maxDamage, int weaponID)
        {
            Name = name;
            WeaponType = weaponType;
            Price = price;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            _rnd = new Random();
            WeaponID = weaponID;
        }

        public int DealDamage()
        {
            return _rnd.Next(MinDamage, MaxDamage);
        }


        public bool Equals(Weapon other)
        {
            if (other == null) return false;
            return (this.WeaponID.Equals(other.WeaponID));
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Weapon objAsPart = obj as Weapon;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public int AverageDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }

        public override string ToString()
        {
            return $"{WeaponID} - Name: {Name} and is a {(WeaponType == 1 ? $"One-handed weapon" : $"Two-handed weapon")} - Average damage: {AverageDamage()}\n"+
                   $"    Price: {Price}";
        }
    }
}
