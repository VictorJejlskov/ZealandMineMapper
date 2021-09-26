using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Enemies
    {
        private static Random rnd = new Random();
        public List<Enemy> enemies = new List<Enemy>()
        {
            // ID, NAME, enemyHitPoints, mainHand, offHand, goldReward)
            new Enemy(01, "Skeleton", rnd.Next(180,300), Shop.weapons[rnd.Next(0,4)], Shop.weapons[rnd.Next(0,4)], rnd.Next(10,120)),
            new Enemy(02, "Zombie", rnd.Next(130,200), Shop.weapons[rnd.Next(0,4)], Shop.weapons[rnd.Next(0,4)], rnd.Next(10,120)),
            new Enemy(03, "Ogre", rnd.Next(250,500), Shop.weapons[rnd.Next(5,9)], rnd.Next(10,120)),
            new Enemy(04, "Knight", rnd.Next(400,700), Shop.weapons[rnd.Next(5,9)], rnd.Next(10,120)),
            new Enemy(05, "Troll", rnd.Next(600,1001), Shop.weapons[rnd.Next(5,9)], rnd.Next(10,120))
        };



    }
}
