


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: PlacementConsultantDB.cs
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
    public class PlacementConsultantDB : IPlacementConsultantDB
    {
        // To retrieve all the placement consultants
        public List<IPlacementConsultant> getPlacementConsultants()
        {
            List<IPlacementConsultant> lstPlacementConsultant = new List<IPlacementConsultant>();
            SqlCommand mycommand;
            SqlConnection myconnection = DBUtility.getConnection();
           
            try
            {
                using (myconnection)
                {
                    mycommand = new SqlCommand("sp_getPlacementConsultants", myconnection);
                    mycommand.CommandType = CommandType.StoredProcedure;
                    myconnection.Open();
                    SqlDataReader objSqlDataReader = mycommand.ExecuteReader();
                   
                   
                    while (objSqlDataReader.Read())
                    {
                        int PlacementConsultantID = Int32.Parse(objSqlDataReader["PlacementConsultantID"].ToString());
                        string PlacementConsultantName = (string)objSqlDataReader["PlacementConsultantName"];
                        string password = (string)objSqlDataReader["Password"];
                        string details = (string)objSqlDataReader["Details"];


                        IPlacementConsultant objPlacementConsultant = PlacementConsultantFactory.Create_PlacementConsultant(PlacementConsultantID, PlacementConsultantName, password, details);

                        lstPlacementConsultant.Add(objPlacementConsultant);
                    }
                    objSqlDataReader.Close();
                }
                return lstPlacementConsultant;
            }

            catch (Exception EE)
            {
                Console.WriteLine(EE);
                Console.Read();
                return null;
            }
            finally
            {
                myconnection.Close();
            }
           
        }
    }
}
