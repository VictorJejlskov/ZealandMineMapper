using System;
using System.Collections.Generic;
using System.Text;

namespace Cykel
{
    class Cykel
    {
        private string _brand;
        private string _color;
        private string _serial;
        
        public string Type { get; set; }
        public int Size { get; set; }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        public Cykel(string brand, string color, string serial, string type, int size)
        {
            _brand = brand;
            _color = color;
            _serial = serial;
            Type = type;
            Size = size;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}\n" + 
                   $"Color: {Color}\n" +
                   $"Serial: {Serial}\n" +
                   $"Type: {Type}\n" +
                   $"Size: {Size}";
        }
    }
}
