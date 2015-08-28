using System;
namespace E_Recruitment.Types
{
    public interface IPlacementConsultant
    {
        string get_Details { get; set; }
        string get_Password { get; set; }
        int get_PlacementConsultantID { get; set; }
        string get_PlacementConsultantName { get; set; }
    }
}
