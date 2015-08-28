


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestDB.cs
Description of the file: Used in Data Access Layer.
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
using System.Data;
using System.Data.SqlClient;
using E_Recruitment.Types;
using E_Recruitment.BOFactory;

namespace E_Recruitment.DAL
{
    public class TestDB : ITestDB
    {
        // To update Test Dates
        public bool SaveTestDates(int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate)
        {
            
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            
            try
            {
               using(objMyConnection)
               {
                objMyCommand = new SqlCommand("spAddTest", objMyConnection);
                objMyCommand.CommandType = CommandType.StoredProcedure;
                objMyCommand.Parameters.AddWithValue("@TestAdministratorID", TestAdminID);
                objMyCommand.Parameters.AddWithValue("@RecruitmentRequestID", 0);
                objMyCommand.Parameters.AddWithValue("@VacancyID", VacancyID);
                objMyCommand.Parameters.AddWithValue("@WrittenTestDate", WrittenTestDate);
                objMyCommand.Parameters.AddWithValue("@TechnicalInterviewDate", TechnicalTestDate);
                objMyCommand.Parameters.AddWithValue("@HRInterviewDate", HRInterviewDate);
                objMyConnection.Open();
                objMyCommand.ExecuteNonQuery();
               
               }
               return true;
            }

            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return false;

            }
            finally
            {
                objMyConnection.Close();
            }

        }

        //To retrieve Test Details
        public List<ITest> Get_TestDetails()
        {
            List<ITest> lstTest = new List<ITest>();
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {
                using (objMyConnection)
                {
                    objMyCommand = new SqlCommand("sp_getTest", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyConnection.Open();
                    SqlDataReader objSqlDataReader = objMyCommand.ExecuteReader();
                    while (objSqlDataReader.Read())
                    {
                        int TestID = Int32.Parse(objSqlDataReader["TestID"].ToString());
                        int TestAdminID = Int32.Parse(objSqlDataReader["TestAdministratorID"].ToString());
                        int VacancyID = Int32.Parse(objSqlDataReader["VacancyID"].ToString());
                        DateTime WrittenTestDate = DateTime.Parse(objSqlDataReader["WrittenTestDate"].ToString());
                        DateTime TechnicalInterviewDate = DateTime.Parse(objSqlDataReader["TechnicalInterviewDate"].ToString());
                        DateTime HRInterviewDate = DateTime.Parse(objSqlDataReader["HRInterviewDate"].ToString());
                        ITest tl = TestFactory.Create_Test(TestID, TestAdminID, VacancyID, WrittenTestDate, TechnicalInterviewDate, HRInterviewDate);
                        lstTest.Add(tl);
                    }
                    objSqlDataReader.Close();
                }
                return lstTest;
            }
            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return null;
            }
            finally
            {
                objMyConnection.Close();
            }
     }

        // To update Test
        public int updateTest(int cand_ID,DateTime written,DateTime tech,DateTime HR )
        {
           
            int i=0;
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {
                using (objMyConnection)
                {

                    objMyCommand = new SqlCommand("sp_updateTest", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyCommand.Connection = objMyConnection;
                    objMyConnection.Open();
                    objMyCommand.Parameters.AddWithValue("@CandidateProfileID", cand_ID);
                    objMyCommand.Parameters.AddWithValue("@WrittenTestDate", written);
                    objMyCommand.Parameters.AddWithValue("@TechnicalInterviewDate", tech);
                    objMyCommand.Parameters.AddWithValue("@HRInterviewDate", HR);
                    objMyCommand.ExecuteNonQuery();
                    i++;
                }
                return i;

            }
            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return 0;
            }
            finally
            {
                objMyConnection.Close();
            }
           
        }

        public bool isavailable_withVacancyID(int VacancyID)
        {
            return false;
        }

    }
}
