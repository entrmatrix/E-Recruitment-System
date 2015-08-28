using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface IVacancyManager
    {
        List<IVacancy> GetVacancy();
        int updateStatus(int VacancyID, int Status);
    }
}
