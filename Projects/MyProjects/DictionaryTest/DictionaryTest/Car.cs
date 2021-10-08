using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml.Schema;

namespace DictionaryTest
{
    class Car
    {
        public string Ejer{ get; set; }
        public int ProductionYear { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }

        public Car(string ejer, int productionYear, string brand, string model, string licensePlate)
        {
            Ejer = ejer;
            ProductionYear = productionYear;
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
        }

        public override string ToString()
        {
            return
                $"Nummerpladen: {LicensePlate}\n{Ejer}\nÅrstal: {ProductionYear}\n{Brand} - {Model}\n";
        }
    }
}