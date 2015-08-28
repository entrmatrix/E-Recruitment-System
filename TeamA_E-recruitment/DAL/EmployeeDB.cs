using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BussinessObjectFactory;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

    public class EmployeeDB : IEmployeeDB
    {
        IEmployee employee = null;

        public IEmployee SelectEmployeeDetails(int employeeID,string password)
        {
            SqlConnection conn = DBUtility.GetConnection();

            employee = null;

            SqlConnection myConnection = DBUtility.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_employeeinfo_667015";   //employe stored procedure
            cmd.Parameters.AddWithValue("@employee_id", employeeID);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            //int i = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //i = 1;
                int empID= reader.GetInt32(0);
                string name = reader.GetString(1);
                string domain = reader.GetString(4);
                bool isHR = false;
                if (!reader.IsDBNull(3))
                {
                    isHR = reader.GetBoolean(3);
                }
                int unitHeadID = 0;
                if (!reader.IsDBNull(2))
                {
                    unitHeadID = reader.GetInt32(2);
                }
                employee=EmployeeFactory.CreateEmployee(name, empID, isHR, unitHeadID, domain);

            }
            
                return employee;
          
        }
    }
}
