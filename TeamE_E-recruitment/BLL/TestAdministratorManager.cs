


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestAdministratorManager.cs
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

namespace E_Recruitment.BLL
{
    public class TestAdministratorManager : ITestAdministratorManager
    {
   

        // to retrieve all  Test administrators
        public List<ITestAdministrator> getTestAdministrator()
        {        
            ITestAdministratorDB objTestAdministratorDB = TestAdministratorDBFactory.Create_TestAdminDB();
             return objTestAdministratorDB.GetList();
        }

       // To retrieve all approved Test Administrators 
        public List<ITestAdministrator> DisplayTestAdministrators()
        {
            List<ITestAdministrator> temp_testAdmin = new List<ITestAdministrator>();
     
            ITestAdministratorDB objTestAdministratorDB = TestAdministratorDBFactory.Create_TestAdminDB();
            temp_testAdmin = objTestAdministratorDB.getTestAdministrators();
            List<ITestAdministrator> list = new List<ITestAdministrator>();
          
            for (int i = 0; i < temp_testAdmin.Count; i++)
            {
                if (temp_testAdmin.ElementAt(i).get_IsTestAdmin == true)
                    list.Add(temp_testAdmin.ElementAt(i));
            }

            return list;
        }

        // To delete test administrator
        public int DeleteTestAdministrator(int del_admin_id)
        {

            ITestAdministratorDB objTestAdministratorDB = TestAdministratorDBFactory.Create_TestAdminDB();
            
     
            return objTestAdministratorDB.DeleteTestAdministrators(del_admin_id);
        }

        // To approve test administrator

        public List<ITestAdministrator> ApproveTestAdministrators(int intUserid)
        {
            List<ITestAdministrator> temp_testAdmin = new List<ITestAdministrator>();

            List<IEmployee> listtepemployee = new List<IEmployee>();
            IEmployeeDB objempdb = EmployeeDBFactory.Create_EmployeeDB();
            listtepemployee = objempdb.List_Employees();

            ITestAdministratorDB objTestAdministratorDB = TestAdministratorDBFactory.Create_TestAdminDB();
            temp_testAdmin = objTestAdministratorDB.getTestAdministrators();

            List<ITestAdministrator> objtemplist = new List<ITestAdministrator>();

              for (int i = 0; i <  listtepemployee.Count; i++)
            {
                int t = 0;
                try
                {
                    t = Convert.ToInt32( listtepemployee.ElementAt(i).get_UnitHeadID);
                }
                catch (Exception)
                {
                    t = 0;
                }
                for (int j = 0; j < temp_testAdmin.Count; j++)
                {
                    if (t == intUserid && listtepemployee.ElementAt(i).get_EmployeeID == temp_testAdmin.ElementAt(j).get_EmployeeID)
                    {

                        if (temp_testAdmin.ElementAt(j).get_IsTestAdmin == false)
                            objtemplist.Add(temp_testAdmin.ElementAt(j));
                    }
                }
            }

            return objtemplist;
        }

        // To update test administrator
        public int UpdateTestAdministrator(int EmployeeID)
        {

            ITestAdministratorDB objTestAdministratorDB = TestAdministratorDBFactory.Create_TestAdminDB();

            return objTestAdministratorDB.Approve(EmployeeID);
        }           
        }
    }

