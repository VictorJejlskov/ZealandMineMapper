using System;

namespace EjendomsMægleren
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.StartUp();
            Buyer currBuyer = null;
            if (BuyerDictionary.BuyerDic.ContainsKey(1))
            {
                currBuyer = BuyerDictionary.BuyerDic[1];
            }

            Console.WriteLine(currBuyer);
        }
    }
}
