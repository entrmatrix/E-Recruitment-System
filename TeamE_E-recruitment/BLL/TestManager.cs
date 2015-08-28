



/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestManager.cs
Description of the file: Used as Business Logic Layer.
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
using E_Recruitment.DALFactory;

namespace E_Recruitment.BLL
{
    public class TestManager : ITestManager 
    {
        public int TestID = 0;
        private List<ITest> listTest = new List<ITest>();
        private DateTime RequiredByDate;
        public TestManager()
        {
            listTest = new List<ITest>();

        }
        public List<ITest> get_list_Test
        {
            set { listTest = value; }
            get { return listTest; }
        }

        // To retrieve all Tests
        public List<ITest> GetTest()
        {
            List<ITest> list_Test = new List<ITest>();
            ITestDB objTestDB = TestDBFactory.CreateTestDB();
            list_Test = objTestDB.Get_TestDetails();
            return list_Test;
        }


        public int  Validate_VacancyID(int TestAdminID, int VacancyID)
        {
        
            int  isAvailable = 0;

            foreach (ITest objTest in listTest)
            {
                if (objTest.get_TestAdministratorID.Equals(TestAdminID) && objTest.get_VacancyID.Equals(VacancyID))
                {
                    
                    isAvailable = 1;
                    break;
                }
            }

            foreach (ITest test in listTest)
            {
                if (test.get_VacancyID == VacancyID)
                {
                    
                    break;
                }

            }
            return isAvailable;

        }
        public int  CheckDetails(int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate)
        {
            
            int exist = Validate_VacancyID(TestAdminID, VacancyID);

            if (exist == 1)
            {
                return 1;
            }
            else if (exist == 2)
            {
                return 2;
            }

            VacancyManager objVacancyManager = new VacancyManager();
            List<IVacancy> ListVacancy = new  List<IVacancy>();
            ListVacancy = objVacancyManager.GetVacancy();
            
            foreach (IVacancy objVacancy in ListVacancy)
            {
                if (VacancyID == objVacancy.get_VacancyID)
                {
                    RequiredByDate = objVacancy.get_RequiredByDate;
                }
            }
            if (WrittenTestDate < DateTime.Now)
            {
                return 3;
            }
            else if (TechnicalTestDate < DateTime.Now)
            {
                return 4;
            }
            else if (HRInterviewDate < DateTime.Now)
            {
                return 5;
            }
            else if (WrittenTestDate == TechnicalTestDate)
            {
                return 6;
            }
            else if (TechnicalTestDate == HRInterviewDate)
            {
                return 7;
            }
            else if (HRInterviewDate == WrittenTestDate)
            {
                return 8;
            }
            else if (WrittenTestDate == TechnicalTestDate && TechnicalTestDate == HRInterviewDate)
            {
                return 9;
            }
            else if (WrittenTestDate > RequiredByDate)
            {
                return 10;
            }
            else if (TechnicalTestDate > RequiredByDate)
            {
                return 11;
            }
            else if (HRInterviewDate > RequiredByDate)
            {
                return 12;
            }
            else if (WrittenTestDate > TechnicalTestDate)
            {
                return 13;
            }
            else if (TechnicalTestDate > HRInterviewDate)
            {
                return 14;
            }
            else if (WrittenTestDate > HRInterviewDate)
            {
                return 15;
            }
            else if (TechnicalTestDate < WrittenTestDate.AddDays(2))
            {
                return 16;
            }
            else if (HRInterviewDate < TechnicalTestDate.AddDays(2))
            {
                return 17;
            }
            else
            {
                return 0;
            }

        }
        public int  Validate(int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate)
        {
            ITestDB objTestDB = TestDBFactory.CreateTestDB();
            listTest = objTestDB.Get_TestDetails();
            int success = CheckDetails(TestAdminID, VacancyID, WrittenTestDate, TechnicalTestDate, HRInterviewDate);
            if (success==0)
            {
                TestID++;
                objTestDB.SaveTestDates(TestAdminID, VacancyID, WrittenTestDate, TechnicalTestDate, HRInterviewDate);
                return 0;
            }
            else
                return success;
        }
    }
}
