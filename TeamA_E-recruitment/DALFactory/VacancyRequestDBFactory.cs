using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DAL;
namespace DALFactory
{
    public class VacancyRequestDBFactory
    {
        private static IVacancyRequestDB vacancyRequestDB = null;

        public static IVacancyRequestDB CreateVacancyRequestDB()
        {
            if(vacancyRequestDB==null)
            vacancyRequestDB = new VacancyRequestDB();
            return vacancyRequestDB;
        }
    }
}
