using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary
{
    public class Creature
    {
        public int Hitpoints { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public List<AttackItem> AttackItems { get; set; } 
        public List<DefenceItem> DefenceItems { get; set; }
        private Logger _logger;
        private int _currentDamage
        {
            get
            {
                return AttackItems.Sum(x => x.Damage);
            }
        }
        public bool isAlive
        {
            get
            {
                return Hitpoints > 0;
            }
        }
        

        public Creature()
        {
            _logger = new Logger("CreatureLog");
            AttackItems = new List<AttackItem>();
            DefenceItems = new List<DefenceItem>();
            
            _logger.LogInfo(ToString());
        }

        public Creature(string name, int hitPoints, Position position, List<AttackItem>? attackItems, List<DefenceItem>? defenceItems)
        {
            _logger = new Logger("CreatureLog");
            Hitpoints = hitPoints;
            Name = name;
            Position = position;
            AttackItems = attackItems == null ? new List<AttackItem>() : attackItems;
            DefenceItems = defenceItems == null ? new List<DefenceItem>() : defenceItems;
            _logger.LogInfo(ToString());
        }





        public int Hit()
        {
            _logger.LogInfo($"{Name} has dealt {_currentDamage} damage");
            return _currentDamage;
        }
        public void Loot(Item item)
        {
            if(item is AttackItem)
            {
                AttackItems.Add((AttackItem)item);
                _logger.LogInfo($"AttackItem: {item.Name} has been added");
            }
            else if (item is DefenceItem)
            {
                DefenceItems.Add((DefenceItem)item);
                _logger.LogInfo($"DefenceItem: {item.Name} has been added");
            }
        }
        public int ReceiveHit(int damage)
        {
            int defenceValue = DefenceItems.Sum(item => item.DefenceValue);
            int totalDamage = damage - defenceValue;
            Hitpoints -= damage;
            string theResult = isAlive ? $"has {Hitpoints} left." : "is dead.";
            _logger.LogInfo($"{Name}" + theResult);
            return Hitpoints;
        }

        public override string ToString()
        {
            var tostring = $"{Name}, {Hitpoints}, {Position}, {(isAlive ? "Alive" : "Dead")}, ";
            if (AttackItems.Count != 0)
            {
                tostring += "Weapons: [";
                AttackItems.ForEach(item => tostring += item + ", ");
                tostring = tostring.Remove(tostring.Length - 2, 2);
                tostring += "], ";
            }
            if (DefenceItems.Count != 0)
            {
                tostring += "Armor: [";
                DefenceItems.ForEach(item => tostring += item + ", ");
                tostring = tostring.Remove(tostring.Length - 2, 2);
                tostring += "] ";
            }
            return tostring;
        }
    }
}
