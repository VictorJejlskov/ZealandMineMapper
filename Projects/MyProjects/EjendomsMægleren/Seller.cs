using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Seller
    {
        public int SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerAddress { get; set; }
        public string SellerNumber { get; set; }
        public string SellerEmail { get; set; }

        public Seller(int sellerId, string sellerName, string sellerAddress, string sellerNumber, string sellerEmail)
        {
            SellerID = sellerId;
            SellerName = sellerName;
            SellerAddress = sellerAddress;
            SellerNumber = sellerNumber;
            SellerEmail = sellerEmail;
        }
    }
}
