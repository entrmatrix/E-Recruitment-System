using System;
namespace E_Recruitment.Types
{
    public interface ICandidateProfile
    {
        int get_BGCTestID { get; set; }
        bool get_BGCTestStatus { get; set; }
        int get_CandidateProfileID { get; set; }
        DateTime get_DOB { get; set; }
        int get_GapInEducation { get; set; }
        int get_GapInExperience { get; set; }
        string get_Gender { get; set; }
        string get_Location { get; set; }
        int get_MedicalTestStatus { get; set; }
        float get_Percentage_10 { get; set; }
        float get_Percentage_12 { get; set; }
        string get_ResumeFile { get; set; }
        int get_TestID { get; set; }
        int get_TestStatus { get; set; }
        int get_VacancyID { get; set; }
    }
}
