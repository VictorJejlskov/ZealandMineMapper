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

        public override bool Equals(object? obj)
        {
            return obj is MusicRecord record &&
                   Id == record.Id &&
                   RecordName == record.RecordName &&
                   ArtistName == record.ArtistName;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(RecordName)}={RecordName}, {nameof(ArtistName)}={ArtistName}}}";
        }
    }
}
