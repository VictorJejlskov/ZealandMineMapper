using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonAddress { get; set; }
        public string PersonNumber { get; set; }
        public string PersonEmail { get; set; }

        public enum PersonTypes
        {
            Buyer, Seller
        };
        public PersonTypes PersonType { get; set; }



        public Person(int personID, string personName, string personAddress, string personNumber, string personEmail, PersonTypes personType)
        {
            PersonID = personID;
            PersonName = personName;
            PersonAddress = personAddress;
            PersonNumber = personNumber;
            PersonEmail = personEmail;
            PersonType = personType;

        }
    }
}
