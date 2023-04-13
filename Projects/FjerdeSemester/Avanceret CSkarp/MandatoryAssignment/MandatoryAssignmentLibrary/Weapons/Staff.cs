﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace MandatoryAssignmentLibrary.Weapons
{
    public class Staff : AttackItem
    {
        public Staff(int damage, string name) : base(damage, name) { }

        public override string ToString()
        {
            return $"{{{nameof(Damage)}={Damage.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
