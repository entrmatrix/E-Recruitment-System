using System;
namespace E_Recruitment.Types
{
    public interface ITestStatus
    {
        int get_CandidateID { get; set; }
        DateTime get_HR_InterviewDate { get; set; }
        string get_HR_InterviewStatus { get; set; }
        DateTime get_Technical_InterviewDate { get; set; }
        string get_Technical_InterviewStatus { get; set; }
        int get_TestID { get; set; }
        DateTime get_Written_TestDate { get; set; }
        string get_Written_TestStatus { get; set; }
    }
}
