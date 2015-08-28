using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class TestAdmin_UnitHead : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["Name"]) != "TA_UH")
        {

            Session["Authentication"] = "Failed";
            Response.Redirect("Login.aspx");
        }
        ID.Text = Convert.ToString(Session["ID"]);
        DateTimeFormatInfo dateinfo = new DateTimeFormatInfo();
        Label1.Text = Convert.ToString(DateTime.Now, dateinfo);
    }
}
