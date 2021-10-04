using System.Collections.Generic;

namespace RolePlayV21
{
    public class BeastArmy
    {
        private List<Beast> _army;

        public BeastArmy()
        {
            _army = new List<Beast>();
        }

        /// <summary>
        /// Add one Beast to the army 
        /// </summary>
        public void AddBeast(Beast aBeast)
        {
            _army.Add(aBeast);
        }

        /// <summary>
        /// Dead is defined as: All members of the army must be dead
        /// </summary>
        public bool Dead
        {
            get
            {
                foreach (Beast o in _army)
                {
                    if (!o.Dead)
                    {
                        return false;
                    }
                }

                return true;
            } 
        }

        /// <summary>
        /// Returns the names of all Beasts that are currently alive
        /// </summary>
        public List<string> BeastsAlive
        {
            get
            {
                List<string> alive = new List<string>();
                foreach (Beast o in _army)
                {
                    if (!o.Dead)
                    {
                        alive.Add(o.Name);
                    }
                }
                return alive;
            }
        }

        /// <summary>
        /// DealDamage is defined as: 
        /// The total damage dealt by all
        /// non-dead members of the army
        /// </summary>
        public int DealDamage()
        {
            int totalDamage = 0;
            foreach (Beast o in _army)
            {
                if (!o.Dead)
                {
                    totalDamage += o.DealDamage();
                }
            }
            return totalDamage;
        }

        /// <summary>
        /// ReceiveDamage is defined as: 
        /// The first non-dead beast in the list 
        /// receives all of the damage
        /// </summary>
        public void ReceiveDamage(int damage)
        {
            foreach (var o in _army)
            {
                if (!o.Dead)
                {
                    o.ReceiveDamage(damage);
                    return;
                }
            }
        }

        public void BeastReset()
        {
            foreach (Beast o in _army)
            {
                o.Reset();
            }
        }
    }
}
