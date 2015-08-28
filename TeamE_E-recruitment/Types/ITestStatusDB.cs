using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface ITestStatusDB
    {
        List<ITestStatus> GetTestStatusbyVID(int vid);
        int update_TestStatus(int CandidateID, int TestStatus);
    }
}
