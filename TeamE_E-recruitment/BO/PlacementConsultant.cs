


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: PlacmeentConsultant.cs
Description of the file: Used in Business Object Layer.
 * This source is subject to the to ABC Public License. 
 * http://www.abc.erecruitment.com/  
 * All other rights reserved.  
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  EITHER 
 * EXPRESSED  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED  WARRANTIES OF
 * MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using E_Recruitment.Types;

namespace E_Recruitment.BO
{
    public class PlacementConsultant : IPlacementConsultant 
    {
        private int PlacementConsultantID;
        private String PlacementConsultantName;
        private String Password;
        private String Details;

        public PlacementConsultant()
        { }

        public PlacementConsultant(int PlacementConsultantID, String PlacementConsultantName, String Password, String Details)
        {
            this.PlacementConsultantID = PlacementConsultantID;
            this.PlacementConsultantName = PlacementConsultantName;
            this.Password = Password;
            this.Details = Details;
        }

        public int get_PlacementConsultantID
        {
            get {return PlacementConsultantID;}
            set {  PlacementConsultantID = value; }
        }

        public String get_PlacementConsultantName
        {
            get { return PlacementConsultantName; }
            set { PlacementConsultantName = value; }
        }

        public String get_Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public String get_Details
        {
            get { return Details; }
            set { Details = value; }
        }

    }
}
