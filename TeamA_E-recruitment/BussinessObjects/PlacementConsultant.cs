using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
namespace BussinessObject
{
    public class PlacementConsultant : IPlacementConsultant
    {
        public string placementConsultantName;
        public int placementConsultantID;
        public string placementConsultantDetails;
        public PlacementConsultant(int placementConsultantID, string placementConsultantName, string placementConsultantDetails)
        {
            this.placementConsultantName = placementConsultantName;
            this.placementConsultantID = placementConsultantID;
            this.placementConsultantDetails = placementConsultantDetails;
           
        }

        public string PlacementConsultantName
        {
            get { return placementConsultantName; }

            set { this.placementConsultantName = value; }
        }
        public int PlacementConsultantID
        {
            get { return placementConsultantID; }

            set { this.placementConsultantID = value; }
        }
        public string PlacementConsultantDetails
        {
            get { return placementConsultantDetails; }

            set { this.placementConsultantDetails = value; }
        }
    }
}
