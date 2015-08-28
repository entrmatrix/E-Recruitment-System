using System;
namespace E_Recruitment.Types
{
    public interface ICandidateManager
    {
        int AddCandidateProfile(global::E_Recruitment.Types.ICandidateProfile cand);
        int candidate_update(global::E_Recruitment.Types.ICandidateProfile cand);
        int DeleteCandidateProfile(int CandidateID);
        global::System.Collections.Generic.List<global::E_Recruitment.Types.ICandidateProfile> display_candidate_toPC();
        bool filledstatus_20percent(int VacancyID);
        bool filledstatus_50percent(int VacancyID);
        bool filledstatus_bydate(int VacancyID);
        global::System.Collections.Generic.List<int> getVacancies();
        global::System.Collections.Generic.List<global::E_Recruitment.Types.ICandidateProfile> List_candidate { get; set; }
        int med_update(int cand_ID, int Test_status, int Med_status);
        bool filledstatus_bydate_TestID(int VacancyID);
    }
}
