


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: CandidateProfileFactory.cs
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
    public class CandidateProfileFactory
    {
        private static ICandidateProfile objCandidateProfile = null;

        public static ICandidateProfile create_Candidate(int VacancyID, int CandidateProfileID ,DateTime DOB, String Location, String Gender, float Percentage_10, float Percentage_12, int GapInEducation, int GapInExperience  , int TestID  , int TestStatus  , int MedicalTestStatus , int BGCTestID , bool BGCTestStatus , String ResumeFile)
        {
            objCandidateProfile = new CandidateProfile( VacancyID,CandidateProfileID ,DOB, Location, Gender, Percentage_10, Percentage_12, GapInEducation, GapInExperience  , TestID  , TestStatus  , MedicalTestStatus , BGCTestID , BGCTestStatus , ResumeFile);
            return objCandidateProfile;
        }

        public static ICandidateProfile create_Candidates()
        {
            objCandidateProfile = new CandidateProfile();
            return objCandidateProfile;
        }
    }
}
