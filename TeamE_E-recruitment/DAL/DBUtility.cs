


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: DBUtility.cs
Description of the file: Used in Data Access Layer.
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
using System.Data.SqlClient;
using System.Configuration;

namespace E_Recruitment.DAL
{
    public class DBUtility
    {
        public static SqlConnection getConnection()
        {
            
            SqlConnection objDBConnection = null;
            objDBConnection = new SqlConnection("database=DB05T18;user id=PJ05T18;password=tcstvm; server=intvmsql");
            return objDBConnection;

        }
    }
}
