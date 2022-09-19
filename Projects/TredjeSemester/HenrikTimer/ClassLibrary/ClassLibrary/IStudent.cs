namespace ClassLibrary
{
    public interface IStudent : IPerson
    {
        int Semester { get; set; }

        void Validate();
        void ValidateName();
        void ValidateSemester();
    }
}