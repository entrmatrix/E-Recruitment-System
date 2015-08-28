using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BLL;

namespace BLLFactory
{
    public class RecruitmentRequestManagerFactory
    {
        private static IRecruitmentRequestManager recruitmentRequestManager = null;

        public static IRecruitmentRequestManager CreateRecruitmentRequestManager()
        {
            if (recruitmentRequestManager == null)
            {
                recruitmentRequestManager = new RecruitmentRequestManager();
            }

            return recruitmentRequestManager;
        }
    }
}
