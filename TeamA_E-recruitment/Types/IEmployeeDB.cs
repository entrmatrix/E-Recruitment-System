using System;
namespace Types
{
    public interface IEmployeeDB
    {
        Types.IEmployee SelectEmployeeDetails(int employeeID, string password);
    }
}
