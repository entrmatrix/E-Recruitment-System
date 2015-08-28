using System;
namespace E_Recruitment.Types
{
    public interface ITestAdministrator
    {
        string get_EmployeeDesignation { get; set; }
        int get_EmployeeExperience { get; set; }
        int get_EmployeeID { get; set; }
        string get_EmployeeLocation { get; set; }
        string get_EmployeeName { get; set; }
        bool get_IsTestAdmin { get; set; }
    }
}
