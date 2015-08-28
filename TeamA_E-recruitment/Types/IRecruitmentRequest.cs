using System;
namespace Types
{
    public interface IRecruitmentRequest
    {
        int PlacementConsultantID { get; set; }
        int RecruitmentRequestID { get; set; }
        DateTime RequiredDate { get; set; }
    }
}
