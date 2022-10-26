namespace PairProgrammingRestJS.Models
{
    public class MusicRecord
    {
        public int Id { get; set; } 
        public string RecordName { get; set; }
        public string ArtistName { get; set; }

        public MusicRecord(int id, string recordName, string artistName)
        {
            Id = id;
            RecordName = recordName;
            ArtistName = artistName;
        }

        public MusicRecord()
        {
        }
    }
}
