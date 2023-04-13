using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignmentLibrary.Interfaces;

namespace MandatoryAssignmentLibrary
{
    public abstract class AttackItem : IAttackItem
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        

        protected AttackItem(int damage, string name)
        {
            Damage = damage;
            Name = name;
        }

        public AttackItem()
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
