﻿namespace EFCore20Demo.DomainClasses
{
    public class CarClass
    {
        public int Id { get; set; }
        public int ImageKey { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int EngineSize { get; set; }
        public int HorsePower { get; set; }
        public int Seats { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{LicensePlate.TrimEnd(' ')}, a {Brand.TrimEnd(' ')}";
        }
    }
}