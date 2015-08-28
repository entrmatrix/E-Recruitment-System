using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BussinessObject;
namespace BussinessObjectFactory
{
    public class PlacementConsultantFactory
    {
        private static IPlacementConsultant placementConsultant = null;

        public static IPlacementConsultant CreatePlacementConsultant(int placementConsultantID, string placementConsultantName, string placementConsultantDetails)
        {
            //if(placementConsultant==null)
                placementConsultant = new PlacementConsultant( placementConsultantID,  placementConsultantName,  placementConsultantDetails);
            return placementConsultant;
        } 
    }
}
