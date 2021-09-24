using System;
using System.Collections.Generic;
using System.Text;

namespace RoleplayMyRoleplay
{
    class Shop
    {

        public static List<Weapon> weapons { get; set; }= new List<Weapon>()
        {
            new Weapon("Lille Økse", 1, 50, 01, 20, 30),
            new Weapon("Dagger", 1, 50, 02, 15, 30),
            new Weapon("Shortsword", 1, 50, 03, 10, 30),
            new Weapon("Stick", 1, 1, 04, 1, 5),
            new Weapon("Club", 1, 30, 05, 10, 20),
            new Weapon("2-Hånds sværd", 2, 200, 06, 50,100),
            new Weapon("Halberd", 2, 400, 07, 75,85),
            new Weapon("Spear", 2,150,08,50,70),
            new Weapon("Mace", 2,250,09,70,80),
            new Weapon("Sledgehammer", 2, 1000,10,100,160)

        };

        public List<Weapon> MyWeapons
        {
            get { return weapons; }
        }


        //public List<Weapon> weapons = new List<Weapon>()
        //{
        //    new Weapon("Lille Økse", 1, 50, 0001, 10, 30),
        //    new Weapon("2-Hånds sværd", 2, 200, 0002, 50,100),
        //    new Weapon("Halberd", 2, 400, 0003, 75,85),
        //    new Weapon("Club", 1, 30, 0004, 10, 20)
        //};
    }

}
