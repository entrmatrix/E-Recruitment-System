using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DALFactory;
namespace BLL
{
    public class PlacementConsultantManager : IPlacementConsultantManager
    {
        IPlacementConsultantDB placementConsultantDB = PlacementConsultantDBFactory.CreatePlacementConsultantDB();
        List<IPlacementConsultant> placementConsultantList = new List<IPlacementConsultant>();
        public int InsertPlacementConsultant(string placementConsultantName, string password, string placementConsultantDetails)
        {
            int placementConsultantID = 0;
            placementConsultantList.Clear();
            int flag = 0;
            placementConsultantList = placementConsultantDB.SelectPlacementConsultantIfExistsisActive(placementConsultantName);
            foreach (IPlacementConsultant placementConsultant in placementConsultantList)
            {
                //if placementconsultant already exists then we can update the status of him to active
                if (placementConsultant.PlacementConsultantName == placementConsultantName && placementConsultant.PlacementConsultantDetails == placementConsultantDetails)
                {
                    flag = 1;
                    // placementConsultantID= placementConsultantDB.UpdatePlacementConsultantIfExists(placementConsultant.PlacementConsultantID);
                    placementConsultantID = 0;
                    return placementConsultantID;
                }
            }
            placementConsultantList.Clear();
           placementConsultantList=placementConsultantDB.SelectPlacementConsultantIfExists(placementConsultantName);
            foreach (IPlacementConsultant placementConsultant in placementConsultantList)
            {
                //if placementconsultant already exists then we can update the status of him to active
                if (placementConsultant.PlacementConsultantName == placementConsultantName && placementConsultant.PlacementConsultantDetails == placementConsultantDetails)
                {
                    flag = 1;
                   // placementConsultantID= placementConsultantDB.UpdatePlacementConsultantIfExists(placementConsultant.PlacementConsultantID);

                    placementConsultantID = placementConsultantDB.UpdatePlacementConsultantIfExists(placementConsultant.PlacementConsultantID);
                    return placementConsultantID;
                }
            }
             if(flag==0)   //insert new placement consultant
                {
                   placementConsultantID= placementConsultantDB.InsertPlacementConsultant(placementConsultantName, password, placementConsultantDetails);
                   return placementConsultantID;  
             }
            
            return placementConsultantID;
        }
        public int DeletePlacementConsultant(int placementConsultantID)
        {
           //delete placement consultant i.e., making the placement consultant inactive
            
            return placementConsultantDB.DeletePlacementConsultant(placementConsultantID);
        }
        public List<IPlacementConsultant> SelectPlacementConsultant(string placementConsultantName)
        {
            placementConsultantList.Clear();
            placementConsultantList=placementConsultantDB.SelectPlacementConsultant(placementConsultantName);
            return placementConsultantList;
        }
        public int UpdatePlacementConsultant(int placementConsultantID, string placementConsultantName, string placementConsultantDetails)
        {
            return placementConsultantDB.UpdatePlacementConsultant(placementConsultantID, placementConsultantName, placementConsultantDetails); 
        }

        public Dictionary<int, string> loadPlacementConsultant()
        {
            IPlacementConsultantDB placementConsultantDB = PlacementConsultantDBFactory.CreatePlacementConsultantDB();
            return placementConsultantDB.loadPlacementConsultant();
        }
    }
}
