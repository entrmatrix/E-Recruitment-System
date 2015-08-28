


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: EmployeeDB.cs
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
    public class EmployeeDB : IEmployeeDB
    {
        // To retrieve all the employees
        public List<IEmployee> getEmployees()
        {
            List<IEmployee> lstEmployee = new List<IEmployee>();
            SqlCommand myCommand;
            SqlConnection myConnection = DBUtility.getConnection();
            try
            {

                using (myConnection)
                {

                    myCommand = new SqlCommand("sp_Employee", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myConnection.Open();
                    SqlDataReader objSqlDataReader = myCommand.ExecuteReader();

                    while (objSqlDataReader.Read())
                    {

                        int EmployeeID = Int32.Parse(objSqlDataReader["EmployeeID"].ToString());
                        string Designation = (string)objSqlDataReader["Designation"];
                        string password = (string)objSqlDataReader["Password"];
                        bool isHr = (bool)(objSqlDataReader["IsHR"]);
                        DateTime dob = (DateTime)objSqlDataReader["DOB"];
                        DateTime doj = (DateTime)objSqlDataReader["DOJ"];
                        int projid = Int32.Parse(objSqlDataReader["ProjectID"].ToString());
                        string gender = (string)objSqlDataReader["Gender"];
                        string division = (string)objSqlDataReader["Division"];
                        float ctc = float.Parse(Convert.ToString(objSqlDataReader["CTC"]));
                        string location = (string)objSqlDataReader["Location"];
                        int exp = (int)objSqlDataReader["Experience"];

                        string EmployeeName = (string)objSqlDataReader["EmployeeName"];
                        int UnitHeadID;
                        if (objSqlDataReader.IsDBNull(2))
                        {
                            UnitHeadID = 0;
                        }
                        else
                        {
                            UnitHeadID = Convert.ToInt32(objSqlDataReader["UnitHeadID"]);
                        }

                        IEmployee newemployee = EmployeeFactory.Create_employee(EmployeeID, EmployeeName, UnitHeadID, projid, isHr, dob, doj, gender, division, ctc, Designation, password, location, exp);
                        lstEmployee.Add(newemployee);
                    }
                    objSqlDataReader.Close();

                }
                return lstEmployee;

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


        public List<IEmployee> List_Employees()
        {
            List<IEmployee> lstEmployee = new List<IEmployee>();
            SqlCommand myCommand;
            SqlConnection myConnection = DBUtility.getConnection();
            try
            {
                using (myConnection)
                {

                    myCommand = new SqlCommand("sp_EmployeeList", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myConnection.Open();
                    SqlDataReader objSqlDataReader = myCommand.ExecuteReader();

                    while (objSqlDataReader.Read())
                    {

                        int EmployeeID = Int32.Parse(objSqlDataReader["EmployeeID"].ToString());
                        string Designation = (string)objSqlDataReader["Designation"];
                        string password = (string)objSqlDataReader["Password"];
                        bool isHr = (bool)objSqlDataReader["IsHR"];
                        DateTime dob = (DateTime)objSqlDataReader["DOB"];
                        DateTime doj = (DateTime)objSqlDataReader["DOJ"];
                        int projid = Int32.Parse(objSqlDataReader["ProjectID"].ToString());
                        string gender = (string)objSqlDataReader["Gender"];
                        string division = (string)objSqlDataReader["Division"];
                        float ctc = float.Parse(Convert.ToString(objSqlDataReader["CTC"]));
                        string location = (string)objSqlDataReader["Location"];
                        int exp = (int)objSqlDataReader["Experience"];

                        string EmployeeName = (string)objSqlDataReader["EmployeeName"];
                        int UnitHeadID;
                        try
                        {
                            UnitHeadID = (int)objSqlDataReader["UnitHeadID"];
                        }
                        catch (Exception)
                        {
                            UnitHeadID = 0;
                        }

                        IEmployee newemployee = EmployeeFactory.Create_employee(EmployeeID, EmployeeName, UnitHeadID, projid, isHr, dob, doj, gender, division, ctc, Designation, password, location, exp);
                        lstEmployee.Add(newemployee);


                    }
                    objSqlDataReader.Close();
                }
                return lstEmployee;
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
