using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        employeeIDLabel.Text = Session["empid"].ToString();
        employeeNameLabel.Text = Session["empname"].ToString();

        string strCheck = Session["ishr"].ToString();
        
        bool i = Convert.ToBoolean(strCheck);
        
        if (i)
        {
            designationLabel.Text = "HR Officer";
        }
        else if (Convert.ToInt32(Session["uid"].ToString()) == 0)
        {
            designationLabel.Text = "Unit Head";
        }
        else
        {
            designationLabel.Text = "Associate";
        }
        timelb.Text = DateTime.Now.ToString();

    }


    //protected void HomeMenu_MenuItemClick(object sender, MenuEventArgs e)
    //{
    //    if(e.Item.Value.Equals("aprv"))
    //    {
    //        int unitHeadID = (int)Session["uid"];
    //        if (unitHeadID == 0)
    //            Response.Redirect("~/Approve.aspx");
    //        else
    //            Response.Redirect("noUnithead.aspx");
    //    }
    //    if (e.Item.Value.Equals("Add Placement Consultant"))
    //    {
    //        bool isHR = (bool)Session["ishr"];
    //        if (isHR)
    //            Response.Redirect("~/AddPlacementConsultant.aspx");
    //        else
    //            Response.Redirect("NoHR.aspx");
    //    }
    //    if (e.Item.Value.Equals("Edit Placement Consultant"))
    //    {
    //        bool isHR = (bool)Session["ishr"];
    //        if (isHR)
    //            Response.Redirect("~/EditandDeletePlacementConsultant.aspx");
    //        else
    //            Response.Redirect("NoHR.aspx");
    //    }
    //    if (e.Item.Value.Equals("Search Placement Consultant"))
    //    {
    //        bool isHR = (bool)Session["ishr"];
    //        if (isHR)
    //            Response.Redirect("~/DisplayPlacementConsultant.aspx");
    //        else
    //            Response.Redirect("NoHR.aspx");
    //    }
        
    //}
}