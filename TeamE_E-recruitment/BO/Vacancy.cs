


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Vacancy.cs
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
    public class Vacancy : IVacancy  
    {
        private int VacancyID;
        private int NoOfPositions;
        private String Skills;
        private int Experience;
        private String Location;
        private String BusinessDomain;
        private DateTime RequiredByDate;
        private int Status;
        private int VacancyRequestID;
        private int RecruitmentRequestID;

           public Vacancy(int VacancyID,int NoOfPositions,String Skills,int Experience,String Location,String BusinessDomain,DateTime RequiredByDate,int Status,int VacancyRequestID,int RecruitmentRequestID)
           {
            this.VacancyID=VacancyID;
            this.NoOfPositions=NoOfPositions;
            this.Skills=Skills;
            this.Experience=Experience;
            this.Location=Location;
            this.BusinessDomain=BusinessDomain;
            this.RequiredByDate=RequiredByDate;
            this.Status=Status;
            this.VacancyRequestID=VacancyRequestID;
            this.RecruitmentRequestID=RecruitmentRequestID;
          }

        public int get_VacancyID
          
        {
            get {return VacancyID;}
            set {  VacancyID = value; }
        }
        public int get_NoOfPositions
         {
            get {return NoOfPositions;}
            set {  NoOfPositions = value; }
        }
        public String get_Skills
        {
            get {return Skills;}
            set {  Skills = value; }
        }
        
       public int get_Experience
        {
            get { return Experience; }
            set { Experience = value; }
        }
       public String get_Location
        {
            get { return Location; }
            set { Location = value; }
        }
       public String get_BusinessDomain
        {
            get { return BusinessDomain; }
            set { BusinessDomain = value; }
        }
       public DateTime get_RequiredByDate
        {
           get { return RequiredByDate; }
           set { RequiredByDate = value; }
        }
       public int get_Status
        {
            get {return Status;}
            set {  Status = value; }
        }
       public int get_VacancyRequestID
        {
           get { return VacancyRequestID; }
           set { VacancyRequestID = value; }
        }
        public int get_RecruitmentRequestID
        {
         get { return RecruitmentRequestID; }
         set { RecruitmentRequestID = value; }
        }
    }
}
