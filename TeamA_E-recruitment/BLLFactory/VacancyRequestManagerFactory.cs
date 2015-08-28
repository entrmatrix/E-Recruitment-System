using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BLL;
namespace BLLFactory
{
    public class VacancyRequestManagerFactory
    {
        private static IVacancyRequestManager vacancyRequestManager = null;
        public static IVacancyRequestManager CreateVacancyRequestManager()
        {
            if (vacancyRequestManager == null) 
            vacancyRequestManager = new VacancyRequestManager();
            return vacancyRequestManager;
        }
    }
}
