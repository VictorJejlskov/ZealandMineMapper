using Duathlete;

namespace RestDuathlon.Managers
{
    public class DuathlonsManager
    {
        private static int _nextBip = 1;
        private static List<Duathlete.Models.Duathlete> _athletes = new List<Duathlete.Models.Duathlete>()
        {
            //BIP, Name, Age, Bike, Run
            new Duathlete.Models.Duathlete(_nextBip++, "Søren", 26, 120, 50),
            new Duathlete.Models.Duathlete(_nextBip++, "Frederik", 50, 100, 60),
            new Duathlete.Models.Duathlete(_nextBip++, "Martin", 75, 90, 75),
            new Duathlete.Models.Duathlete(_nextBip++, "Andreas", 63, 150, 90),
            new Duathlete.Models.Duathlete(_nextBip++, "Mads", 14, 70, 40),
            new Duathlete.Models.Duathlete(_nextBip++, "Kjeld", 86, 140, 60),
            new Duathlete.Models.Duathlete(_nextBip++, "Henriette", 22, 130, 62),
            new Duathlete.Models.Duathlete(_nextBip++, "Sofie", 19, 112, 35),
            new Duathlete.Models.Duathlete(_nextBip++, "Morten", 60, 125, 40),
            new Duathlete.Models.Duathlete(_nextBip++, "Henrik", 43, 40, 25)
        };

        public List<Duathlete.Models.Duathlete> GetAll()
        {
            return _athletes;
        }
        public Duathlete.Models.Duathlete GetByBip(int id)
        {
            var athlete = GetAll().Find(ath => ath.Bip == id);
            if (athlete == null) throw new NullReferenceException($"No Athlete with Bip: {id} was found");
            return athlete;
        }
        public Duathlete.Models.Duathlete Add(Duathlete.Models.Duathlete newAthlete)
        {
            newAthlete.Bip = _nextBip++;
            newAthlete.AgeGroup = newAthlete.GetAgeGroup(newAthlete.AgeGroup);
            newAthlete.Validate();
            _athletes.Add(newAthlete);
            return newAthlete;
        }
        public Duathlete.Models.Duathlete Delete(int id)
        {
            Duathlete.Models.Duathlete athlete = GetByBip(id);
            _athletes.Remove(athlete);
            return athlete;
        }

    }
}
