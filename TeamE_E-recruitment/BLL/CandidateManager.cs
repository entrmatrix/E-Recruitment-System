


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: CandidateManager.cs
Description of the file: Used as Business Logic Layer.
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
using E_Recruitment.Types;
using E_Recruitment.DALFactory;

namespace E_Recruitment.BLL
{
    public class CandidateManager : ICandidateManager
    {
        private static List<ICandidateProfile> lstCandidateProfile = new List<ICandidateProfile>();
        public ICandidateDB objCandidateDB = (ICandidateDB)CandidateDBFactory.Create_CandidateDB();
        public List<ICandidateProfile> List_candidate
        {
            get { return lstCandidateProfile; }
            set { lstCandidateProfile = value; }
        }

        // To add candidates.
        public int AddCandidateProfile(ICandidateProfile cand)
        {
            try
            {
                ICandidateDB objCandidateDB = CandidateDBFactory.Create_CandidateDB();
                VacancyManager objvacancymanager = new VacancyManager();

                if (filledstatus_50percent(cand.get_VacancyID) == false)
                {
                    if (filledstatus_bydate(cand.get_VacancyID) == false) 
                    {
                        objCandidateDB.save(cand);
                        return 1;
                    }
                    else if ((filledstatus_bydate(cand.get_VacancyID) == true) && (filledstatus_20percent(cand.get_VacancyID) == true))
                    {
                        objvacancymanager.updateStatus(cand.get_VacancyID, 2);
                        return 3;

                    }
                    else
                    {
                        return 0;
                    }
                }
                else if ((filledstatus_50percent(cand.get_VacancyID) == true) && (filledstatus_bydate(cand.get_VacancyID) == true))
                {
                    objvacancymanager.updateStatus(cand.get_VacancyID, 2);
                    return 2;

                }
                else
                {
                    return 0;
                }
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX);
                return 0;
            }
        }



        public List<int> getVacancies()
        {
            ICandidateDB objCandidateDB = CandidateDBFactory.Create_CandidateDB();
            return objCandidateDB.Vacancies();
           
        }

        // To delete candidate
        public int DeleteCandidateProfile(int CandidateID)
        {
            ICandidateDB objCandidateDB = CandidateDBFactory.Create_CandidateDB();
            return objCandidateDB.delete(CandidateID);
        }

        // To check whether given vacancy reached 150% candidates of required candidates
        public bool filledstatus_50percent(int VacancyID)
        {
            VacancyManager objVacancyManager = new VacancyManager();
            List<ICandidateProfile> lstCandidateProfile = display_candidate_toPC();
            int count = 0, CandidatesRequired = 0;

            for (int i = 0; i < lstCandidateProfile.Count; i++)
            {
                if (lstCandidateProfile.ElementAt(i).get_VacancyID == VacancyID)
                    count++;
            }


            VacancyManager objVacancy = new VacancyManager();
            List<IVacancy> lstVacancy = objVacancy.GetVacancy();


            for (int i = 0; i < lstVacancy.Count; i++)
            {
                if (lstVacancy.ElementAt(i).get_VacancyID == VacancyID)
                    CandidatesRequired = lstVacancy.ElementAt(i).get_NoOfPositions;
            }



            if (count >= 1.5 * (CandidatesRequired))
            {
                
                objVacancyManager.updateStatus(VacancyID, 2);
                return true;
            }
            else return false;
        }

        // To check whether given vacancy reached 120% candidates of required candidates
        public bool filledstatus_20percent(int VacancyID)
        {
            List<ICandidateProfile> lstCandidateProfile = display_candidate_toPC();
            int count = 0, CandidatesRequired = 0;

            for (int i = 0; i < lstCandidateProfile.Count; i++)
            {
                if (lstCandidateProfile.ElementAt(i).get_VacancyID == VacancyID)
                    count++;
            }

            VacancyManager objVacancy = new VacancyManager();
            List<IVacancy> lstVacancy = objVacancy.GetVacancy();
            for (int i = 0; i < lstVacancy.Count; i++)
            {
                if (lstVacancy.ElementAt(i).get_VacancyID == VacancyID)
                    CandidatesRequired = lstVacancy.ElementAt(i).get_NoOfPositions;
            }

            if (count >= 1.2 * (CandidatesRequired))
                return true;
            else return false;
        }

        // To check whether given vacancy has 3 weeks left
        public bool filledstatus_bydate(int VacancyID)
        {
            DateTime RequiredByDate=DateTime.MinValue, currentdate = DateTime.Now;

            VacancyManager objVacancyManager = new VacancyManager();
            List<IVacancy> lstVacancy = objVacancyManager.GetVacancy();

            for (int i = 0; i < lstVacancy.Count; i++)
            {
                if (lstVacancy.ElementAt(i).get_VacancyID == VacancyID)
                {
                    RequiredByDate = lstVacancy.ElementAt(i).get_RequiredByDate;
                    break;
                }
            }

            

            TimeSpan time_span = new TimeSpan();
            time_span = RequiredByDate-currentdate ;


            if (time_span.Days < 21)
                return true;
            else return false;
        }

        // To check whether given vacancy is before required by date
        public bool filledstatus_bydate_TestID(int VacancyID)
        {
            DateTime RequiredByDate = DateTime.MinValue, currentdate = DateTime.Now;

            VacancyManager objVacancyManager = new VacancyManager();
            List<IVacancy> lstVacancy = objVacancyManager.GetVacancy();

            for (int i = 0; i < lstVacancy.Count; i++)
            {
                if (lstVacancy.ElementAt(i).get_VacancyID == VacancyID)
                {
                    RequiredByDate = lstVacancy.ElementAt(i).get_RequiredByDate;
                    break;
                }
            }



            TimeSpan time_span = new TimeSpan();
            time_span = RequiredByDate - currentdate;


            if (time_span.Days >0)
                return true;
            else return false;
        }


        // To display candidate to Placement Consultant
        public List<ICandidateProfile> display_candidate_toPC()
        {
            try
            {
                ICandidateDB objCandidateDB = (ICandidateDB)CandidateDBFactory.Create_CandidateDB();
                return objCandidateDB.getCandidates();

            }
            catch (Exception)
            {
                return null;
            }
        }

     
        // To update candidates
        public int candidate_update(ICandidateProfile objCandidateProfile)
        {
            ICandidateDB objCandidateDB = CandidateDBFactory.Create_CandidateDB();
            return objCandidateDB.updateCandidates(objCandidateProfile);
        }

        // To update Medical Status
        public int med_update(int cand_ID, int Test_status, int Med_status)
        {
            ICandidateDB objCandidateDB = CandidateDBFactory.Create_CandidateDB();
            List<ICandidateProfile> lstCandidateProfile = objCandidateDB.getCandidates();
            foreach (ICandidateProfile objCandidateProfile in lstCandidateProfile)
            {
                if (objCandidateProfile.get_CandidateProfileID == cand_ID)
                {
                    if (objCandidateProfile.get_TestStatus == 4)
                    {
                        objCandidateProfile.get_MedicalTestStatus = Med_status;
                        objCandidateProfile.get_TestStatus = Test_status;
                        return objCandidateDB.updateCandidates(objCandidateProfile);
                    }
                   
                }
            }

            return 0;
        }

    }
}

