using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class BuyerCatalogue
    {
        public static List<Buyer> BuyerList = new List<Buyer>();

        public static void AddBuyer(Buyer inputBuyer)
        {
            BuyerList.Add(inputBuyer);
        }

        public static void RemoveBuyer(Buyer inputBuyer)
        {
            BuyerList.Remove(inputBuyer);
        }

        public static void PrintBuyer()
        {
            foreach (Buyer buyer in BuyerList)
            {
                Console.WriteLine(buyer);
            }
        }

        public static Buyer Get(int input)
        {
            return BuyerList[input];
        }
    }
}
