using System;
namespace Types
{
    public interface IVacancyRequestDB
    {
        int InsertVacancyRequest(int employeeID, int noOfVacancies);
    }
}
