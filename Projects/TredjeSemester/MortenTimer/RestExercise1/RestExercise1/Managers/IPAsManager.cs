using Microsoft.AspNetCore.Mvc.Formatters;
using RestExercise1.Models;

namespace RestExercise1.Managers
{
    public class IPAsManager
    {
        private static int _nextId = 1;
        /// <summary>
        /// Predefined list of IPAs
        /// </summary>
        private static readonly List<IPA> _data = new List<IPA>
        {
            new IPA {Brand = "Anarkist", Grain = "Malt", Id = _nextId++, Name = "Vacation Forever", Proof = 6.3},
            new IPA {Brand = "Anarkist", Grain = "Humle", Id = _nextId++, Name = "Juicy Galaxy", Proof = 7.3},
            new IPA {Id = _nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 12.34, Name = "Classic"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 10.25,  Name = "Porter"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 10.50,  Name = "Elefant"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 5.25,  Name = "Lys"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 8.5,  Name = "Mørk"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 9.2,  Name = "Jumbo"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 8,  Name = "Light"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Tuborg", Proof = 6,  Name = "Grøn"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 9,  Name = "Darkest"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 12,  Name = "Classic"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 17,  Name = "Elefant"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 13,  Name = "Porter"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 8,  Name = "IPA"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 8,  Name = "Light"},
            new IPA {Id=_nextId++, Grain = "Humle", Brand = "Carlsberg", Proof = 8,  Name = "Jumbo"},
        };

        public List<IPA> GetAll(string? substring, double? minProof, double? maxProof)
        {
            var tempList = _data;
            if (substring != null) tempList = tempList.FindAll(obj => obj.Brand.Contains(substring, StringComparison.InvariantCultureIgnoreCase));
            if (minProof != null) tempList = tempList.FindAll(obj => obj.Proof >= minProof);
            if (maxProof != null) tempList = tempList.FindAll(obj => obj.Proof <= maxProof);
            return tempList;
        }

        public IPA GetById(int id)
        {
            return _data.Find(ipa => ipa.Id == id);
        }

        public IPA Add(IPA newIPA)
        {
            newIPA.Id = _nextId++;
            _data.Add(newIPA);
            return newIPA;
        }

        public IPA Delete(int id)
        {
            IPA ipa = _data.Find(ipa => ipa.Id == id);
            if (ipa == null) return null;
            _data.Remove(ipa);
            return ipa;
        }

        public IPA Update(int id, IPA updates)
        {
            IPA ipa = _data.Find(ipa => ipa.Id == id);
            if (ipa == null) return null;
            ipa.Brand = updates.Brand;
            ipa.Grain = updates.Grain;
            ipa.Name = updates.Name;
            ipa.Proof = updates.Proof;
            return ipa;
        }
    }
}
