


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestAdministrator.cs
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

namespace E_Recruitment.BO
{
    public class TestAdministrator : ITestAdministrator 
    {
        private int EmployeeID;
        private string EmployeeName;
        private bool IsTestAdmin;
        private string Designation;
        private string Location;
        private int Experience;

        public TestAdministrator()
        {
            EmployeeID = 0;
            EmployeeName = "";
            IsTestAdmin = false;
            Designation = "";
            Location = "";
            Experience = 0;
        }

        public TestAdministrator(int emp_id, bool testAdmin_sts)
        {
            this.EmployeeID = emp_id;
            this.IsTestAdmin = testAdmin_sts;
        }

        public int get_EmployeeID
        {
            get { return EmployeeID; }
            set { this.EmployeeID = value; }
        }

        public string get_EmployeeName
        {
            get { return EmployeeName; }
            set { this.EmployeeName = value; }
        }

        public bool get_IsTestAdmin
        {
            get { return IsTestAdmin; }
            set { this.IsTestAdmin = value; }
        }

        public string get_EmployeeDesignation
        {
            get { return Designation; }
            set { this.Designation = value; }
        }

        public string get_EmployeeLocation
        {
            get { return Location; }
            set { this.Location = value; }
        }

        public int get_EmployeeExperience
        {
            get { return Experience; }
            set { this.Experience = value; }
        }
    }
}
