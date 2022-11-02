using PairProgrammingRestJS.Models;

namespace PairProgrammingRestJS.Managers
{
    public class MusicRecordsManager
    {
        private static int _nextId = 1;
        private static List<MusicRecord> _musicRecords = new List<MusicRecord>()
        {
            new MusicRecord(_nextId++, "Smoke weed everyday", "Snoop doggy dog"),
            new MusicRecord(_nextId++, "Drop it like it's hot", "Snoop doggy dog"),
            new MusicRecord(_nextId++, "Happy", "Pharrell Williams"),
            new MusicRecord(_nextId++, "Old town road", "Lil Nas X"),
            new MusicRecord(_nextId++, "Industry baby", "Lil Nas X"),
        };

        public static void Reset()
        {
            _musicRecords = new List<MusicRecord>()
            {
                new MusicRecord(1, "Smoke weed everyday", "Snoop doggy dog"),
                new MusicRecord(2, "Drop it like it's hot", "Snoop doggy dog"),
                new MusicRecord(3, "Happy", "Pharrell Williams"),
                new MusicRecord(4, "Old town road", "Lil Nas X"),
                new MusicRecord(5, "Industry baby", "Lil Nas X"),
            };
        }
        public MusicRecord Add(MusicRecord musicRecord)
        {
            musicRecord.Id = _nextId++;
            _musicRecords.Add(musicRecord);
            return musicRecord;
        }

        public List<MusicRecord> GetAll()
        {
            return _musicRecords;
        }

        public MusicRecord GetById(int id)
        {
            MusicRecord musicRecord;
            musicRecord = _musicRecords.Find(x => x.Id == id);
            if (musicRecord != null) return musicRecord;
            return null;
        }

        public MusicRecord Update(MusicRecord newMusicRecord, int id)
        {
            MusicRecord musicRecord = GetById(id);
            if (musicRecord == null) return null;
            musicRecord.RecordName = newMusicRecord.RecordName;
            musicRecord.ArtistName = newMusicRecord.ArtistName;
            return musicRecord;
        }

        public MusicRecord Delete(int id)
        {
            MusicRecord musicRecord= GetById(id);
            if (musicRecord == null) return null;
            _musicRecords.Remove(musicRecord);
            return musicRecord;
        }

    }
}
