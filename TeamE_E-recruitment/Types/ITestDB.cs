using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface ITestDB
    {
        List<ITest> Get_TestDetails();
        bool isavailable_withVacancyID(int VacancyID);
        bool SaveTestDates(int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate);
        int updateTest(int cand_ID, DateTime written, DateTime tech, DateTime HR);
    }
}
