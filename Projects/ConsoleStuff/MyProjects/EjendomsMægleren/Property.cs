using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    public class Property
    {
        public int PropertyID { get; set; }

        public enum PropertyTypes
        {
            Apartment, Estate, Mansion
        }
        public PropertyTypes PropertyType { get; set; }
        public string PropertyAddress { get; set; }
        public double PropertyPrice { get; set; }
        public double PropertySize { get; set; }

        public Property(int propertyID, PropertyTypes propertyType, string propertyAddress, double propertyPrice,
            double propertySize)
        {
            PropertyID = propertyID;
            PropertyType = propertyType;
            PropertyAddress = propertyAddress;
            PropertyPrice = propertyPrice;
            PropertySize = propertySize;
        }

        public override string ToString()
        {
            return $"{PropertyID}. {PropertyType}-{PropertySize}, {PropertyAddress} - {PropertyPrice}dkk";
        }
    }
}
