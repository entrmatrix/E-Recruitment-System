


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestSatusFactory.cs
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
    public class TestStatusFactory
    {
        private static ITestStatus objTestStatus = null;

        public static ITestStatus Create_TestStatus(int CID, DateTime WTD, string WTS, DateTime TID, string TIS, DateTime HRID, string HRIS,int TestID)
        {

            objTestStatus = new TestStatus(CID, WTD, WTS, TID, TIS, HRID, HRIS,TestID);
            
            return objTestStatus;
        }
    }
}
