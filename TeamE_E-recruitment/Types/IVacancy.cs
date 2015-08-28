using System;
namespace E_Recruitment.Types
{
    public interface IVacancy
    {
        string get_BusinessDomain { get; set; }
        int get_Experience { get; set; }
        string get_Location { get; set; }
        int get_NoOfPositions { get; set; }
        int get_RecruitmentRequestID { get; set; }
        DateTime get_RequiredByDate { get; set; }
        string get_Skills { get; set; }
        int get_Status { get; set; }
        int get_VacancyID { get; set; }
        int get_VacancyRequestID { get; set; }
    }
}
