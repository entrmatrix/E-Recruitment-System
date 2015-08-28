


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Candidate_TestFactory.cs
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
    public class Candidate_TestFactory
    {
        private static ICandidate_Test objCandidateTest = null;
        public static ICandidate_Test create_Candidate_Test(int VacancyID, int CandidateProfileID, DateTime DOB, String Gender, int TestID, int TestStatus, DateTime WrittenTestDate, DateTime TechnicalInterviewDate, DateTime HRInterviewDate)
        {
            objCandidateTest = new Candidate_Test(VacancyID, CandidateProfileID, DOB, Gender, TestID, TestStatus, WrittenTestDate, TechnicalInterviewDate, HRInterviewDate);
            return objCandidateTest;
        }
    }
}
