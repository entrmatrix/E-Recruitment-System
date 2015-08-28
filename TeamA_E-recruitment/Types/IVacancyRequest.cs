using System;
namespace Types
{
    public interface IVacancyRequest
    {
        int EmployeeID { get; set; }
        int NoOfVacancies { get; set; }
        int VacancyRequestID { get; set; }
    }
}
