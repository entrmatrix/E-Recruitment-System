

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: UnitHead.master.cs
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
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UnitHead : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["Name"]) != "UH")
        {
            
           
         
            Session["Authentication"]="Failed";
           Response.Redirect("Login.aspx");
        }
        ID.Text = Convert.ToString(Session["ID"]);
        Label1.Text = Convert.ToString(DateTime.Now);
    }
}
