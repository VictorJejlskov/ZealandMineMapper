using System;

namespace RolePlayV12
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _hitPoints;
        private int _maxDamage;
        private int _minDamage;
        private double _strength;
        private Random _generator;
        private Sword _sword1;
        private Sword _sword2;
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints, double strength, Sword sword1, Sword sword2)
        {
            _name = name;
            _hitPoints = hitPoints;
            _sword1 = sword1;
            _sword2 = sword2;
        }
        public Warrior(string name, int hitPoints, double strength, Sword sword1)
        {
            _name = name;
            _hitPoints = hitPoints;
            _sword1 = sword1;
        }

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
        }

        public bool Dead
        {
            get { return _hitPoints <= 0; }
        }

        public double Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
        #endregion

        #region Methods
        public void ReceiveDamage(int points)
        {
            _hitPoints = _hitPoints - points;
        }

        public double DealDamage()
        {
            
            if (_sword2 != null)
            {
                return (_sword1.DealDamage() + _sword2.DealDamage())*_strength;
            }
            return _sword1.DealDamage()*_strength;
        }

        public string GetInfo()
        {
                return $"{Name} has {HitPoints} hit points ({(Dead ? "dead" : "alive")})";
        }

        public string WeaponInfo()
        {
            if (_sword2 != null)
            {
                return $"{_name} is using {_sword1.Name} & {_sword2.Name}";
            }

            return $"{_name} is using {_sword1.Name}";
        }

        public void SwapWeapon(Sword sword)
        {
            _sword1 = sword;
        }
        
        #endregion
    }
}