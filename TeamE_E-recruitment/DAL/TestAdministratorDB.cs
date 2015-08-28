using System;
using System.Collections.Generic;
using System.Linq;



/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: TestAdministratorDB.cs
Description of the file: Used in Data Access Layer.
 * This source is subject to the to ABC Public License. 
 * http://www.abc.erecruitment.com/  
 * All other rights reserved.  
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  EITHER 
 * EXPRESSED  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED  WARRANTIES OF
 * MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*********************************************************************/


using System.Text;
using System.Data.SqlClient;
using System.Data;
using E_Recruitment.Types;
using E_Recruitment.BOFactory;


namespace E_Recruitment.DAL
{
      public class TestAdministratorDB : ITestAdministratorDB 
      {
        
        // To retrieve all the testadministrators
        public List<ITestAdministrator> GetList()
        {
            List<ITestAdministrator> lstTestAdministrator = new List<ITestAdministrator>();
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {

                using (objMyConnection)
                {

                    objMyCommand = new SqlCommand("sp_DisplayTestAdmin", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;

                    objMyConnection.Open();
                    SqlDataReader objSqlDataReader = objMyCommand.ExecuteReader();

                    while (objSqlDataReader.Read())
                    {

                        int id = Int32.Parse(objSqlDataReader["EmployeeID"].ToString());
                        bool IsTestAdmin = bool.Parse(objSqlDataReader["IsTestAdmin"].ToString());
                        ITestAdministrator newtestadministrator = TestAdministratorFactory.Create_TestAdministrator(id, IsTestAdmin);
                        lstTestAdministrator.Add(newtestadministrator);
                    }
                    objSqlDataReader.Close();

                }
                return lstTestAdministrator;
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
        public int Save(ITestAdministrator objTestAdministrator)
        {
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {
               using (objMyConnection)
                {

                    objMyCommand = new SqlCommand("sp_AddTestAdmin", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;

                    objMyCommand.Parameters.AddWithValue("@ID", objTestAdministrator.get_EmployeeID);
                    objMyCommand.Parameters.AddWithValue("@isTestAdmin", objTestAdministrator.get_IsTestAdmin);

                    objMyConnection.Open();
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
          
        public List<ITestAdministrator> getTestAdministrators()
        {
              List<ITestAdministrator> lstTestAdministrator = new List<ITestAdministrator>();
              SqlCommand objMyCommand;
              SqlConnection objMyConnection = DBUtility.getConnection();
              try
              {
                  using (objMyConnection)
                  {
                      objMyCommand = new SqlCommand("sp_DisplayTestAdmin", objMyConnection);
                      objMyCommand.CommandType = CommandType.StoredProcedure;
                      objMyConnection.Open();
                      SqlDataReader objSqlDataReader = objMyCommand.ExecuteReader();
                      while (objSqlDataReader.Read())
                      {
                          ITestAdministrator objTestAdministrator = TestAdministratorFactory.Create_TestAdministrator(0, false);
                          objTestAdministrator.get_EmployeeID = Convert.ToInt32(objSqlDataReader[0]);
                          objTestAdministrator.get_EmployeeName = Convert.ToString(objSqlDataReader[1]);
                          objTestAdministrator.get_IsTestAdmin = Convert.ToBoolean(objSqlDataReader[2]);
                          objTestAdministrator.get_EmployeeDesignation = Convert.ToString(objSqlDataReader[3]);
                          objTestAdministrator.get_EmployeeLocation = Convert.ToString(objSqlDataReader[4]);
                          objTestAdministrator.get_EmployeeExperience = Convert.ToInt32(objSqlDataReader[5]);
                          lstTestAdministrator.Add(objTestAdministrator);
                      }
                      objSqlDataReader.Close();
                      
                  }
                  return lstTestAdministrator;
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

        public int DeleteTestAdministrators(int delete_testAdmin_ID)
        {
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            int result = 0;

            try
            {
                using (objMyConnection)
                {
                    //stored procedure to delete test admins
                    objMyCommand = new SqlCommand("sp_DeleteTestAdmin", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;

                    objMyCommand.Parameters.AddWithValue("@ID", delete_testAdmin_ID);

                    objMyConnection.Open();

                    result = objMyCommand.ExecuteNonQuery();
                    
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
                objMyConnection.Close();
            }
        }
        public int Approve(int EmployeeID)
        {
            int i;
            SqlCommand objMyCommand;
            SqlConnection objMyConnection = DBUtility.getConnection();
            try
            {
                using (objMyConnection)
                {

                    objMyCommand = new SqlCommand("sp_UpdateTestAdmin", objMyConnection);
                    objMyCommand.CommandType = CommandType.StoredProcedure;
                    objMyCommand.Parameters.AddWithValue("@ID", EmployeeID);
                    objMyConnection.Open();
                    i = objMyCommand.ExecuteNonQuery();
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
    }
}
