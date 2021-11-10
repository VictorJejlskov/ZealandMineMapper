using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 0;
            int noOfDVDsInOrder = 0;
            int noOfGamesInOrder = 0;

            double totalPrice = 0.0; // This variable should contain the total price for the order
            double netPrice = 0.0;
            double taxPercent = 1.1;
            int shippingCost = 49;
            double creditCardFee = 1.02;

            Console.WriteLine("How many books do you want to buy at a rate of 30dkk each?");
            noOfBooksInOrder = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How many DVDs do you want to buy at a rate of 30dkk each?");
            noOfDVDsInOrder = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How many games do you want to buy at a rate of 30dkk each?");
            noOfGamesInOrder = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            netPrice = (netPriceBook * noOfBooksInOrder) + (netPriceDVD * noOfDVDsInOrder) +
                         (netPriceGame * noOfGamesInOrder);
            totalPrice = (((netPrice * taxPercent) + 49) * creditCardFee);
            

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}