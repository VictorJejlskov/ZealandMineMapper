using PairProgrammingRestJS.Models;

namespace PairProgrammingRestJS.Managers
{
    public class MusicRecordsManager
    {
        private static int _nextId = 1;
        private static List<MusicRecord> _musicRecords = new List<MusicRecord>()
        {
            new MusicRecord(_nextId++, "The Next Episode", "Snoop doggy dog", 161, 2001),
            new MusicRecord(_nextId++, "Drop it like it's hot", "Snoop doggy dog", 266, 2004),
            new MusicRecord(_nextId++, "Happy", "Pharrell Williams", 232, 2014),
            new MusicRecord(_nextId++, "Old town road", "Lil Nas X", 113, 2019),
            new MusicRecord(_nextId++, "Industry baby", "Lil Nas X", 212, 2021),
        };

        public static void Reset()
        {
            _musicRecords = new List<MusicRecord>()
            {
                new MusicRecord(1, "The Next Episode", "Snoop doggy dog", 161, 2001),
                new MusicRecord(2, "Drop it like it's hot", "Snoop doggy dog", 266, 2004),
                new MusicRecord(3, "Happy", "Pharrell Williams", 232, 2014),
                new MusicRecord(4, "Old town road", "Lil Nas X", 113, 2019),
                new MusicRecord(5, "Industry baby", "Lil Nas X", 212, 2021),
            };
        }
        public MusicRecord Add(MusicRecord musicRecord)
        {
            musicRecord.Id = _nextId++;
            _musicRecords.Add(musicRecord);
            return musicRecord;
        }

        public List<MusicRecord> GetAll(string? recordName = null, string? artistName = null, int? year = null)
        {
            List<MusicRecord> records = _musicRecords;
            if (recordName != null)
            {
                records = records.FindAll(records => records.RecordName.ToLower().Contains(recordName.ToLower()));
            }
            if (artistName != null)
            {
                records = records.FindAll(records => records.ArtistName.ToLower().Contains(artistName.ToLower()));
            }
            if (year != null)
            {
                records = records.FindAll(records => records.PublicationYear.Equals(year));
            }
            return records;
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
            musicRecord.Duration = newMusicRecord.Duration;
            musicRecord.PublicationYear = newMusicRecord.PublicationYear;
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
