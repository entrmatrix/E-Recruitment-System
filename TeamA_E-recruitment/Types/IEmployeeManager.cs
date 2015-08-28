using System;
namespace Types
{
    public interface IEmployeeManager
    {
        Types.IEmployee SelectEmployeeDetails(int employeeID, string password);
    }
}
