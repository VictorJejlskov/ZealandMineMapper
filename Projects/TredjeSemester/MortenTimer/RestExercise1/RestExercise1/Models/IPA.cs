namespace RestExercise1.Models
{
    public class IPA
    {
        public int Id { get; set; }
        public double Proof { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Grain { get; set; }

        public void ValidateName()
        {
            if (String.IsNullOrWhiteSpace(Name)) throw new ArgumentException("Navnet må ikke være tomt");
        }
        public void ValidateProof()
        {
            if (Proof == 0) throw new ArgumentOutOfRangeException("Vi serverer ikke alkohol fri øl");
            if (Proof < 4.5) throw new ArgumentOutOfRangeException("IPAen skal have en procent på over eller lig med 4.5");
            if (Proof > 20) throw new ArgumentOutOfRangeException("Vi serverer ikke ren alkohol her");
        }
        public void ValidateBrand()
        {
            if (String.IsNullOrWhiteSpace(Brand)) throw new ArgumentException("Brand må ikke være tom");
            if (Brand.Length < 3) throw new ArgumentOutOfRangeException("Brand skal være længere end 3");
        }
        public void ValidateGrain()
        {
            if (String.IsNullOrWhiteSpace(Grain)) throw new ArgumentException("Brand må ikke være tom");
            if (Grain.Length < 3) throw new ArgumentOutOfRangeException("Brand skal være længere end 3");
        }
        public void Validate()
        {
            ValidateName();
            ValidateProof();
            ValidateBrand();
            ValidateGrain();
        }
    }
}
