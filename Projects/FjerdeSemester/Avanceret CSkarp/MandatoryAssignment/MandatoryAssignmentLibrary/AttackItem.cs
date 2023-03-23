using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MandatoryAssignmentLibrary
{
    public class AttackItem : Item
    {
        public int Damage { get; set; }
        public int Range { get; set; }
        public AttackItem(string name, int damage, int range) : base(name)
        {
            Damage = damage;
            Range = range;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
