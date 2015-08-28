using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DALFactory;
namespace BLL
{
    public class VacancyRequestManager : IVacancyRequestManager
    {
        IVacancyRequestDB vacancyRequestDB = VacancyRequestDBFactory.CreateVacancyRequestDB();
        public int InsertVacancyRequest(int employeeID, int noOfVacancies)
        {
            //just calling vacanyRequestDB for inserting the information of vacancyRequest and getting the vacancyRequestID
            return vacancyRequestDB.InsertVacancyRequest(employeeID, noOfVacancies);
        }
    }
}
