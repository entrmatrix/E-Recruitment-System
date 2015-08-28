using System;
namespace Types
{
    public interface IPlacementConsultantManager
    {
        int DeletePlacementConsultant(int placementConsultantID);
        int InsertPlacementConsultant(string placementConsultantName, string password, string placementConsultantDetails);
        System.Collections.Generic.List<Types.IPlacementConsultant> SelectPlacementConsultant(string placementConsultantName);
        int UpdatePlacementConsultant(int placementConsultantID, string placementConsultantName, string placementConsultantDetails);
        System.Collections.Generic.Dictionary<int, string> loadPlacementConsultant();

        //void DeletePlacementConsultant(string p);
    }
}
