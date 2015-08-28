using System;
namespace E_Recruitment.Types
{
    public interface IEmployee
    {
        float get_CTC { get; set; }
        string get_Designation { get; set; }
        string get_Division { get; set; }
        DateTime get_DOB { get; set; }
        DateTime get_DOJ { get; set; }
        int get_EmployeeID { get; set; }
        string get_EmployeeName { get; set; }
        int get_Experience { get; set; }
        string get_Gender { get; set; }
        bool get_IsHR { get; set; }
        string get_Location { get; set; }
        string get_Password { get; set; }
        int get_ProjectID { get; set; }
        int get_UnitHeadID { get; set; }
    }
}
