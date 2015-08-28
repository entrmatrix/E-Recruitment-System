
/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: CandidateDB.cs
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
    public class CandidateDB : ICandidateDB
    {
        // to save data into data base
        public int save(ICandidateProfile objCandidateProfile)
        {
            int result = 0;
            SqlCommand myCommand;
            SqlConnection myConnection = DBUtility.getConnection();
            try
            {
                using (myConnection)
                {

                    myCommand = new SqlCommand("sp_save", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@VacancyID", objCandidateProfile.get_VacancyID);
                    myCommand.Parameters.AddWithValue("@DOB", objCandidateProfile.get_DOB);
                    myCommand.Parameters.AddWithValue("@Location", objCandidateProfile.get_Location);
                    myCommand.Parameters.AddWithValue("@Gender", objCandidateProfile.get_Gender);
                    myCommand.Parameters.AddWithValue("@Percentage_10", objCandidateProfile.get_Percentage_10);
                    myCommand.Parameters.AddWithValue("@Percentage_12", objCandidateProfile.get_Percentage_12);
                    myCommand.Parameters.AddWithValue("@GapInEducation", objCandidateProfile.get_GapInEducation);
                    myCommand.Parameters.AddWithValue("@GapInExperience", objCandidateProfile.get_GapInExperience);
       
                    myCommand.Parameters.AddWithValue("@TestID", objCandidateProfile.get_TestID);
                    myCommand.Parameters.AddWithValue("@TestStatus", objCandidateProfile.get_TestStatus);
                    myCommand.Parameters.AddWithValue("@MedicalTestStatus", objCandidateProfile.get_MedicalTestStatus);
                    myCommand.Parameters.AddWithValue("@BGCTestID", objCandidateProfile.get_BGCTestID);
                    myCommand.Parameters.AddWithValue("@BGCTestStatus", objCandidateProfile.get_BGCTestStatus);

                    myConnection.Open();
                    result = myCommand.ExecuteNonQuery();
                }
                return result;
            }
            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return 0;
            }
            finally
            {
               myConnection.Close();
            }
        }

        // To retrieve all candidates from database
        public List<ICandidateProfile> getCandidates()
        {
            List<ICandidateProfile> lstCandidateProfile = new List<ICandidateProfile>();
            SqlCommand myCommand;
            SqlConnection myConnection = DBUtility.getConnection();
            try
            {
                using (myConnection)
                {
                    myCommand = new SqlCommand("SP_getCandidates", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();
                    SqlDataReader objSqlDataReader = myCommand.ExecuteReader();
                    while (objSqlDataReader.Read())
                    {
                        int CandidateProfileID = Convert.ToInt32(objSqlDataReader["CandidateProfileID"]);
                        int VacancyID = Convert.ToInt32(objSqlDataReader["VacancyID"]);
                        DateTime DOB = Convert.ToDateTime(objSqlDataReader["DOB"]);
                        string Location = Convert.ToString(objSqlDataReader["Location"]);
                        string Gender = Convert.ToString(objSqlDataReader["Gender"]);
                        float Percentage_10 = Convert.ToSingle(objSqlDataReader["Percentage_10"]);
                        float Percentage_12 = Convert.ToSingle(objSqlDataReader["Percentage_12"]);
                        int GapInEducation = Convert.ToInt32(objSqlDataReader["GapInEducation"]);
                        int GapInExperience = Convert.ToInt32(objSqlDataReader["GapInExperience"]);
                        string ResumeFile = Convert.ToString(objSqlDataReader["ResumeFile"]);
                        int TestID = Convert.ToInt32(objSqlDataReader["TestID"]);
                        int TestStatus = Convert.ToInt32(objSqlDataReader["TestStatus"]);
                        int MedicalTestStatus = Convert.ToInt32(objSqlDataReader["MedicalTestStatus"]);
                        int BGCTestID = Convert.ToInt32(objSqlDataReader["BGCTestID"]);
                        bool BGCTestStatus = Convert.ToBoolean(objSqlDataReader["BGCTestStatus"]);
                        ICandidateProfile objcandidate = CandidateProfileFactory.create_Candidate(VacancyID, CandidateProfileID, DOB, Location, Gender, Percentage_10, Percentage_12, GapInEducation, GapInExperience, TestID, TestStatus, MedicalTestStatus, BGCTestID, BGCTestStatus, ResumeFile);
                        lstCandidateProfile.Add(objcandidate);
                    }
                    objSqlDataReader.Close();
                
                }
                return lstCandidateProfile;
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

        // To update candidates
        public int updateCandidates(ICandidateProfile objCandidateProfile)
        {
            int result = 0;
            SqlCommand myCommand;
            SqlConnection myConnection = DBUtility.getConnection();
            try
            {
                using (myConnection)
                {
                    myCommand = new SqlCommand("sp_updateCandidates", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@CandidateProfileID", objCandidateProfile.get_CandidateProfileID);
                    myCommand.Parameters.AddWithValue("@VacancyID", objCandidateProfile.get_VacancyID);
                    myCommand.Parameters.AddWithValue("@DOB", objCandidateProfile.get_DOB);
                    myCommand.Parameters.AddWithValue("@Location", objCandidateProfile.get_Location);
                    myCommand.Parameters.AddWithValue("@Gender", objCandidateProfile.get_Gender);
                    myCommand.Parameters.AddWithValue("@Percentage_10", objCandidateProfile.get_Percentage_10);
                    myCommand.Parameters.AddWithValue("@Percentage_12", objCandidateProfile.get_Percentage_12);
                    myCommand.Parameters.AddWithValue("@GapInEducation", objCandidateProfile.get_GapInEducation);
                    myCommand.Parameters.AddWithValue("@GapInExperience", objCandidateProfile.get_GapInExperience);
                    myCommand.Parameters.AddWithValue("@TestID", objCandidateProfile.get_TestID);
                    myCommand.Parameters.AddWithValue("@TestStatus", objCandidateProfile.get_TestStatus);
                    myCommand.Parameters.AddWithValue("@MedicalTestStatus", objCandidateProfile.get_MedicalTestStatus);
                    myConnection.Open();
                    result = myCommand.ExecuteNonQuery();
                    
                }
                return result;
            }
            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return 0;
            }
            finally
            {
                myConnection.Close();
            }

        }

        // To delete candidates
        public int delete(int CandidateID)
        {
             int result = 0;
             SqlCommand myCommand;
             SqlConnection myConnection = DBUtility.getConnection();
             try
             {
                 using (myConnection)
                 {
                     myCommand = new SqlCommand("sp_delete", myConnection);
                     myCommand.CommandType = CommandType.StoredProcedure;
                     myCommand.Parameters.AddWithValue("@CandidateProfileID", CandidateID);
                     myConnection.Open();
                     result = myCommand.ExecuteNonQuery();
                 }
                 return result;
             }
             catch (Exception EE)
             {
                 Console.WriteLine(EE);
                 Console.Read();
                 return 0;
             }
             finally
             {
                 myConnection.Close();
             }

        }






        public List<int> Vacancies()
        {
            List<int> lstVacancyIDs = new List<int>();
            SqlCommand mycommand;
            SqlConnection myconnection = DBUtility.getConnection();
            try
            {
                using(myconnection)
                {
                mycommand = new SqlCommand("sp_VacancyID",myconnection);
                mycommand.CommandType = CommandType.StoredProcedure;
                myconnection.Open();
                SqlDataReader dr = mycommand.ExecuteReader();
                int i;
                while (dr.Read())
                {
                    i = (int)dr[0];
                    lstVacancyIDs.Add(i);
                }
                dr.Close();
                }
                return lstVacancyIDs;
            }
            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return null;
            }
            finally
            {
                if(myconnection!=null)
                myconnection.Close();
            }              
        }
    }
}
