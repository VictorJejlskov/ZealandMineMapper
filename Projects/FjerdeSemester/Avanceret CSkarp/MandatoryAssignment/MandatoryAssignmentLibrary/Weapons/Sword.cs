﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary.Weapons
{
    public class Sword : AttackItem
    {
        public Sword(int damage, string name) : base(damage, name) { }
        public override string ToString()
        {
            return $"{{{nameof(Damage)}={Damage.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
