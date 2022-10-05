using RestExercise1.Models;
using System.Xml.Linq;

namespace RestExercise1.Managers
{
    public class IPAsManagerDB : IIPAsManager
    {
        private  IPAContext _context;
        public IPAsManagerDB(IPAContext context)
        {
            _context = context;
        }
        public IPA Add(IPA newIPA)
        {
            newIPA.Id = 0;
            _context.IPAs.Add(newIPA);
            _context.SaveChanges();
            return newIPA;
        }

        public IPA Delete(int id)
        {
            IPA ipaToRemove = GetById(id);
            _context.IPAs.Remove(ipaToRemove);
            _context.SaveChangesAsync();
            return ipaToRemove;
        }

        public List<IPA> GetAll(string? substring, double? minProof, double? maxProof)
        {
            var tempList = _context.IPAs.ToList();
            if (substring != null) tempList = tempList.FindAll(obj => obj.Brand.Contains(substring, StringComparison.InvariantCultureIgnoreCase));
            if (minProof != null) tempList = tempList.FindAll(obj => obj.Proof >= minProof);
            if (maxProof != null) tempList = tempList.FindAll(obj => obj.Proof <= maxProof);
            return tempList;
        }

        public IPA GetById(int id)
        {
            return _context.IPAs.Find(id);
        }

        public IPA Update(int id, IPA updates)
        {
            IPA ipa = _context.IPAs.Find(id);
            if (ipa == null) return null;
            ipa.Brand = updates.Brand;
            ipa.Grain = updates.Grain;
            ipa.Name = updates.Name;
            ipa.Proof = updates.Proof;
            return ipa;
        }
    }
}
