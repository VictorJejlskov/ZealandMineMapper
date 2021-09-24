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
            new Enemy(01, "Skeleton", rnd.Next(60,140), Shop.weapons[rnd.Next(1,6)], Shop.weapons[rnd.Next(1,6)]),
            //null = Shop.weapons[1 osv]
            new Enemy(02, "Zombie", rnd.Next(30,61), Shop.weapons[rnd.Next(1,6)], Shop.weapons[rnd.Next(1,6)]),
            new Enemy(03, "Ogre", rnd.Next(80,181), Shop.weapons[rnd.Next(6,11)]),
            new Enemy(04, "Knight", rnd.Next(200,401), Shop.weapons[rnd.Next(6,11)]),
            new Enemy(05, "Troll", rnd.Next(400,1001), Shop.weapons[rnd.Next(6,11)])
        };

    }
}
