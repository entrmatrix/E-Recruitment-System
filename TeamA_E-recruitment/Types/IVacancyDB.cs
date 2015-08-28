using System;
namespace Types
{
    public interface IVacancyDB
    {
        int ApproveVacancy(int vacancyID);
        int RejectVacancy(int vacancyID);
        int DeleteVacany(int vacancyID);
        int InsertVacancy(int noOfPositions, DateTime requiredByDate, string skills, string domain, int experience, string location, int isApproved, int vacancyRequestID);
        System.Collections.Generic.List<Types.IVacancy> SelectVacancy(int employeeID);
        int UpdateVacancy(int vacancyID, int noOfPositions, DateTime requiredByDate, string skills, int experience, string location, int isApproved);
        System.Collections.Generic.List<Types.IVacancy> ViewUnapprovedVacancies(int unitHeadID);
    }
}
