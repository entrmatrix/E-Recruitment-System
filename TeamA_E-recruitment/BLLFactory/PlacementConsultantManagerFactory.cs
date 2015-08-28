using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using BLL;
namespace BLLFactory
{
    public class PlacementConsultantManagerFactory
    {
        private static IPlacementConsultantManager placementConsultantManager = null;
        public static IPlacementConsultantManager CreatePlacementConsultantManager()
        {
            if(placementConsultantManager==null)
                placementConsultantManager = new PlacementConsultantManager();
            return placementConsultantManager;
        }
    }
}
