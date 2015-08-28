using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DALFactory;
namespace BLL
{
    public class EmployeeManager : IEmployeeManager
    {
        public IEmployee SelectEmployeeDetails(int employeeID, string password)
        {
            IEmployeeDB employee = EmployeeDBFactory.CreateEmployeeDB();
            return employee.SelectEmployeeDetails(employeeID,password);
        }
           
    }
    
}
