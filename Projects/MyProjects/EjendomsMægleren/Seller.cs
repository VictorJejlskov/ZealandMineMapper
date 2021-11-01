using System;
using System.Collections.Generic;
using System.Text;

namespace EjendomsMægleren
{
    class Seller : Person
    {

        public Seller(int personID, string personName, string personAddress, string personNumber, string personEmail, PersonTypes personType) : base(personID, personName, personAddress, personNumber, personEmail, personType)
        {

        }
    }
}
