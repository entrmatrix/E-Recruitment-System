


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Test.cs
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
    public class Test : ITest
    {
        private int TestID;
        private int TestAdministratorID;
        private int VacancyID;
        private DateTime WrittenTestDate;
        private DateTime TechnicalInterviewDate;
        private DateTime HRInterviewDate;

        public Test(int TestID, int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate)
        {
            this.TestID = TestID;
            this.TestAdministratorID = TestAdminID;
            this.VacancyID = VacancyID;
            this.WrittenTestDate = WrittenTestDate;
            this.TechnicalInterviewDate = TechnicalTestDate;
            this.HRInterviewDate = HRInterviewDate;
        }


        public int get_TestID
        {
            get { return TestID; }
            set { this.TestID = value; }
        }

        public int get_TestAdministratorID
        {
            get { return TestAdministratorID; }

            set { this.TestAdministratorID = value; }
        }

        public int get_VacancyID
        {

            get { return VacancyID; }

            set { this.VacancyID = value; }

        }

        public DateTime get_WrittenTestDate
        {

            get { return WrittenTestDate; }

            set { this.WrittenTestDate = value; }

        }
        public DateTime get_TechnicalInterviewDate
        {

            get { return TechnicalInterviewDate; }

            set { this.TechnicalInterviewDate = value; }

        }
        public DateTime get_HRInterviewDate
        {

            get { return HRInterviewDate; }

            set { this.HRInterviewDate = value; }

        }
    }
}
