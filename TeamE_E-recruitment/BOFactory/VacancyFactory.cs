


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: VacancyFactory.cs
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
     public class VacancyFactory
    {
        private static IVacancy objVacancy = null;

        public static IVacancy Create_Vacancy(int VacancyID, int NoOfPositions, String Skills, int Experience, String Location, String BusinessDomain, DateTime RequiredByDate, int Status, int VacancyRequestID, int RecruitmentRequestID)
        {
            objVacancy = new Vacancy(VacancyID, NoOfPositions, Skills, Experience, Location, BusinessDomain, RequiredByDate, Status, VacancyRequestID, RecruitmentRequestID);
            return objVacancy;
        } 
    }
}
