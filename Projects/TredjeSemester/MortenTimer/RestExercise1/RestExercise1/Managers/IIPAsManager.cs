using RestExercise1.Models;

namespace RestExercise1.Managers
{
    public interface IIPAsManager
    {
        IPA Add(IPA newIPA);
        IPA Delete(int id);
        List<IPA> GetAll(string? substring, double? minProof, double? maxProof);
        IPA GetById(int id);
        IPA Update(int id, IPA updates);
    }
}