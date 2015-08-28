using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
namespace BussinessObject
{
    public class VacancyRequest :  IVacancyRequest
    {
        public int vacancyRequestID;
        int employeeID;
        int noOfVacancies;
        public VacancyRequest()
        {
        }
        public int VacancyRequestID
        {
            get { return vacancyRequestID; }

            set { this.vacancyRequestID = value; }
        }
        public int EmployeeID
        {
            get { return employeeID; }

            set { this.employeeID = value; }
        }
        public int NoOfVacancies
        {
            get { return noOfVacancies; }

            set { this.noOfVacancies = value; }
        }


    }
    

}
