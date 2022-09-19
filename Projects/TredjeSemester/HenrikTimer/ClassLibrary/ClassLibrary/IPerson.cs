namespace ClassLibrary
{
    public interface IPerson
    {
        Person.GenderType Gender { get; set; }
        int Id { get; set; }
        string Name { get; set; }

        bool Equals(object? obj);
        int GetHashCode();
        string ToString();
        void Validate();
        void ValidateName();
    }
}