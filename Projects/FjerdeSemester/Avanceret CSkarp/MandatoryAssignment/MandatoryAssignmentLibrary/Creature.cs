using MandatoryAssignmentLibrary.Factory;
using MandatoryAssignmentLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MandatoryAssignmentLibrary
{
    /// <summary>
    /// Class used to create a creature.
    /// </summary>
    public class Creature
    {
        private Random _rand { get; set; } = new Random();
        private Logger _log = Logger.GetLogger();
        public int Hitpoints { get; set; }
        public string Name { get; set; }
        public bool IsAlive { get 
            {
                return Hitpoints > 0;
            } 
        }
        private int _damage
        {
            get { return AttackItems.Sum(dmg => dmg.Damage); }
        }
        /// <summary>
        /// Returns an integer based off of the creatures current damage, which is based off of the items the creature holds.
        /// </summary>
        /// <returns>An integer with a small variance</returns>
        public int Hit()
        {
            return _rand.Next(_damage - 5, _damage);
        }
        public List<IAttackItem> AttackItems { get; set; }
        public List<IDefenceItem> DefenceItems { get; set; }
        public Position Position { get; set; } 

        public Creature(int maxX, int maxY)
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);
            var world = configDoc.DocumentElement.SelectSingleNode("Creature");

            Hitpoints = Convert.ToInt32(world.SelectSingleNode("Hitpoints").InnerText);
            Position = new Position(_rand.Next(0, maxX), _rand.Next(0, maxY));
            AttackItems = GenerateAttackItems(configDoc);
            DefenceItems = GenerateDefenceItems(configDoc);
        }
        /// <summary>
        /// Lets the creature add a new item to their armory,
        /// Depending on the itemtype given, it gets added to the corrosponding list.
        /// </summary>
        /// <param name="item">item of type IAttackItem or IDefenceItem</param>
        public void Loot(IItem item)
        {
            switch (item.GetType())
            { 
                case (IAttackItem):
                    AttackItems.Add((AttackItem)item);
                    break;
                case (IDefenceItem):
                    DefenceItems.Add((DefenceItem)item);
                    break;
            }
        }
        /// <summary>
        /// Lets the creature take damage, based on the amount given in the parameter.
        /// Will also log the damage taken and the new hitpoint amount
        /// Checks if the parameter is more than 0, if not, does nothing
        /// </summary>
        /// <param name="damage">int, which controls how much damage the creature is to take</param>
        /// <returns>int with the new hitpoints of the creature.</returns>
        public int ReceiveHit(int damage)
        {
            if(damage > 0 && IsAlive)
            {
                Hitpoints -= damage;
            }
            _log.LogInfo(Name + " was hit for: " + damage + " new health: " + Hitpoints);
            return Hitpoints;

        }
        /// <summary>
        /// Lets the creature generate a new position, mostly used incase two creatures are generated with identical positions.
        /// </summary>
        /// <param name="maxX">Worlds max X</param>
        /// <param name="maxY">Worlds max Y</param>
        public void RerollPosition(int maxX, int maxY)
        {
            Position = new Position(_rand.Next(0, maxX), _rand.Next(0, maxY));
        }
        /// <summary>
        /// Method to generate attack items for the creature, to fill up its weapon list
        /// </summary>
        /// <returns>A list of generated weapons</returns>
        private List<IAttackItem> GenerateAttackItems(XmlDocument configDoc)
        {
            var world = configDoc.DocumentElement.SelectSingleNode("Creature");
            int maxAttackItems = Convert.ToInt32(world.SelectSingleNode("AttackItemLimit").InnerText);

            var attackItems = configDoc.DocumentElement.SelectSingleNode("Weapons").ChildNodes;
            var aItems = new List<IAttackItem>();
            for (int i = 0; i < attackItems.Count; i++)
            {
                var type = attackItems.Item(i).ChildNodes.Item(0).InnerText;
                var dmg = Convert.ToInt32(attackItems.Item(i).ChildNodes.Item(1).InnerText);
                var name = attackItems.Item(i).ChildNodes.Item(2).InnerText;
                aItems.Add(WeaponFactory.Create(type, dmg, name));
            }
            Random rnd = new Random();
            List<IAttackItem> items = new List<IAttackItem>();
            for (int i = 0; i < maxAttackItems; i++)
            {
                items.Add(aItems[rnd.Next(0, aItems.Count-1)]);
            }
            return items;
        }
        /// <summary>
        /// Method to generate defence items for the creature, to fill up its defence list
        /// </summary>
        /// <returns>A list of generated defence items</returns>
        private List<IDefenceItem> GenerateDefenceItems(XmlDocument configDoc)
        {
            var world = configDoc.DocumentElement.SelectSingleNode("Creature");
            int maxDefenceItems = Convert.ToInt32(world.SelectSingleNode("DefenceItemLimit").InnerText);
            var defenceItems = configDoc.DocumentElement.SelectSingleNode("Armor").ChildNodes;
            var dItems = new List<IDefenceItem>();
            for (int i = 0; i < defenceItems.Count; i++)
            {
                var name = defenceItems.Item(i).ChildNodes.Item(0).InnerText;
                var value = Convert.ToInt32(defenceItems.Item(i).ChildNodes.Item(1).InnerText);
                dItems.Add(new DefenceItem(name, value));
            }
            Random rnd = new Random();
            List<IDefenceItem> items = new List<IDefenceItem>();
            for (int i = 0; i < maxDefenceItems; i++)
            {
                items.Add(dItems[rnd.Next(0, dItems.Count - 1)]);
            }
            return items;
        }

        public override string ToString()
        {
            return $"{{{nameof(Hitpoints)}={Hitpoints.ToString()}, {nameof(Name)}={Name}, {nameof(IsAlive)}={IsAlive.ToString()}}}";
        }
    }
}
