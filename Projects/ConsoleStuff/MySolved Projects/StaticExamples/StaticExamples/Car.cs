namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;

        public static int NoOfProduced { get; set; }

        private int _usesLicensePlate;
        private int _usesPrice;
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            NoOfProduced++;
            _licensePlate = licensePlate;
            _price = price;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get
            { _usesLicensePlate++; return _licensePlate; }
            set { _licensePlate = value; }
        }

        public int Price
        {
            get
            { _usesPrice++; return _price; }
            set { _price = value; }
        }

        //public static void UseALicensePlate()
        //{
        //    UsesOfLicensePlate += 1;
        //}

        //public static void UseACarPrice()
        //{
        //    UsesOfPrice += 1;
        //}

        public static string PrintUsageStatistics()
        {
            return $"Number of Cars produced: {NoOfProduced}\n";

            //$"Number of cars with a license plate: {UsesOfLicensePlate}\n" + 
            //$"Number of cars with a price: {UsesOfPrice}";
        }




        #endregion
    }
}