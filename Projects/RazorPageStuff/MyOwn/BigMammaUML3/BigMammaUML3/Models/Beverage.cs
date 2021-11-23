using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigMammaUML3.Models
{
    public class Beverage : MenuItem
    {
        public bool Alcohol { get; set; }
        public string AlcoholicDescrip { get; }

        public Beverage()
        {
            
        }
        public Beverage(bool alcohol, int number, string name, string description, double price) : base(number, name, description, price)
        {
            Alcohol = alcohol;
            if (Alcohol)
            {
                AlcoholicDescrip = "Alcoholic";
            }
            else
            {
                AlcoholicDescrip = "Non-Alcoholic";
            }
        }


        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Alcohol)}: {Alcohol}";
        }
    }
}
