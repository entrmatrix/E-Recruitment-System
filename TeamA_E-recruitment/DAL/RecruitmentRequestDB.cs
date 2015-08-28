using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using Types;
using BussinessObjectFactory;

namespace DAL
{
    public class RecruitmentRequestDB : IRecruitmentRequestDB
    {
        
        List<IVacancy> vacancyList = new List<IVacancy>();
        List<IRecruitmentRequest> recruitmentRequestList = new List<IRecruitmentRequest>();
        IVacancy vacancy = null;

        public int InsertRecruitmentRequest(DateTime requiredDate, int placementConsultantID,List<int> vacancyIDs)
        {                                                                       //use of vacancies selected with null recruitmentrequest
            int recruitmentRequestID = 0;
            //ADO.NET program for inserting details of recruitmentrequest

            SqlConnection myConnection = DBUtility.GetConnection();

            using (myConnection)
            {
                SqlCommand addCommand = new SqlCommand("sp_addRecruitmentRequest_667961", myConnection);
                addCommand.CommandType = CommandType.StoredProcedure;

                addCommand.Parameters.AddWithValue("@RecruitmentRequestID", recruitmentRequestID);
                addCommand.Parameters.AddWithValue("@RequiredDate", requiredDate);
                addCommand.Parameters.AddWithValue("@PlacementConsultantID", placementConsultantID);

                SqlCommand getCommand = new SqlCommand("sp_getRecruitmentRequestID_667961", myConnection);
                getCommand.CommandType = CommandType.StoredProcedure;

                myConnection.Open();
                addCommand.ExecuteNonQuery();

                SqlDataReader dr = getCommand.ExecuteReader();
                
                while (dr.Read())
                {
                    recruitmentRequestID = dr.GetInt32(0);
                }

                myConnection.Close();

                foreach (int VacancyID in vacancyIDs)
                {
                    SqlCommand updateCommand = new SqlCommand("sp_addVacanciesToRecruitmentRequest_667961", myConnection);
                    updateCommand.CommandType = CommandType.StoredProcedure;

                    updateCommand.Parameters.AddWithValue("@VacancyID", VacancyID);
                    updateCommand.Parameters.AddWithValue("@RecruitmentRequestID", recruitmentRequestID);

                    myConnection.Open();
                    updateCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
            }

            //ADO.NET program for updating vacancy table with selected vacancylist and generated recruitmentrquest ID
            return recruitmentRequestID;
        }
        public List<IVacancy> VacancyWithNULLRecruitmentRequestID() //
        {                                                                       //used for creating RecruitmentRequests
            //ADO.NET program for searching vacancies with recruitmentRequestID as null

            SqlConnection conn = DBUtility.GetConnection();
            vacancyList.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_vacancyWithNULLRecruitmentRequestID_667015";
            //cmd.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int vacancyID = reader.GetInt32(0);
                int noOfPositions = reader.GetInt32(1);
                string skills = reader.GetString(2);
                string domain = reader.GetString(3);
                int experience = reader.GetInt32(4);
                DateTime requiredDate = reader.GetDateTime(5);
                string location = reader.GetString(6);
                int status = reader.GetInt32(7);
                //retrieving all vacancies associated to the recruitmentrequestID given
                vacancy = VacancyFactory.CreateVacancy(vacancyID, noOfPositions, skills,domain, experience, requiredDate, location, status);
                vacancyList.Add(vacancy);

            }
            conn.Close();
            return vacancyList;
        }
        public List<IVacancy> SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(int recruitmentRequestID) //
        {                                                                        //used for editing RecruitmentRequests
            //ADO.NET program for searching recruitmentrequest

            SqlConnection conn = DBUtility.GetConnection();
            vacancyList.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_searchOpenStatusedVacancyOrWithNULLRecruitmentRequestID_667015";
            cmd.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int vacancyID = reader.GetInt32(0);
                int noOfPositions = reader.GetInt32(1);
                string skills = reader.GetString(2);
                string domain = reader.GetString(3);
                int experience = reader.GetInt32(4);
                DateTime requiredDate = reader.GetDateTime(5);
                string location = reader.GetString(6);
                int status = reader.GetInt32(7);

                //retrieving all vacancies associated to the recruitmentRequestID given
                vacancy = VacancyFactory.CreateVacancy(vacancyID, noOfPositions, skills,domain, experience, requiredDate, location, status);
                vacancyList.Add(vacancy);

            }
            conn.Close();
            return vacancyList;
        }
        public List<IVacancy> SearchRecruitmentRequest(int recruitmentRequestID)
        {                                                                          //used for displays the vacancies wrt to given recruitmentRequest
            //ADO.NET program for searching recruitmentRequest

            //SqlConnection myConnection = DBUtility.getConnection();

            //using (myConnection)
            //{
            //    SqlCommand myCommand = new SqlCommand("sp_searchRecruitmentRequest_667961", myConnection);
            //    myCommand.CommandType = CommandType.StoredProcedure;
            //    myCommand.Parameters.AddWithValue("@RecruitmentRequestID", recruitmentRequestID);
            //    myConnection.Open();
            //    myCommand.ExecuteNonQuery();
            //    myConnection.Close();
            //}
            //ADO.NET program for searching recruitmentrequest
            SqlConnection conn = DBUtility.GetConnection();
            vacancyList.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_searchRecruitmentRequest_667015";
            cmd.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int vacancyID = reader.GetInt32(0);
                int noOfPositions=reader.GetInt32(1);
                string skills=reader.GetString(2);
                string domain = reader.GetString(3);
                int experience = reader.GetInt32(4);
                DateTime requiredDate = reader.GetDateTime(5);
                string location = reader.GetString(6);
                int status = reader.GetInt32(7);

                //retirving all vacancies associated to the recruitmentrequestID given
                vacancy = VacancyFactory.CreateVacancy(vacancyID, noOfPositions, skills,domain, experience, requiredDate, location, status);
                vacancyList.Add(vacancy);
                
            }
            conn.Close();
            return vacancyList;
        }
      
        public int EditRecruitmentRequest(int recruitmentRequestID, List<int> vacancyID)
        {
            int result=0;
            //ADO.NET program for editing the recruitment request

            foreach (int VacancyID in vacancyID)
            { 
                SqlConnection conn = DBUtility.GetConnection();
                
                SqlCommand updateCommand = new SqlCommand();

                updateCommand.Connection = conn;
                updateCommand.CommandType = CommandType.StoredProcedure;
                updateCommand.CommandText = "sp_updateVacancy_667961";
                updateCommand.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);
                
                updateCommand.Parameters.AddWithValue("@VacancyID", VacancyID);
                
                conn.Open();
                result = updateCommand.ExecuteNonQuery();
                conn.Close();
            }

            return result;
        }
        public void UpdateNullForUpdate(int recruitmentRequestID)
        {
            SqlConnection conn = DBUtility.GetConnection();
            vacancyList.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateNullForUpdate_667015";
            cmd.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //List<IRecruitmentRequest> recruitmentRequestList=new List<IRecruitmentRequest>();
        //FUNCTION FOR GETTING THE LIST OF RECRUITMENTS
        public List<IRecruitmentRequest> SelectingRecruitmentRequest()
        {
            recruitmentRequestList.Clear();
            SqlConnection conn = DBUtility.GetConnection();
            vacancyList.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure; cmd.CommandText = "sp_SelectingRecruitmentRequest_667961";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int flag = 0;
            while (reader.Read())
            {
                flag = 1;
                int recruitmentRequestId = reader.GetInt32(0);
                DateTime requiredByDate = reader.GetDateTime(1);
                int placementConsultantID = reader.GetInt32(2);
                IRecruitmentRequest recruitmentRequest = RecruitmentRequestFactory.CreateRecruitmentRequest();
                recruitmentRequest.RecruitmentRequestID = recruitmentRequestId;
                recruitmentRequest.RequiredDate = requiredByDate;
                recruitmentRequest.PlacementConsultantID = placementConsultantID;
                recruitmentRequestList.Add(recruitmentRequest);

            }
            return recruitmentRequestList;
        }

        public List<int> getAssignedVacancies(int recruitmentRequestID)
        {
            List<int> vacancyIDs = new List<int>();

            SqlConnection conn = DBUtility.GetConnection();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getAssignedVacancies_667961";
            cmd.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);

            conn.Open();
            
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                int vacancyID = reader.GetInt32(0);
                vacancyIDs.Add(vacancyID);
            }
            
            conn.Close();

            return vacancyIDs;
        }


        public List<IRecruitmentRequest> getRecruitmentRequests(int recruitmentRequestID)
        {
            recruitmentRequestList.Clear();
            SqlConnection conn = DBUtility.GetConnection();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure; cmd.CommandText = "sp_getSelectedRecruitmentRequestDetails_667961";
            cmd.Parameters.AddWithValue("@RecruitmentRequestID", recruitmentRequestID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int flag = 0;
            while (reader.Read())
            {
                flag = 1;
                int recruitmentRequestId = reader.GetInt32(0);
                DateTime requiredByDate = reader.GetDateTime(1);
                int placementConsultantID = reader.GetInt32(2);
                IRecruitmentRequest recruitmentRequest = RecruitmentRequestFactory.CreateRecruitmentRequest();
                recruitmentRequest.RecruitmentRequestID = recruitmentRequestId;
                recruitmentRequest.RequiredDate = requiredByDate;
                recruitmentRequest.PlacementConsultantID = placementConsultantID;
                recruitmentRequestList.Add(recruitmentRequest);

            }
            conn.Close();
            return recruitmentRequestList;
            
        }




        public int DeleteRecruitmentRequest(int recruitmentRequestID)
        {             
                                                          //uses the view generated by searchRecruitmentRequest
            int result = 0;
            vacancyList.Clear();
            vacancyList = SearchRecruitmentRequest(recruitmentRequestID);
            SqlConnection conn1 = DBUtility.GetConnection();
            
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "sp_countVacancy_667015";
            cmd1.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);
            conn1.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            int i=0;
            while (reader.Read())
            {
                i = reader.GetInt32(0);
            }
            if (vacancyList.Count == i)
            {

                SqlConnection conn = DBUtility.GetConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_deleteRecruitmentRequest_667015";
                cmd.Parameters.AddWithValue("@recruitmentRequestID", recruitmentRequestID);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return result;
        }
    }
}
