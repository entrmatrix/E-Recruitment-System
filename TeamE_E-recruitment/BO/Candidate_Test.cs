


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Candidate_Test.cs
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
    public class Candidate_Test : ICandidate_Test
    {
        private int VacancyID;
        private int CandidateProfileID ;
        private DateTime DOB;
        private String Gender ;
        private int TestID ;
        private int TestStatus;
        private DateTime WrittenTestDate;
        private DateTime TechnicalInterviewDate;
        private DateTime HRInterviewDate;

        public Candidate_Test()
        {
        }

        public Candidate_Test(int VacancyID, int CandidateProfileID, DateTime DOB, String Gender, int TestID, int TestStatus, DateTime WrittenTestDate, DateTime TechnicalInterviewDate, DateTime HRInterviewDate)
        {
            this.CandidateProfileID = CandidateProfileID;
            this.VacancyID = VacancyID;
            this.DOB = DOB;         
            this.Gender = Gender;
            this.TestID= TestID;
            this.TestStatus= TestStatus;
            this.WrittenTestDate = WrittenTestDate;
            this.TechnicalInterviewDate = TechnicalInterviewDate;
            this.HRInterviewDate = HRInterviewDate;
        }

        public DateTime get_DOB
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }

        public String get_Gender
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }

        public int get_CandidateProfileID
        {
            get
            {
                return CandidateProfileID;
            }
            set
            {
                CandidateProfileID = value;
            }
        }


        public int get_VacancyID
        {
            get
            {
                return VacancyID;
            }
            set
            {
                VacancyID = value;
            }
        }

        public int get_TestID
        {
            get
            {
                return TestID;
            }
            set
            {
                TestID = value;
            }
        }

            
        public int get_TestStatus
        {
            get
            {
                return TestStatus;
            }
            set
            {
                TestStatus = value;
            }
        }

        public DateTime get_WrittenTestDate
        {
            get
            {
                return WrittenTestDate;
            }
            set
            {
                WrittenTestDate = value;
            }
        }

        public DateTime get_TechnicalInterviewDate
        {
            get
            {
                return TechnicalInterviewDate;
            }
            set
            {
                TechnicalInterviewDate = value;
            }
        }

        public DateTime get_HRInterviewDate
        {
            get
            {
                return HRInterviewDate;
            }
            set
            {
                HRInterviewDate = value;
            }
        }
    }
}
