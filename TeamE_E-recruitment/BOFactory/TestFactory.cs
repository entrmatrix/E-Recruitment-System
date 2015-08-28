


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestFactory.cs
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
    public class TestFactory
    {
        private static ITest objTest = null;

        public static ITest Create_Test(int TestID, int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate)
        {

            objTest = new Test(TestID, TestAdminID, VacancyID, WrittenTestDate, TechnicalTestDate, HRInterviewDate);                 
            return objTest;
        }
    }
}
