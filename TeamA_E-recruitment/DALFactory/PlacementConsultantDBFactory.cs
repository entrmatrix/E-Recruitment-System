using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
using DAL;
namespace DALFactory
{
    public class PlacementConsultantDBFactory
    {
        private static IPlacementConsultantDB placementConsultanttDB = null;

        public static IPlacementConsultantDB CreatePlacementConsultantDB()
        {
            if(placementConsultanttDB==null)
                placementConsultanttDB = new PlacementConsultantDB();
            return placementConsultanttDB;
        } 
    }
}
