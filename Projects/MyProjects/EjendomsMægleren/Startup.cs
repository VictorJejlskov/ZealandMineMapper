using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Startup
    {
        public static void StartUp()
        {
            Buyer newBuyer1 = new Buyer(1, "Søren Hansen", "Skovvejen 23, 3200 Helsinge", "+4581611117",
                "SørenHansen@gmail.com", 25.0, 500000, Person.PersonTypes.Buyer);
            Buyer newBuyer2 = new Buyer(2, "Jens Jensen", "vejsende 24, 4500 Århus", "+4513141516", "JensJensen@gmail.com", 30.0, 400000, Person.PersonTypes.Buyer);
            Buyer newBuyer3 = new Buyer(3, "Dorte Pedersen", "Pikhedevej 69, 6900 Odense", "+4569696969",
                "DortePedersen@gmail.com", 69.0, 696969, Person.PersonTypes.Buyer);
            Buyer newBuyer4 = new Buyer(4, "Morten Dorph", "Lossepladsvej 30, 6300 Kalundborg", "+4513141516",
                "MortenDorph@gmail.com", 45.0, 600000, Person.PersonTypes.Buyer);
            Buyer newBuyer5 = new Buyer(5, "Jesper Christiansen", "Syrefabriksvej 35, 8900 Lolland", "+4546382818",
                "JesperChristiansen@gmail.com", 120, 1300000, Person.PersonTypes.Buyer);
            Buyer newBuyer6 = new Buyer(6, "Pernille Andersen", "Rensdýrhaven 55, 7700 Thisted", "+4543567898",
                "PernilleAndersen@gmail.com", 49.0, 650000, Person.PersonTypes.Buyer);
            Buyer newBuyer7 = new Buyer(7, "Jørgen Jensen", "Fyrrehuset 4, 7900 Nykøbing M.", "+4534678907",
                "JørgenJensen@gmail.com", 71.0, 750000, Person.PersonTypes.Buyer);
            Buyer newBuyer8 = new Buyer(8, "Karl Emil", "Kastanje 45, 9000 AAlborg", "+4565897612",
                "KarlEmil@gmail.com", 40.0, 350000, Person.PersonTypes.Buyer);
            Buyer newBuyer9 = new Buyer(9, "Børge Lundberg", "Heksebo 67, 9300 Sæby", "+4532456798",
                "BørgeLundberg@gmail.com", 80, 950000, Person.PersonTypes.Buyer);
            Buyer newBuyer10 = new Buyer(10, "Henriette Carlsen", "Bøgehuset 1,9320 Hjallerup", "+4511235678",
                "HenrietteCarlsen@gmail.com", 35.0, 555000, Person.PersonTypes.Buyer);
            BuyerDictionary.AddToDictionary(newBuyer1);
            BuyerDictionary.AddToDictionary(newBuyer2);
            BuyerDictionary.AddToDictionary(newBuyer3);
            BuyerDictionary.AddToDictionary(newBuyer4);
            BuyerDictionary.AddToDictionary(newBuyer5);
            BuyerDictionary.AddToDictionary(newBuyer6);
            BuyerDictionary.AddToDictionary(newBuyer7);
            BuyerDictionary.AddToDictionary(newBuyer8);
            BuyerDictionary.AddToDictionary(newBuyer9);
            BuyerDictionary.AddToDictionary(newBuyer10);
        }
    }
}
