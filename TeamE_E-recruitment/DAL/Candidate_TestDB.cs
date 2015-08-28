


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Candidate_TestDB.cs
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
    public class Candidate_TestDB : ICandidate_TestDB 
    {
        // To retrieve all the candidates along with their test status
        public List<ICandidate_Test> getCandidates_Test()
        {
            List<ICandidate_Test> lstCandidateTest = new List<ICandidate_Test>();
            SqlCommand myCommand;
            SqlConnection myConnection = DBUtility.getConnection();
            try
            {
                using (myConnection)
                {
                    myCommand = new SqlCommand("SP_getCandidates_Test", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();
                    SqlDataReader objSqlDataReader = myCommand.ExecuteReader();
                    while (objSqlDataReader.Read())
                    {
                        int get_CandidateProfileID = Convert.ToInt32(objSqlDataReader["CandidateProfileID"]);
                        int get_VacancyID = Convert.ToInt32(objSqlDataReader["VacancyID"]);
                        DateTime get_DOB = Convert.ToDateTime(objSqlDataReader["DOB"]);
                        string get_Gender = Convert.ToString(objSqlDataReader["Gender"]);

                        int get_TestID = Convert.ToInt32(objSqlDataReader["TestID"]);
                        int get_TestStatus = Convert.ToInt32(objSqlDataReader["TestStatus"]);

                        DateTime get_HRInterviewDate = Convert.ToDateTime(objSqlDataReader["HRInterviewDate"]);
                        DateTime get_TechnicalInterviewDate = Convert.ToDateTime(objSqlDataReader["TechnicalInterviewDate"]);
                        DateTime get_WrittenTestDate = Convert.ToDateTime(objSqlDataReader["WrittenTestDate"]);

                        ICandidate_Test objCandidateTest = Candidate_TestFactory.create_Candidate_Test(get_VacancyID, get_CandidateProfileID, get_DOB, get_Gender, get_TestID, get_TestStatus, get_WrittenTestDate, get_TechnicalInterviewDate, get_HRInterviewDate);
                        lstCandidateTest.Add(objCandidateTest);
                    }
                    objSqlDataReader.Close();

                }
                return lstCandidateTest;

            }
            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
