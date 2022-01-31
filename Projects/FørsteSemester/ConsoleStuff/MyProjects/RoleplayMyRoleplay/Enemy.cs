using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Enemy : IEquatable<Enemy>
    {
        public int EnemyID { get; set; }
        public string EnemyName { get; set; }
        public int GoldReward { get; set; }
        public int EnemyHitPoints { get; set; }
        public Weapon MainHand { get; set; }
        public Weapon OffHand { get; set; }
        public bool IsAlive { get; set; }
        public static Random rnd = new Random();


        //Main & offhand enemy constructor
        public Enemy(int enemyID, string enemyName, int enemyHitPoints, Weapon mainHand, Weapon offHand, int goldReward)
        {
            EnemyID = enemyID;
            EnemyName = enemyName;
            EnemyHitPoints = enemyHitPoints;
            MainHand = mainHand;
            OffHand = offHand;
            GoldReward = goldReward;
            IsAlive = true;
        }
        
        //Two-handed enemy constructor
        public Enemy(int enemyID, string enemyName, int enemyHitPoints, Weapon mainHand, int goldReward)
        {
            EnemyID = enemyID;
            EnemyName = enemyName;
            EnemyHitPoints = enemyHitPoints;
            MainHand = mainHand;
            GoldReward = goldReward;
            IsAlive = true;
        }



        public bool Equals(Enemy other)
        {
            if (other == null) return false;    
            return (this.EnemyID.Equals(other.EnemyID));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Weapon objAsPart = obj as Weapon;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public int DealDamage()
        {
            if (OffHand != null)
            {
                return (MainHand.DealDamage() + OffHand.DealDamage());
            }
            return MainHand.DealDamage();
        }

        public void IsBelowZero()
        {
            if (EnemyHitPoints <= 0)
            {
                EnemyHitPoints = 0;
                IsAlive = false;
            }
        }

        public override string ToString()
        {
            if (OffHand != null)
            {
                return $"{EnemyID}-{EnemyName} - HP: {EnemyHitPoints}\n" +
                       $"Is currently holding {MainHand.Name} & {OffHand.Name}\n"+
                       $"This enemy is worth {GoldReward} gold to kill\n"+
                       $"";

            }
            return $"{EnemyID}-{EnemyName} - HP: {EnemyHitPoints}\n"+
                   $"Is currently holding {MainHand.Name}\n" +
                   $"This enemy is worth {GoldReward} gold to kill\n" +
                   $"";
        }
    }
}
