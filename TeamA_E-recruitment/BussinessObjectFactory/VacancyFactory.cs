using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BussinessObject;
namespace BussinessObjectFactory
{
    public class VacancyFactory
    {
        private static IVacancy vacancy = null;

        public static IVacancy CreateVacancy(int vacancyID, int noOfPositions, string skills,string domain, int experience, DateTime requiredDate,string location, int status)
        {
            
            vacancy = new Vacancy( vacancyID,  noOfPositions,  skills,domain,  experience,  requiredDate,location,  status);
            return vacancy;
        } 
    }
}
