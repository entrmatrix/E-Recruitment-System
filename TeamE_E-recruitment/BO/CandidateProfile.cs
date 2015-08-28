


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: CandidateProfile.cs
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
    public class CandidateProfile : ICandidateProfile 
    {
        private int VacancyID;
        private int CandidateProfileID ;
        private DateTime DOB;
        private String Gender ;
        private String Location ;
        private float Percentage_10 ;
        private float Percentage_12 ;
        private int GapInEducation ;
        private int GapInExperience;
        private int TestID ;
        private int TestStatus;
        private int MedicalTestStatus ;
        private int BGCTestID ;
        private bool BGCTestStatus ;
        private String ResumeFile;

        public CandidateProfile()
        {
        }

        public CandidateProfile(int VacancyID, int CandidateProfileID ,DateTime DOB, String Location, String Gender, float Percentage_10, float Percentage_12, int GapInEducation, int GapInExperience  , int TestID  , int TestStatus  , int MedicalTestStatus , int BGCTestID , bool BGCTestStatus , String ResumeFile)
        {
            this.CandidateProfileID = CandidateProfileID;
            this.VacancyID = VacancyID;
            this.DOB = DOB;
            this.Location = Location;
            this.Gender = Gender;
            this.Percentage_10 = Percentage_10;
            this.Percentage_12 = Percentage_12;
            this.GapInEducation = GapInEducation;
            this.GapInExperience = GapInExperience;
            this.TestID= TestID;
            this.TestStatus= TestStatus;
            this.MedicalTestStatus= MedicalTestStatus;
            this.BGCTestID= BGCTestID;
            this.BGCTestStatus= BGCTestStatus;
            this. ResumeFile=ResumeFile;
        }

        public DateTime get_DOB
        {
            get { return DOB; }
            set { DOB = value; }
        }

        public String get_Location
        {
            get { return Location; }
            set { Location = value; }
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

        public float get_Percentage_10
        {
            get
            {
                return Percentage_10;
            }
            set
            {
                Percentage_10 = value;
            }

        }


        public float get_Percentage_12
        {
            get
            {
                return Percentage_12;
            }
            set
            {
                Percentage_12 = value;
            }

        }


        public int get_GapInEducation
        {
            get
            {
                return GapInEducation;
            }
            set
            {
                GapInEducation = value;
            }

        }


        public int get_GapInExperience
        {
            get
            {
                return GapInExperience;
            }
            set
            {
                GapInExperience = value;
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
                return TestID ;
            }
            set
            {
                TestID  = value;
            }

            }
         public int get_TestStatus 
              {
              get
            {
                return TestStatus  ;
            }
            set
            {
                TestStatus   = value;
            }
            }
         public int get_MedicalTestStatus
              {
                get
            {
                return MedicalTestStatus  ;
            }
            set
            {
                MedicalTestStatus   = value;
            }
            }
         public int get_BGCTestID 
              {
                  get
            {
                return BGCTestID   ;
            }
            set
            {
                BGCTestID    = value;
            }
            }
         public bool get_BGCTestStatus 
              {
                    get
            {
                return BGCTestStatus;
            }
            set
            {
                BGCTestStatus= value;
            }
            }

         public String get_ResumeFile
         {
             get
             {
                 return ResumeFile;
             }
             set
             {
                 ResumeFile = value;
             }

         }

    }
}
