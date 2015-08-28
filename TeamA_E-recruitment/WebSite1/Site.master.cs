using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
       

    }


    protected void HomeMenu_MenuItemClick(object sender, MenuEventArgs e)
    {
        if (e.Item.Value.Equals("aprv"))
        {
            int unitHeadID = (int)Session["uid"];
            if (unitHeadID == 0)
                Response.Redirect("~/Approve.aspx");
            else
                Response.Redirect("noUnithead.aspx");
        }
        if (e.Item.Value.Equals("Add Placement Consultant"))
        {
            bool isHR = (bool)Session["ishr"];
            if (isHR)
                Response.Redirect("~/AddPlacementConsultant.aspx");
            else
                Response.Redirect("NoHR.aspx");
        }
        if (e.Item.Value.Equals("Edit Placement Consultant"))
        {
            bool isHR = (bool)Session["ishr"];
            if (isHR)
                Response.Redirect("~/EditandDeletePlacementConsultant.aspx");
            else
                Response.Redirect("NoHR.aspx");
        }
        if (e.Item.Value.Equals("Search Placement Consultant"))
        {
            bool isHR = (bool)Session["ishr"];
            if (isHR)
                Response.Redirect("~/DisplayPlacementConsultant.aspx");
            else
                Response.Redirect("NoHR.aspx");
        }
        if (e.Item.Value.Equals("Create Recruitment Request"))
        {
            bool isHR = (bool)Session["ishr"];
            if (isHR)
                Response.Redirect("~/AddRecruitmentRequest.aspx");
            else
                Response.Redirect("NoHR.aspx");
        }
        if (e.Item.Value.Equals("Delete Recruitment Request"))
        {
            bool isHR = (bool)Session["ishr"];
            if (isHR)
                Response.Redirect("~/Copy of EditandDeleteRecruitmentRequest.aspx");
            else
                Response.Redirect("NoHR.aspx");
        }
        if (e.Item.Value.Equals("Display Recruitment Request"))
        {
            bool isHR = (bool)Session["ishr"];
            if (isHR)
                Response.Redirect("~/DisplayRecruitmentRequest.aspx");
            else
                Response.Redirect("NoHR.aspx");
        }

        
    }
}
