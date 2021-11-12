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

            BuyerCatalogue.AddBuyer(newBuyer1);
            BuyerCatalogue.AddBuyer(newBuyer2);
            BuyerCatalogue.AddBuyer(newBuyer3);
            BuyerCatalogue.AddBuyer(newBuyer4);
            BuyerCatalogue.AddBuyer(newBuyer5);
            BuyerCatalogue.AddBuyer(newBuyer6);
            BuyerCatalogue.AddBuyer(newBuyer7);
            BuyerCatalogue.AddBuyer(newBuyer8);
            BuyerCatalogue.AddBuyer(newBuyer9);
            BuyerCatalogue.AddBuyer(newBuyer10);

            Property newApartment1 = new Apartment(1, Property.PropertyTypes.Apartment, "Apartment 1", 25000, 20);
            Property newApartment2 = new Apartment(2, Property.PropertyTypes.Apartment, "Apartment 2", 35000, 25);
            Property newApartment3 = new Apartment(3, Property.PropertyTypes.Apartment, "Apartment 3", 45000, 30);
            Property newApartment4 = new Apartment(4, Property.PropertyTypes.Apartment, "Apartment 4", 55000, 40);
            Property newApartment5 = new Apartment(5, Property.PropertyTypes.Apartment, "Apartment 5", 65000, 45);
            Property newApartment6 = new Apartment(6, Property.PropertyTypes.Apartment, "Apartment 6", 75000, 50);

            Property newEstate1 = new Estate(7, Property.PropertyTypes.Estate, "Estate 1", 25000, 20);
            Property newEstate2 = new Estate(8, Property.PropertyTypes.Estate, "Estate 2", 35000, 25);
            Property newEstate3 = new Estate(9, Property.PropertyTypes.Estate, "Estate 3", 45000, 45);
            Property newEstate4 = new Estate(10, Property.PropertyTypes.Estate, "Estate 4", 55000, 35);
            Property newEstate5 = new Estate(11, Property.PropertyTypes.Estate, "Estate 5", 65000, 40);
            Property newEstate6 = new Estate(12, Property.PropertyTypes.Estate, "Estate 6", 75000, 50);

            PropertyCatalogue.AddProperty(newApartment1);
            PropertyCatalogue.AddProperty(newApartment2);
            PropertyCatalogue.AddProperty(newApartment3);
            PropertyCatalogue.AddProperty(newApartment4);
            PropertyCatalogue.AddProperty(newApartment5);
            PropertyCatalogue.AddProperty(newApartment6);

            PropertyCatalogue.AddProperty(newEstate1);
            PropertyCatalogue.AddProperty(newEstate2);
            PropertyCatalogue.AddProperty(newEstate3);
            PropertyCatalogue.AddProperty(newEstate4);
            PropertyCatalogue.AddProperty(newEstate5);
            PropertyCatalogue.AddProperty(newEstate6);



            Property propTest1 = new Property();

        }
    }
}
