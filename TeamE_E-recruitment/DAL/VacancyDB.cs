


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: VacancyDB.cs
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
    public class VacancyDB : IVacancyDB
    {
       // To retrieve all the vacancies
        public List<IVacancy> GetVacancy()
        {
            List<IVacancy> lstVacancy = new List<IVacancy>();
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {

                using (objMyConnection)
                {
                    objMyCommand = new SqlCommand("sp_getVacancy", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyConnection.Open();
                    SqlDataReader objSqlDataReader = objMyCommand.ExecuteReader();
                    while (objSqlDataReader.Read())
                    {
                        int VacancyID = Int32.Parse(objSqlDataReader["VacancyID"].ToString());
                        int NoOfPositions = Int32.Parse(objSqlDataReader["NoOfPositions"].ToString());
                        String Skills = objSqlDataReader["Skills"].ToString();
                        int Experience = Int32.Parse(objSqlDataReader["Experience"].ToString());
                        String Location = objSqlDataReader["Location"].ToString();
                        String BusinessDomain = objSqlDataReader["BusinessDomain"].ToString();
                        DateTime RequiredByDate = DateTime.Parse(objSqlDataReader["RequiredByDate"].ToString());
                        int Status = Int32.Parse(objSqlDataReader["Status"].ToString());
                        int VacancyRequestID = Int32.Parse(objSqlDataReader["VacancyRequestID"].ToString());
                        int RecruitmentRequestID = Int32.Parse(objSqlDataReader["RecruitmentRequestID"].ToString());

                        IVacancy v = VacancyFactory.Create_Vacancy(VacancyID, NoOfPositions, Skills, Experience, Location, BusinessDomain, RequiredByDate, Status, VacancyRequestID, RecruitmentRequestID);
                        lstVacancy.Add(v);
                    }
                    objSqlDataReader.Close();

                }
                return lstVacancy;
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

        // To update Vacancy Status
        public int updateStatus(int vacancy,int status)
        {
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {   
                using (objMyConnection)
                {
                    objMyCommand = new SqlCommand("sp_updateVacancyStatus", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyConnection.Open();
                    objMyCommand.Parameters.AddWithValue("@ID", vacancy);
                    objMyCommand.Parameters.AddWithValue("@status", status);
                    int done = objMyCommand.ExecuteNonQuery();
                    return done;
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




        
