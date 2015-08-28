using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BussinessObject;
namespace BussinessObjectFactory
{
    public class EmployeeFactory
    {
        private static IEmployee employee = null;

        public static IEmployee CreateEmployee(string name, int employeeID, bool isHR, int unitHeadID, string bussinessDomain)
        {
            employee = new Employee(name,  employeeID,  isHR,  unitHeadID,  bussinessDomain);
            return employee;
        } 
    }
}
