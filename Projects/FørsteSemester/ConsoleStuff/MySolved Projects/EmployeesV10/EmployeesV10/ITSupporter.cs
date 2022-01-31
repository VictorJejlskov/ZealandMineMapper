namespace EmployeesV10
{
    public class ITSupporter : Employee
    {
        #region Instance fields
        public string PrimaryWorkArea { get; set; }
        #endregion

        #region Constructor
        public ITSupporter(string name, int hoursPerWeek, string primaryWorkArea) : base(name, hoursPerWeek)
        {
            PrimaryWorkArea = primaryWorkArea;
        }
        #endregion

        #region Properties

        public string AllInformation
        {
            get
            {
                return $"IT-Supporter {Name} works {HoursPerWeek} hours/week, mostly with {PrimaryWorkArea}";
            }
        } 
        #endregion
    }
}
