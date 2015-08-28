


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestStatus.cs
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
    public class TestStatus : ITestStatus  
    {
        private int CandidateID;
        private DateTime Written_TestDate;
        private string Written_TestStatus;
        private DateTime Technical_InterviewDate;
        private string Technical_InterviewStatus;
        private DateTime HR_InterviewDate;
        private string HR_InterviewStatus;
        private int TestID;

        public TestStatus()
        {
        }

        public TestStatus(int CID, DateTime WTD, string WTS, DateTime TID, string TIS, DateTime HRID, string HRIS, int TestID)
        {
            this.CandidateID = CID;
            this.Written_TestDate = WTD;
            this.Written_TestStatus = WTS;
            this.Technical_InterviewDate = TID;
            this.Technical_InterviewStatus = TIS;
            this.HR_InterviewDate = HRID;
            this.HR_InterviewStatus = HRIS;
            this.TestID = TestID;
        }


        public int get_TestID
        {
            get { return TestID; }
            set { this.TestID = value; }
        }

        public int get_CandidateID
        {
            get { return CandidateID; }
            set { this.CandidateID = value; }
        }
        public DateTime get_Written_TestDate
        {
            get { return Written_TestDate; }
            set { this.Written_TestDate = value; }
        }
        public DateTime get_Technical_InterviewDate
        {
            get { return Technical_InterviewDate; }
            set { this.Technical_InterviewDate = value; }
        }
        public DateTime get_HR_InterviewDate
        {
            get { return HR_InterviewDate; }
            set { this.HR_InterviewDate = value; }
        }
        public string get_Written_TestStatus
        {
            get { return Written_TestStatus; }
            set { this.Written_TestStatus = value; }

        }
        public string get_Technical_InterviewStatus
        {
            get { return Technical_InterviewStatus; }
            set { this.Technical_InterviewStatus = value; }

        }
        public string get_HR_InterviewStatus
        {
            get { return HR_InterviewStatus; }
            set { this.HR_InterviewStatus = value; }

        }
    }
}
