using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DAL;
namespace DALFactory
{
    public class VacancyDBFactory
    {
        private static IVacancyDB vacancyDB = null;

        public static IVacancyDB CreateVacancyDB()
        {
           // if(vacancyDB==null)
            vacancyDB = new VacancyDB();
            return vacancyDB;
        } 
    }
}
