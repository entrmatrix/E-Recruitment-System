


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestStatusDB.cs
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
using System.Data.SqlClient;
using System.Data;
using E_Recruitment.Types;
using E_Recruitment.BOFactory;

namespace E_Recruitment.DAL
{
    public class TestStatusDB : ITestStatusDB 
    {
        // To retrieve Test Status using Vacancy ID
        public List<ITestStatus> GetTestStatusbyVID(int vid)
        {
            List<ITestStatus> lstTestStatus = new List<ITestStatus>();
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {
                
                using (objMyConnection)
                {
                    objMyCommand = new SqlCommand("spgetTestStatus", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyCommand.Parameters.AddWithValue("@VID", vid);
                    objMyConnection.Open();
                    SqlDataReader objSqlDataReader = objMyCommand.ExecuteReader();
                    while (objSqlDataReader.Read())
                    {
                        int CandidateID = Int32.Parse(objSqlDataReader["CandidateProfileID"].ToString());
                        DateTime WrittenTestDate = Convert.ToDateTime(objSqlDataReader["WrittenTestDate"]);
                        string WrittenTestStatus = Convert.ToString(objSqlDataReader["WrittenTestStatus"]);
                        DateTime TechnicalInterviewDate = Convert.ToDateTime(objSqlDataReader["TechnicalInterviewDate"]);
                        string TechnicalInterviewStatus = Convert.ToString(objSqlDataReader["TechnicalInterviewStatus"]);
                        DateTime HRInterviewDate = Convert.ToDateTime(objSqlDataReader["HRInterviewDate"]);
                        string HRInterviewStatus = Convert.ToString(objSqlDataReader["HRInterviewStatus"]);
                        int TestID = Convert.ToInt32(objSqlDataReader["TestID"]);
                        ITestStatus objTestStatus = TestStatusFactory.Create_TestStatus(CandidateID, WrittenTestDate, WrittenTestStatus, TechnicalInterviewDate, TechnicalInterviewStatus, HRInterviewDate, HRInterviewStatus, TestID);
                        lstTestStatus.Add(objTestStatus);
                    }
                    objSqlDataReader.Close();
                   
                }
                return lstTestStatus;
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
        // To update Test Status using Vacancy ID and Candidate ID
        public int update_TestStatus(int CandidateID, int TestStatus)
        {
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {
                using (objMyConnection)
                {

                    objMyCommand = new SqlCommand("sp_ChangeTestStatus", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyCommand.Connection = objMyConnection;
                    objMyConnection.Open();
                    objMyCommand.Parameters.AddWithValue("@CandidateProfileID", CandidateID);
                    objMyCommand.Parameters.AddWithValue("@TestStatus", TestStatus);
                    return objMyCommand.ExecuteNonQuery();
                }

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
    }
}
