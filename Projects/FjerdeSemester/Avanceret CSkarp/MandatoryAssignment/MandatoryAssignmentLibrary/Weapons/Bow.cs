﻿using MandatoryAssignmentLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary.Weapons
{
    public class Bow : AttackItem
    {
        public Bow(int damage, string name) : base(damage, name) 
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Damage)}={Damage.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
