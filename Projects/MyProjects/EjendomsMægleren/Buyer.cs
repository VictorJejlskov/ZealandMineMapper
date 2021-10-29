using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Buyer
    {
        public int BuyerID { get; set; }
        public string BuyerName { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerNumber { get; set; }
        public string BuyerEmail { get; set; }
        public double BuyerMinSize { get; set; }
        public double BuyerMaxPrice { get; set; }

        public Buyer(int buyerID, string buyerName, string buyerAddress, string buyerNumber, string buyerEmail,
            double buyerMinSize, double buyerMaxPrice)
        {
            BuyerID = buyerID;
            BuyerName = buyerName;
            BuyerAddress = buyerAddress;
            BuyerNumber = buyerNumber;
            BuyerEmail = buyerEmail;
            BuyerMinSize = buyerMinSize;
            BuyerMaxPrice = buyerMaxPrice;
        }

        public override string ToString()
        {
            return $"{BuyerID}. {BuyerName}\n" +
                   $"Address: {BuyerAddress}\n" +
                   $"Telephone #: {BuyerNumber}\n" +
                   $"Email: {BuyerEmail}\n" +
                   $"Minimum Size: {BuyerMinSize} & Max Price: {BuyerMaxPrice}";
        }
    }
}
