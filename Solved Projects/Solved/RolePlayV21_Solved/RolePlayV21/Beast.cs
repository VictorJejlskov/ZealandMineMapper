﻿namespace RolePlayV21
{
    /// <summary>
    /// This class implements a simple game character
    /// 1) The character has a certain number of "hit points"
    /// 2) The character can deal damage
    /// 3) The character can receive damage, causing the hit points to decrease
    /// </summary>
    public class Beast
    {
        #region Instance fields

        private string _name;
        private int _hitPoints;
        private int _maxHitPoints;
        private int _minDamage;
        private int _maxDamage;
        private NumberGenerator _generator;
        private BattleLog _log;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a Beast, using references to a random number generator and a battle log
        /// </summary>
        public Beast(NumberGenerator generator, BattleLog log, string name, int maxHitPoints, int minDamage, int maxDamage)
        {
            _generator = generator;
            _log = log;
            _name = name;
            _maxHitPoints = maxHitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Reset();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Checks if the Beast is dead, defined as having 0 or less hit points...
        /// </summary>
        public bool Dead
        {
            get { return (_hitPoints <= 0); }
        }

        /// <summary>
        /// Returns the current number of hit points for the Beast
        /// </summary>
        public int HitPoints
        {
            get { return _hitPoints; }
        }

        /// <summary>
        /// Returns the name of the Beast
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        public int Number
        {
            get { return 666; } // 3:-)
        }
        #endregion

        #region Methods
        /// <summary>
        /// Reset the Beast's state to the original state
        /// </summary>
        public void Reset()
        {
            _hitPoints = _maxHitPoints;
        }

        /// <summary>
        /// Returns the amount of points a Beast deals in damage.
        /// This damage could then be received by another character
        /// </summary>
        public int DealDamage()
        {
            int damage = _generator.Next(_minDamage, _maxDamage);
            string message = $"Beast ({_name}) dealt {damage} damage!";
            _log.Save(message);
            return damage;
        }

        /// <summary>
        /// The Beast receives the amount of damage specified in the parameter.
        /// The number of hit points will decrease accordingly
        /// </summary>
        public void ReceiveDamage(int points)
        {
            _hitPoints = _hitPoints - points;
            string message = $"Beast ({_name}) receives {points} damage, and is down to {_hitPoints} hit points";
            _log.Save(message);

            if (Dead)
            {
                _log.Save($"Beast ({_name}) died!");
            }
        }  
        #endregion
    }
}