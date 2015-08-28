using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface ITestManager
    {
        int CheckDetails(int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate);
        List<ITest> get_list_Test { get; set; }
        List<ITest> GetTest();
        int Validate(int TestAdminID, int VacancyID, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate);
        int Validate_VacancyID(int TestAdminID, int VacancyID);
    }
}
