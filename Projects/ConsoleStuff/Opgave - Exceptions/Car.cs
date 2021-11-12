using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Opgave___Exceptions
{
    class Car
    {
        private string _brand;
        private string _model;
        private string _regNo;
        private int _horsePower;
        private int _doors;

        public string Brand
        {
            get => _brand;

            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Brand må ikke være null eller være tom");
                _brand = value; 

            }
        }

        public string Model
        {
            get => _model;

            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Model må ikke være null eller være tom");
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException(
                        string.Format("Model må ikke være længere end 20 karakterer lang"));
                _model = value;
            }
        }

        public string RegNo
        {
            get => _regNo;
            set
            {
                int myInt;
                bool isFirstNumerical = int.TryParse(value.Substring(0,1), out myInt);
                if (isFirstNumerical)
                {
                    throw new FormatException(string.Format("Den første karakter i RegNo skal være bogstaver"));
                }

                bool isSecondNumerical = int.TryParse(value.Substring(1, 1), out myInt);
                if (isSecondNumerical)
                {
                    throw new FormatException(string.Format("Den anden karakter i RegNo skal være bogstaver"));
                }
                bool isLastNumerical = int.TryParse(value.Substring(2,5), out myInt);
                if (!isLastNumerical)
                {
                    throw new FormatException(string.Format("De sidste 5 karakterer i RegNo skal være tal"));
                }

                if (value.Substring(2,1) == "0")
                {
                    throw new FormatException(string.Format("Det første tal i RegNo må ikke være 0"));
                }

                if (value.Length != 7)
                {
                    throw new FormatException(string.Format("RegNo skal være 7 karakterer langt"));
                }
                _regNo = value;
            }
        }

        public int HorsePower
        {
            get => _horsePower;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format("HorsePower skal være over tallet 0"));
                }
                _horsePower = value;
            }    
        }

        public int Doors
        {
            get => _doors;
            set
            {
                if (value < 2)
                    throw new ArgumentOutOfRangeException(string.Format("Der skal være mindst 2 døre i din bil"));
                if (value > 5)
                    throw new ArgumentOutOfRangeException(string.Format("Der må ikke være mere end 5 døre i din bil"));
                _doors = value;
            }
        }


        public Car()
        {
            
        }

        public Car(string brand, string model, string regNo, int horsePower, int doors)
        {
            _brand = brand;
            _model = model;
            _regNo = regNo;
            _horsePower = horsePower;
            _doors = doors;
        }

        public override string ToString()
        {
            return $"Brand: {_brand}, Model: {_model}, RegNo: {_regNo}, HorsePower: {_horsePower}, Doors: {_doors}";
        }

        protected bool Equals(Car other)
        {
            return _brand == other._brand && _model == other._model && _regNo == other._regNo && _horsePower == other._horsePower && _doors == other._doors;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Car) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_brand, _model, _regNo, _horsePower, _doors);
        }
    }
}
