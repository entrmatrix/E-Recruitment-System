


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: EmployeeManager.cs
Description of the file: Used as Business Logic Layer.
 * This source is subject to the to ABC Public License. 
 * http://www.abc.erecruitment.com/  
 * All other rights reserved.  
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  EITHER 
 * EXPRESSED  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED  WARRANTIES OF
 * MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*********************************************************************/ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using E_Recruitment.Types;
using E_Recruitment.DALFactory;
using E_Recruitment.BOFactory;

namespace E_Recruitment.BLL
{
    public class EmployeeManager : IEmployeeManager
    {
        private static List<IEmployee> lstemployee = new List<IEmployee>();
        public List<IEmployee> EmployeeList
        {

            get { return lstemployee; }

            set { lstemployee = value; }

        }

        // All the employees excluding Test Administrator and HR
        public List<IEmployee> listemployee()
        {

            IEmployeeDB objEmployeeDB = EmployeeDBFactory.Create_EmployeeDB();
            EmployeeList = objEmployeeDB.getEmployees();
            return EmployeeList;
        }

        // All the employees including Test Administrator and HR
        public List<IEmployee> ListOfEmployees()
        {

            IEmployeeDB objEmployeeDB = EmployeeDBFactory.Create_EmployeeDB();
            return objEmployeeDB.List_Employees();
        }


        // To add Test Administrator
        public int addtestadmin(int EmployeeID)
        {
            TestAdministratorManager objTestAdminManager = new TestAdministratorManager();
            listemployee();


            if (EmployeeList.Any(p => p.get_EmployeeID == EmployeeID && p.get_Designation == "unithead"))
            {

                ITestAdministrator objTestAdministrator = TestAdministratorFactory.Create_TestAdministrator(EmployeeID, true);
                ITestAdministratorDB testadministratorDB = TestAdministratorDBFactory.Create_TestAdminDB();
                return testadministratorDB.Save(objTestAdministrator);

            }
            else if (EmployeeList.Any(p => p.get_EmployeeID == EmployeeID && p.get_Designation == "employee"))
            {

                ITestAdministrator objTestAdministrator = TestAdministratorFactory.Create_TestAdministrator(EmployeeID, false);
                ITestAdministratorDB test_adminDB = TestAdministratorDBFactory.Create_TestAdminDB();
                return test_adminDB.Save(objTestAdministrator);
            }
            else return 0;
        }

    }
    
}




