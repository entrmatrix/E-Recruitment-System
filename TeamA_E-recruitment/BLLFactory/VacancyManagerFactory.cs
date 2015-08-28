using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BLL;
namespace BLLFactory
{
    public class VacancyManagerFactory
    {
        private static IVacancyManager vacancyManager = null;
        public static IVacancyManager CreateVacancyManager()
        {
            if (vacancyManager == null)
            {
                vacancyManager = new VacancyManager();
            }
            return vacancyManager;
        }
    }
}
