


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: PlacementConsultantFactory.cs
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
using E_Recruitment.BO;

namespace E_Recruitment.BOFactory
{
   public class PlacementConsultantFactory
    {

        public static IPlacementConsultant Create_PlacementConsultant(int PlacementConsultantID, String PlacementConsultantName, String Password, String Details)
        {
           
           IPlacementConsultant   objPlacementConsultant = (IPlacementConsultant)new PlacementConsultant(PlacementConsultantID, PlacementConsultantName, Password, Details);

           
            return objPlacementConsultant;
        }

        
    }
}
