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
        public int WeaponID { get; set; }
        public int Price { get; set; }
        private Random _rnd;

        public Weapon(string name, int weaponType, int price, int weaponID, int minDamage, int maxDamage)
        {
            Name = name;
            WeaponType = weaponType;
            Price = price;
            WeaponID = weaponID;
            MinDamage = minDamage;
            MaxDamage = maxDamage;

            _rnd = new Random();
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

    }
}
