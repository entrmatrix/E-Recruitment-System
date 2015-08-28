using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface ITestAdministratorManager
    {
        List<ITestAdministrator> ApproveTestAdministrators(int intUserid);
        int DeleteTestAdministrator(int del_admin_id);
        List<ITestAdministrator> DisplayTestAdministrators();
        List<ITestAdministrator> getTestAdministrator();
        int UpdateTestAdministrator(int EmployeeID);
    }
}
