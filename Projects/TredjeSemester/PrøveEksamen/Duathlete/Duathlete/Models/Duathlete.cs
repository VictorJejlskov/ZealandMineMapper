namespace Duathlete.Models
{
    public class Duathlete
    {
        public int Bip { get; set; }
        public string Name { get; set; }
        public int AgeGroup { get; set; }
        public int Bike { get; set; }
        public int Run { get; set; }
        public int Total 
        { 
            get
            {
                return Bike + Run;
            } 
        }
        public Duathlete()
        {

        }

        public Duathlete(int bip, string name, int age, int bike, int run)
        {
            Bip = bip;
            Name = name;
            AgeGroup = GetAgeGroup(age);
            Bike = bike;
            Run = run;
        }

        public override string ToString()
        {
            return $"{nameof(Bip)}={Bip.ToString()}, {nameof(Name)}={Name}, {nameof(AgeGroup)}={AgeGroup.ToString()}, {nameof(Bike)}={Bike.ToString()}, {nameof(Run)}={Run.ToString()}, {nameof(Total)}={Total.ToString()}";
        }
        public int GetAgeGroup(int age)
        {
            if (age < 25) return 1;
            if (age >= 25 && age <= 35) return 2;
            if (age >= 36 && age <= 45) return 3;
            else return 4;
        }

        public void ValidateName()
        {
            if (string.IsNullOrEmpty(Name)) throw new ArgumentNullException("Name må ikke være tom");
            if (Name.Length <= 3) throw new ArgumentOutOfRangeException("Name skal være  mindst 4 karakterer lang");
        }
        public void ValidateAgeGroup()
        {
            if (AgeGroup <= 0) throw new ArgumentOutOfRangeException($"Der er sket en fejl, agegroup skal altid være mellem 1 og 4 - Denne gang var den: {AgeGroup}");
            if (AgeGroup >= 5) throw new ArgumentOutOfRangeException($"Der er sket en fejl, agegroup skal altid være mellem 1 og 4 - Denne gang var den: {AgeGroup}");
        }
        public void ValidateTotal()
        {
            if (Total != Bike + Run) throw new ArgumentException("Total burde være resultatet af Bike + Run, men der er sket en fejl");
        }
        public void Validate() 
        {
            ValidateName();
            ValidateAgeGroup();
            ValidateTotal();
        }
    }
}