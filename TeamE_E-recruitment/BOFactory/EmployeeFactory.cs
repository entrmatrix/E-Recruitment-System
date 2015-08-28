


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: EmplyeeFactory.cs
Description of the file: Used in Business Object Layer.
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
using E_Recruitment.BO;

namespace E_Recruitment.BOFactory
{
    public class EmployeeFactory
    {
        private static IEmployee objEmployee = null;
        public static IEmployee Create_employee(int EmployeeID, string EmployeeName, int UnitHeadID, int ProjectID, bool IsHR, DateTime DOB, DateTime DOJ, string Gender, string Division, float CTC, string Designation, string Password, string Location, int Experience)
        {
           
            objEmployee = new Employee(EmployeeID, EmployeeName, UnitHeadID, ProjectID, IsHR, DOB, DOJ, Gender, Division, CTC, Designation, Password, Location, Experience);
            return objEmployee;
        }
    }
}
