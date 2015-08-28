using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface ITestStatusManager
    {
        List<ITestStatus> GetTestStatus(int vid);
        int update_TestStatus(int CandidateID, string Written_TestStatus, string Technical_InterviewStatus, string HR_InterviewStatus);
        int updatetest(int Vac_ID, int cand_ID, string type, DateTime date);
        bool validateTest(int Vac_ID, int Cand_ID, DateTime date);
    }
}
