using System;
namespace E_Recruitment.Types
{
    public interface ITest
    {
        DateTime get_HRInterviewDate { get; set; }
        DateTime get_TechnicalInterviewDate { get; set; }
        int get_TestAdministratorID { get; set; }
        int get_TestID { get; set; }
        int get_VacancyID { get; set; }
        DateTime get_WrittenTestDate { get; set; }
    }
}
