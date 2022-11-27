using MusicRecordsRest.Models;

namespace MusicRecordsRest.Managers
{
    public class MusicRecordsManager
    {
        private static int _nextId = 1;
        private List<MusicRecord> _records = new List<MusicRecord>()
        {
            new MusicRecord(){ Id = _nextId++, Title = "Gravity", Artist = "Boris Brejcha", Duration = 216, PublicationYear = 2019},
            new MusicRecord(){ Id = _nextId++, Title = "Purple Noise", Artist = "Boris Brejcha", Duration = 539, PublicationYear = 2014},
            new MusicRecord(){ Id = _nextId++, Title = "Up Down Jumper", Artist = "Boris Brejcha", Duration = 432, PublicationYear = 2022},
            new MusicRecord(){ Id = _nextId++, Title = "House Music", Artist = "Boris Brejcha", Duration = 179, PublicationYear = 2021},
            new MusicRecord(){ Id = _nextId++, Title = "Space Diver", Artist = "Boris Brejcha", Duration = 397, PublicationYear = 2020},
        };

        public List<MusicRecord> GetAll()
        {
            return _records;
        }
        public MusicRecord GetById(int id)
        {
            return _records.Find(record => record.Id == id);
        }
        public List<MusicRecord> GetByTitle(string searchParam)
        {
            return _records.FindAll(record => record.Title.ToLower().Contains(searchParam.ToLower()));
        }
        public List<MusicRecord> GetByArtist(string searchParam)
        {
            return _records.FindAll(record => record.Artist.ToLower().Contains(searchParam.ToLower()));
        }
    }
}
