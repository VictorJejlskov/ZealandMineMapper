using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class BuyerDictionary
    {
        public static Dictionary<int, Buyer> BuyerDic = new Dictionary<int, Buyer>()
        {

        };

        public static void AddToDictionary(Buyer newBuyer)
        {
            BuyerDic.Add(newBuyer.PersonID, newBuyer);
        }
    }
}
