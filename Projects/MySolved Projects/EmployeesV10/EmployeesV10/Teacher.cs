namespace EmployeesV10
{
    public class Teacher : Employee
    {
        #region Instance fields
        public int PayGrade { get; set; }
        #endregion

        #region Constructor
        public Teacher(string name, int hoursPerWeek, int payGrade):base(name,hoursPerWeek)
        {
            PayGrade = payGrade;
        }
        #endregion

        #region Properties

        public string AllInformation
        {
            get
            {
                return $"Teacher {Name} works {HoursPerWeek} hours/week, at paygrade {PayGrade}";
            }
        } 
        #endregion
    }
}
