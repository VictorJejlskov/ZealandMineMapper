using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace BigMammaUML3.Models
{
    public class Pizza : MenuItem
    {
        public bool DeepPan { get; set; } = false;
        public string DeepPanDescription { get; set; }
        public Pizza()
        {
            
        }
        public Pizza(bool deepPan, string name, string description, double price):base(name, description, price)
        {
            DeepPan = deepPan;
            if (DeepPan)
            {
                DeepPanDescription = "Deep Pan";
            }
            else
            {
                DeepPanDescription = "Regular";
            }
        }
        public Pizza(bool deepPan, int number, string name, string description, double price) : base(number, name, description, price)
        {
            DeepPan = deepPan;
            if (DeepPan)
            {
                DeepPanDescription = "Deep Pan";
            }
            else
            {
                DeepPanDescription = "Regular";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(DeepPan)}: {DeepPan}";
        }

        public override void UpdateDescription()
        {
            if (DeepPan)
            {
                DeepPanDescription = "Deep Pan";
            }
            else
            {
                DeepPanDescription = "Regular";
            }
        }
    }
}
