using System;

namespace RolePlayV11
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _level;
        private int _hitpoints;
        private bool _isAlive;
        #endregion

        #region Constructor
        public Warrior(string name, int hitpoints, bool isAlive)
        {
            _name = name;
            _hitpoints = hitpoints;
            _level = 1;
            _isAlive = true;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Hitpoints
        {
            get { return _hitpoints; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
        }
        
        public int Level
        {
            get { return _level; }
        }


        static Random rnd = new Random();
        public void DealDamage()
        {
            int damageNumber = rnd.Next(1, 31);
            _hitpoints = _hitpoints - damageNumber;
        }


        public void IsBelowZero()
        {
            if (Hitpoints <= 0)
            {
                _hitpoints = 0;
                _isAlive = false;
            }
        }
        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }
        #endregion
    }
}