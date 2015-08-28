using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BLL;
namespace BLLFactory
{
    public class EmployeeManagerFactory
    {
        private static IEmployeeManager employeeManager = null;
        public static IEmployeeManager CreateEmployeeManager()
        {
            if (employeeManager==null)
            employeeManager = new EmployeeManager();
            return employeeManager;
        }
    }

}
