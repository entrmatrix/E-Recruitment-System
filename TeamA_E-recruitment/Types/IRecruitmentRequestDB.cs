using System;
using System.Collections.Generic;

namespace Types
{
    public interface IRecruitmentRequestDB
    {
        int DeleteRecruitmentRequest(int recruitmentRequestID);
        int EditRecruitmentRequest(int recruitmentRequestID, System.Collections.Generic.List<int> vacancyID);
        int InsertRecruitmentRequest(DateTime requiredDate, int placementConsultantID, System.Collections.Generic.List<int> vacancyIDs);
        List<IVacancy> SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(int recruitmentRequestID);
        List<IVacancy> SearchRecruitmentRequest(int recruitmentRequestID);
        List<IVacancy> VacancyWithNULLRecruitmentRequestID();
        void UpdateNullForUpdate(int recruitmentRequestID);
        List<IRecruitmentRequest> SelectingRecruitmentRequest();
        List<int> getAssignedVacancies(int recruitmentRequestID);
        List<IRecruitmentRequest> getRecruitmentRequests(int recruitmentRequestID);
    }
}
