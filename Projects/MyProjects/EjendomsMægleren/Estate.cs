using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Estate : Property
    {
        public Estate(int propertyID, string propertyType, string propertyAddress, double propertyPrice,
            double propertySize) : base(propertyID, propertyType, propertyAddress, propertyPrice, propertySize)
        {

        }
    }
}
