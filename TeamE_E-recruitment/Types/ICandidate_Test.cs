using System;
namespace E_Recruitment.Types
{
    public interface ICandidate_Test
    {
        int get_CandidateProfileID { get; set; }
        DateTime get_DOB { get; set; }
        string get_Gender { get; set; }
        DateTime get_HRInterviewDate { get; set; }
        DateTime get_TechnicalInterviewDate { get; set; }
        int get_TestID { get; set; }
        int get_TestStatus { get; set; }
        int get_VacancyID { get; set; }
        DateTime get_WrittenTestDate { get; set; }
    }
}
