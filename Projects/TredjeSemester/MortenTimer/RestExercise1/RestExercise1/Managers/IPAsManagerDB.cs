using RestExercise1.Models;

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
            throw new NotImplementedException();
        }

        public IPA Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<IPA> GetAll(string? substring, double? minProof, double? maxProof)
        {
            throw new NotImplementedException();
        }

        public IPA GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IPA Update(int id, IPA updates)
        {
            throw new NotImplementedException();
        }
    }
}
