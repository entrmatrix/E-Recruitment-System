using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DAL;
namespace DALFactory
{
    public class RecruitmentRequestDBFactory
    {
        private static IRecruitmentRequestDB recruitmentRequestDB = null;

        public static IRecruitmentRequestDB CreateRecruitmentRequestDB()
        {
            if(recruitmentRequestDB==null)
                recruitmentRequestDB = new RecruitmentRequestDB();
            return recruitmentRequestDB;
        } 
    }
}
