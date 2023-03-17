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
        public int HitPoints { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public List<AttackItem> AttackItems { get; set; } 
        public List<DefenceItem> DefenceItems { get; set; }
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
                return HitPoints > 0;
            }
        }
        public TraceSource ts = new TraceSource("Creature Log", SourceLevels.All);

        public Creature()
        {
            InitializeTrace();
            AttackItems = new List<AttackItem>();
            DefenceItems = new List<DefenceItem>();
            Log(this.ToString());
        }

        public Creature(string name, int hitPoints, Position position, List<AttackItem>? attackItems, List<DefenceItem>? defenceItems)
        {
            InitializeTrace();
            HitPoints = hitPoints;
            Name = name;
            Position = position;
            AttackItems = attackItems == null ? new List<AttackItem>() : attackItems;
            DefenceItems = defenceItems == null ? new List<DefenceItem>() : defenceItems;
            Log(this.ToString());
        }

        public void InitializeTrace()
        {
            ts.Switch = new SourceSwitch("Creature Log", "All");
            TraceListener tl = new ConsoleTraceListener();
            ts.Listeners.Add(tl);
        }



        public int Hit()
        {
            Log($"{Name} has dealt {_currentDamage} damage");
            return _currentDamage;
        }
        public void Loot(Item item)
        {
            if(item is AttackItem)
            {
                AttackItems.Add((AttackItem)item);
                Log($"AttackItem: {item.Name} has been added");
            }
            else if (item is DefenceItem)
            {
                DefenceItems.Add((DefenceItem)item);
                Log($"DefenceItem: {item.Name} has been added");
            }
        }
        public int ReceiveHit(int damage)
        {
            int defenceValue = DefenceItems.Sum(item => item.DefenceValue);
            int damageTaken = damage - defenceValue;
            HitPoints -= damageTaken;
            if (HitPoints > 0)
            {
                Log($"{Name} has taken {damageTaken} damage, remaining health: {HitPoints}");
                return HitPoints;
            }
            else
            {
                Log($"{Name} has taken {damageTaken} damage, {Name} is dead.");
                return HitPoints;
            }
            
        }
        private void Log(string msg)
        {
            ts.TraceEvent(TraceEventType.Information, 1, msg);
        }

        public override string ToString()
        {
            return $"{{{nameof(HitPoints)}={HitPoints.ToString()}, {nameof(Name)}={Name}, {nameof(Position)}={Position}, {nameof(isAlive)}={isAlive.ToString()}}}";
        }
    }
}
