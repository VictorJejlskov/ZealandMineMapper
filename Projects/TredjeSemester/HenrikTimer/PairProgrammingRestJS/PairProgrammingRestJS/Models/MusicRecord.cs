namespace PairProgrammingRestJS.Models
{
    public class MusicRecord
    {
        public int Id { get; set; } 
        public string RecordName { get; set; }
        public string ArtistName { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public MusicRecord(int id, string recordName, string artistName, int duration, int publicationYear)
        {
            Id = id;
            RecordName = recordName;
            ArtistName = artistName;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public MusicRecord()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is MusicRecord record &&
                   Id == record.Id &&
                   RecordName == record.RecordName &&
                   ArtistName == record.ArtistName &&
                   Duration == record.Duration &&
                   PublicationYear == record.PublicationYear;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(RecordName)}={RecordName}, {nameof(ArtistName)}={ArtistName}, {nameof(Duration)}={Duration.ToString()}, {nameof(PublicationYear)}={PublicationYear.ToString()}}}";
        }
    }
}
