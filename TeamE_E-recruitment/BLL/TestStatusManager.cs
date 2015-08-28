



/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestStatusManager.cs
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
    public class TestStatusManager : ITestStatusManager 
    {
        public List<ITestStatus> GetTestStatus(int vid)
        {
           
            ITestStatusDB objTestStatusDB = TestStatusDBFactory.Create_TestStatusDB();
            return  objTestStatusDB.GetTestStatusbyVID(vid);
            
        }
        public int  update_TestStatus(int CandidateID, string Written_TestStatus, string Technical_InterviewStatus, string HR_InterviewStatus)
        {
            ITestStatusDB objTestStatusDB = TestStatusDBFactory.Create_TestStatusDB();
            int TestStatus=0;
            if (Written_TestStatus == "pending" && Technical_InterviewStatus == "pending" && HR_InterviewStatus == "cleared")
            {
                return 2;
            }
            if (Written_TestStatus == "pending" && Technical_InterviewStatus == "cleared" && HR_InterviewStatus == "pending")
            {
                return 3;
            }
            if (Written_TestStatus == "pending" && Technical_InterviewStatus == "cleared" && HR_InterviewStatus == "cleared")
            {
                return 4;
            }
            if (Written_TestStatus == "cleared" && Technical_InterviewStatus == "pending" && HR_InterviewStatus == "cleared")
            {
                return 5;
            }

            if (Written_TestStatus == "cleared")
            {
                TestStatus = 2;
                if (Technical_InterviewStatus == "cleared")
                {
                    TestStatus = 3;
                    if (HR_InterviewStatus == "cleared")
                    {
                        TestStatus = 4;
                    }
                }
            }
            else if (Written_TestStatus == "pending")
            {
                TestStatus = 1;
            }
            else TestStatus = 0;
            int res = objTestStatusDB.update_TestStatus(CandidateID, TestStatus);
            return res;
        }
       
       
        public bool validateTest(int Vac_ID,int Cand_ID, DateTime date)
        {
            TimeSpan diff,diff1,diff2;
            List<ITestStatus> list_validate = GetTestStatus(Vac_ID);
            foreach (ITestStatus element in list_validate)
            {
                if (element.get_CandidateID == Cand_ID)
                {
                   diff=date-element.get_Written_TestDate;
                   diff1 = date - element.get_Technical_InterviewDate;
                   diff2 = date - element.get_HR_InterviewDate;
                    if (diff.Days<=3 && diff.Days>=0)
                            return true;


                    else if (diff1.Days<=3 && diff1.Days>=0)
                            return true;


                    else if (diff2.Days<=3 && diff2.Days>=0)
                            return true;
                   
                    else { return false; }
                }
            }
            return false;
        }

        public int updatetest(int Vac_ID, int cand_ID, string type, DateTime date)
        {
            ITestDB objTestDB = TestDBFactory.CreateTestDB();
            List<ITestStatus> teststatus_list = GetTestStatus(Vac_ID);
            foreach (ITestStatus element in teststatus_list)
            {
                if (element.get_CandidateID == cand_ID)
                {
                    if (type == "written")
                    {
                       return objTestDB.updateTest(cand_ID, date, element.get_Technical_InterviewDate, element.get_HR_InterviewDate);
                       
                    }
                    else if (type == "technical")
                    {
                        return objTestDB.updateTest(cand_ID, element.get_Written_TestDate, date, element.get_HR_InterviewDate);
                        
                    }
                    else if (type == "HR")
                    {
                        return objTestDB.updateTest(cand_ID, element.get_Written_TestDate, element.get_Technical_InterviewDate, date);
                        
                    } 
                }
               
            }
            return 0;
        }

          
       

    }
}
