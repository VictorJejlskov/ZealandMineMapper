using System;
// ReSharper disable UnusedVariable
#pragma warning disable 219

namespace WebShopV06
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            bool receiveSpecialOffer1;
            bool receiveSpecialOffer2;
            bool receiveSpecialOffer3;
            bool receiveSpecialOffer4;

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 0;
            int noOfDVDsInOrder = 0;
            int noOfGamesInOrder = 0;

            Console.WriteLine("How many books do you want to buy at a rate of 30dkk each?");
            noOfBooksInOrder = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How many DVDs do you want to buy at a rate of 30dkk each?");
            noOfDVDsInOrder = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How many games do you want to buy at a rate of 30dkk each?");
            noOfGamesInOrder = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            double totalNetPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;

            // SO#1
            if (totalNetPrice > 1000)
            {
                receiveSpecialOffer1 = true;
            }
            else
            {
                receiveSpecialOffer1 = false;
            }


            // SO#2
            if (noOfBooksInOrder > noOfGamesInOrder)
            {
                receiveSpecialOffer2 = true;
            }
            else
            {
                receiveSpecialOffer2 = false;
            }


            // SO#3
            if (noOfBooksInOrder > 10 || noOfDVDsInOrder > 10 || noOfGamesInOrder > 10)
            {
                receiveSpecialOffer3 = true;
            }
            else
            {
                receiveSpecialOffer3 = false;
            }
            

            // SO#4
            if(noOfDVDsInOrder > 10 && noOfDVDsInOrder < 21 || noOfGamesInOrder > 6)
            {
                receiveSpecialOffer4 = true;
            }
            else
            {
                receiveSpecialOffer4 = false;
            }

            Console.Clear();
            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"You spent a total of: " + totalNetPrice + "dkk");
            Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
            Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
            Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
            Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");

            // The LAST line of code should be ABOVE this line
        }
    }
}