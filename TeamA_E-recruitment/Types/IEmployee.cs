using System;
namespace Types
{
    public interface IEmployee
    {
        string BussinessDomain { get; set; }
        int EmployeeID { get; set; }
        bool IsHR { get; set; }
        string Name { get; set; }
        int UnitHead { get; set; }
    }
}
