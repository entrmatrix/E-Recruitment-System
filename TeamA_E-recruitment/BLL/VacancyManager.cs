using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DALFactory;
namespace BLL
{
    public class VacancyManager : IVacancyManager
    {
        IVacancyDB vacancyDB=VacancyDBFactory.CreateVacancyDB();
        public List<IVacancy> vacancyList = new List<IVacancy>();

        //FUNCTION FOR CREATING A VACANCY
        public int InsertVacancy(int noOfPositions, DateTime requiredByDate, string skills, string domain, int experience, string location, int isApproved, int vacancyRequestID)
        {
            return vacancyDB.InsertVacancy(noOfPositions,requiredByDate,skills,domain,experience,location,isApproved,vacancyRequestID);
        }



        //FUNCTION FOR DELETING A VANCANCY
        public int DeleteVacany(int vacancyID)
        {
           foreach(IVacancy vacancy in vacancyList)
           {
               if(vacancy.VacancyID==vacancyID && vacancy.Status==0)
               {
                    return vacancyDB.DeleteVacany(vacancyID);   
               }
           }
               
                   return -1;
        }



        //FUNCTION FOR EDIT
        public int UpdateVacancy(int vacancyID,int noOfPositions, DateTime requiredByDate, string skills, int experience, string location, int isApproved)
        {
            foreach (IVacancy vacancy in vacancyList)
            {
                if (vacancyID == vacancy.VacancyID && vacancy.Status == 0)
                {
                    return vacancyDB.UpdateVacancy(vacancyID, noOfPositions, requiredByDate, skills, experience, location, isApproved);
                }
            }
            return -1;
        }


        //FUNCTION FOR DISPLAYING THE VACANCIES
        public List<IVacancy> SelectVacancy(int employeeID)
        {
            vacancyList.Clear();
            vacancyList=vacancyDB.SelectVacancy(employeeID);
            return vacancyList;
        }


        //FUNCTION FOR VIEWING UNAPPROVED VACANCIES
        public List<IVacancy> ViewUnapprovedVacancies(int unitHeadID)
        {
            vacancyList.Clear();//clear the vacancyList
            vacancyList=vacancyDB.ViewUnapprovedVacancies(unitHeadID);//put those Unapproved VacancyList which are  in VacancyDB
            return vacancyList;//Return the vacancy list
        }


        //FUNCTION FOR APPROVING VACANCIES
        public int ApproveVacancy(int vacancyID)
        {
            int flag=0;//the flag is taken for validation
           foreach(IVacancy vacancy in vacancyList)//get all the values from the list
           {

               if(vacancy.VacancyID==vacancyID)//compare between the user given vacancy id with the VacancyId of the pending request
               {
                    flag=1;//initialize the flag value with 1
                   break;
               }
           }
            if(flag==1)
                return vacancyDB.ApproveVacancy(vacancyID);//return this value to the UI part
            else
                return -1;
        }


        //FUNCTION FOR REJECTING VACANCIES
        public int RejectVacancy(int vacancyID)
        {
            int flag = 0;//the flag is taken for validation
            foreach (IVacancy vacancy in vacancyList)//get all the values from the list
            {

                if (vacancy.VacancyID == vacancyID)//compare between the user given vacancy id with the VacancyId of the pending request
                {
                    flag = 1;//initialize the flag value with 1
                    break;
                }
            }
            if (flag == 1)
                return vacancyDB.RejectVacancy(vacancyID);//return this value to the UI part
            else
                return -1;
        }
    }
}
