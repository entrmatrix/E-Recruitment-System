using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DAL;
namespace DALFactory
{
    public class EmployeeDBFactory
    {
        private static IEmployeeDB employeeDB = null;

        public static IEmployeeDB CreateEmployeeDB()
        {
            if(employeeDB==null)
            employeeDB = new EmployeeDB();
            return employeeDB;
        } 
    }
}
