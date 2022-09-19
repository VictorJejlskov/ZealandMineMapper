namespace ClassLibrary
{
    public interface ITeacher : IPerson
    {
        List<string> Classes { get; set; }
        int Salary { get; set; }
        void Validate();
        void ValidateClasses();
        void ValidateName();
        void ValidateSalary();
    }
}