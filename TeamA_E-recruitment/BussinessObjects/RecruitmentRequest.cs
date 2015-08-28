using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
namespace BussinessObject
{
    public class RecruitmentRequest : IRecruitmentRequest
    {
        int recruitmentRequestID;
        DateTime requiredDate;
        int placementConsultantID;


        public RecruitmentRequest()
        {
        }
        public int RecruitmentRequestID
        {
            get { return recruitmentRequestID; }

            set { this.recruitmentRequestID = value; }
        }
        public DateTime RequiredDate
        {
            get { return requiredDate; }

            set { this.requiredDate = value; }
        }
        public int PlacementConsultantID
        {
            get { return placementConsultantID; }

            set { this.placementConsultantID = value; }
        }
    }
}
