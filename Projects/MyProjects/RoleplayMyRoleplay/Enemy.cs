using System;
using System.Collections.Generic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Enemy : IEquatable<Enemy>
    {
        public int EnemyID { get; set; }
        public string EnemyName { get; set; }
        public int EnemyHitPoints { get; set; }
        public Weapon MainHand { get; set; }
        public Weapon OffHand { get; set; }



        public Enemy(int enemyID, string enemyName, int enemyHitPoints, Weapon mainHand, Weapon offHand)
        {
            EnemyID = enemyID;
            EnemyName = enemyName;
            EnemyHitPoints = enemyHitPoints;
            MainHand = mainHand;
            OffHand = offHand;
        }
        public Enemy(int enemyID, string enemyName, int enemyHitPoints, Weapon mainHand)
        {
            EnemyID = enemyID;
            EnemyName = enemyName;
            EnemyHitPoints = enemyHitPoints;
            MainHand = mainHand;
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
    }
}
