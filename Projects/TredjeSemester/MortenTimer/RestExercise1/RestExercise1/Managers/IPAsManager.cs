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
            new IPA {Brand = "Anarkist", Grain = "Humle", Id = _nextId++, Name = "Juicy Galaxy", Proof = 7.3}
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
