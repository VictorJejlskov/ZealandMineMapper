using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PersonClassTest
{
    class Person
    {
        private string _navn;

        //private int _alder;
        public string Adresse { get; set; }

        public Person(string navn, int alder)
        {
            _navn = navn;
            Alder = alder; 
        }

        public string Navn
        {
            get {return _navn;}
            set {_navn = value;}
        }

        public int Alder {get; set;}
    }
}
