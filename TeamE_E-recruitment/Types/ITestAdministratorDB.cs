using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface ITestAdministratorDB
    {
        int Approve(int EmployeeID);
        int DeleteTestAdministrators(int delete_testAdmin_ID);
        List<ITestAdministrator> GetList();
        List<ITestAdministrator> getTestAdministrators();
        int Save(ITestAdministrator testadministrator);
    }
}
