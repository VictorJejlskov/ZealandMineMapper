using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Buyer : Person
    {
        public double BuyerMinSize { get; set; }
        public double BuyerMaxPrice { get; set; }

        public Buyer(int personID, string personName, string personAddress, string personNumber, string personEmail, double buyerMinSize, double buyerMaxPrice, PersonTypes personType) : base(personID, personName, personAddress, personNumber, personEmail, personType)
        {
            BuyerMinSize = buyerMinSize;
            BuyerMaxPrice = buyerMaxPrice;
        }

        public override string ToString()
        {
            return $"{PersonID}. {PersonName}\n" +
                   $"Address: {PersonAddress}\n" +
                   $"Telephone #: {PersonNumber}\n" +
                   $"Email: {PersonEmail}\n" +
                   $"Minimum Size: {BuyerMinSize} & Max Price: {BuyerMaxPrice}";
        }
    }
}
