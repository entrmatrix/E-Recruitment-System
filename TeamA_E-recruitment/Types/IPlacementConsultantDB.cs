using System;
namespace Types
{
    public interface IPlacementConsultantDB
    {
        int DeletePlacementConsultant(int placementConsultantID);
        int InsertPlacementConsultant(string placementConsultantName, string password, string placementConsultantDetails);
        System.Collections.Generic.List<Types.IPlacementConsultant> SelectPlacementConsultant(string placementConsultantName);
        int UpdatePlacementConsultant(int placementConsultantID, string placementConsultantName, string placementConsultantDetails);
        //int UpdatePlacementConsultantIfExists(int placementConsultantID);
        int UpdatePlacementConsultantIfExists(int placementConsultantID);
        System.Collections.Generic.List<Types.IPlacementConsultant> SelectPlacementConsultantIfExists(string placementConsultantName);
        System.Collections.Generic.Dictionary<int, string> loadPlacementConsultant();
        System.Collections.Generic.List<Types.IPlacementConsultant> SelectPlacementConsultantIfExistsisActive(string placementConsultantName);
       
    }
}
