using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface IEmployeeManager
    {
        int addtestadmin(int EmployeeID);
        List<IEmployee> EmployeeList { get; set; }
        List<IEmployee> listemployee();
        List<IEmployee> ListOfEmployees();
    }
}
