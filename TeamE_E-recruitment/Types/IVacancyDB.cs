using System;
using System.Collections.Generic;
namespace E_Recruitment.Types
{
    public interface IVacancyDB
    {
        List<E_Recruitment.Types.IVacancy> GetVacancy();
        int updateStatus(int vacancy, int status);
    }
}
