using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BussinessObject;

namespace BussinessObjectFactory
{
    public class RecruitmentRequestFactory
    {
        private static IRecruitmentRequest recruitmentRequest = null;

        public static IRecruitmentRequest CreateRecruitmentRequest()
        {
            
                recruitmentRequest = new RecruitmentRequest();
            return recruitmentRequest;
        } 
    }
}
