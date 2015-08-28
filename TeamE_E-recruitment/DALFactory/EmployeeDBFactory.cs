


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: EmployeeDBFactory.cs
Description of the file: Used in Data Access Layer.
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
using E_Recruitment.DAL;

namespace E_Recruitment.DALFactory
{
    public class EmployeeDBFactory
    {
        private static IEmployeeDB objEmployeeDB = null;

        public static IEmployeeDB Create_EmployeeDB()
        {

            if (objEmployeeDB == null)
            {

                objEmployeeDB = (IEmployeeDB)new EmployeeDB();

            }
            return objEmployeeDB;
        }
    }
}
