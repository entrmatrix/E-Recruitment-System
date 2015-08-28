using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BussinessObject;
namespace BussinessObjectFactory
{
    public class VacancyRequestFactory
    {
        private static IVacancyRequest vacancyRequest = null;

        public static IVacancyRequest CreateVacancyRequest()
        {
            if(vacancyRequest==null)
                vacancyRequest = new VacancyRequest();
            return vacancyRequest;
        } 
    }
}
