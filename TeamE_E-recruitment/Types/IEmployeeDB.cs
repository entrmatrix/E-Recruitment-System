using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public  interface IEmployeeDB
    {
       List<IEmployee> getEmployees();
       List<IEmployee> List_Employees();
    }
}
