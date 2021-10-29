using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Apartment : Property
    {

        public int Rooms { get; set; }
        public Apartment(int propertyID, string propertyType, string propertyAddress, double propertyPrice,
            double propertySize) : base(propertyID, propertyType, propertyAddress, propertyPrice, propertySize)
        {

        }
    }
}
