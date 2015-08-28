using System;
namespace Types
{
    public interface IVacancyRequestManager
    {
        int InsertVacancyRequest(int employeeID, int noOfVacancies);
    }
}
