using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DALFactory;
namespace BLL
{
    public class RecruitmentRequestManager : IRecruitmentRequestManager
    {
        string skills;
        bool IsSimilarSkillset = true;

        IRecruitmentRequestDB recruitmentRequestDB = RecruitmentRequestDBFactory.CreateRecruitmentRequestDB();
        
        List<IVacancy> vacancyList = new List<IVacancy>(); //Declare a list to hold vacancies

        public int InsertRecruitmentRequest(DateTime requiredDate, int placementConsultantID, List<int> vacancyIDs)
        {
            //validate the selected vacancyids from vacancylist
            skills = "";
            //vacancyList = vacancyRequestWithNULLRecruitmentRequestID(); // Call to get the applicable vacancyList
            foreach (int vid in vacancyIDs)
            {
                foreach (IVacancy v in vacancyList) //Traverse the vacancyList which holds the similar vacancies and pick the skills
                {
                    if (v.VacancyID == vid)
                    {
                        skills = v.Skills; //Store the skillset in a variable
                        break;
                    }
                }
            }

            foreach (int vid in vacancyIDs)
            {
                foreach (IVacancy v in vacancyList) //Traverse the vacancyList and check if all the vacancies hold a similar skillset or not
                {
                    if (vid == v.VacancyID)
                    {
                        if (string.Compare(skills, v.Skills, true) != 0)
                        {
                            IsSimilarSkillset = false;
                            break;
                        }

                    }
                }
                if (!IsSimilarSkillset)
                    break; 
                
            }

            if(IsSimilarSkillset)
            {
                return recruitmentRequestDB.InsertRecruitmentRequest(requiredDate, placementConsultantID, vacancyIDs);
            }
            else
            {
               return -1;
            }

        }

        public List<IVacancy> VacancyRequestWithNULLRecruitmentRequestID()
        {
            vacancyList.Clear();
            vacancyList = recruitmentRequestDB.VacancyWithNULLRecruitmentRequestID();
            return vacancyList;
        }

        // Displays the vacancies assigned to recruitmentRequestID which are open and vacancies with null recruitmentRequestID
        public List<IVacancy> SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(int recruitmentRequestID) 
        {
            vacancyList.Clear();
            vacancyList= recruitmentRequestDB.SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(recruitmentRequestID);
            return vacancyList;
        }

        public List<IVacancy> SearchRecruitmentRequest(int recruitmentRequestID)
        {
            vacancyList.Clear();
            vacancyList = recruitmentRequestDB.SearchRecruitmentRequest(recruitmentRequestID);
            return vacancyList;
        }

        public int DeleteRecruitmentRequest(int recruitmentRequestID)
        {
           
                return recruitmentRequestDB.DeleteRecruitmentRequest(recruitmentRequestID);
           
        }

        public int EditRecruitmentRequest(int recruitmentRequestID, List<int> vacancyID)
        {
            //validate the selected vacancy ids
            skills = "";
            //vacancyList = searchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(recruitmentRequestID);
            recruitmentRequestDB = RecruitmentRequestDBFactory.CreateRecruitmentRequestDB();
           
            // Provide the recruitmentRequestID reference to the opted vacancy
            foreach (int vac in vacancyID)//Traverse the vacancyList which holds the similar vacancies and pick the skills
            {
                
                    foreach (IVacancy v in vacancyList) 
                {
                    if (v.VacancyID == vac)
                    {
                        skills = v.Skills; //Store the skillset in a variable
                        break;
                    }
                }
                break;
            }
            IsSimilarSkillset = true;
            foreach (int vid in vacancyID)
            {
                foreach (IVacancy v in vacancyList) //Traverse the vacancyList and check if all the vacancies hold a similar skillset or not
                {
                    if (vid == v.VacancyID)
                    {
                        if (string.Compare(skills, v.Skills, true) != 0)
                        {
                            IsSimilarSkillset = false;
                            break;
                        }

                    }
                }
                if (!IsSimilarSkillset)
                    break;

            }

            if (IsSimilarSkillset)
            {
                recruitmentRequestDB.UpdateNullForUpdate(recruitmentRequestID);
                return recruitmentRequestDB.EditRecruitmentRequest(recruitmentRequestID, vacancyID);
            }
            else
            {
                return -1;
            }

        }
        
        public List<IRecruitmentRequest> SelectingRecruitmentRequest()
        {
            return recruitmentRequestDB.SelectingRecruitmentRequest();
        }

        public List<int> getAssignedVacancies(int recruitmentRequestID)
        {
            return recruitmentRequestDB.getAssignedVacancies(recruitmentRequestID);
        }


        public List<IRecruitmentRequest> getRecruitmentRequests(int recruitmentRequestID)
        {
            return recruitmentRequestDB.getRecruitmentRequests(recruitmentRequestID);
        }

    }
}
