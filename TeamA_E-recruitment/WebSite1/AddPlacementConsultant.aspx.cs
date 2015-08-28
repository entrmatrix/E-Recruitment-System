using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using BLLFactory;

public partial class AddPlacementConsultant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //ClientScript.RegisterClientScriptBlock(Page.GetType(), "ConfirmMsg", "<script language='javascript'>confirm('Wish to add the placementconsultant?');</script>");
        IPlacementConsultantManager pconsultant = PlacementConsultantManagerFactory.CreatePlacementConsultantManager();
        string PlacementConsultantName = NameBox.Text;
        string Password = PasswordBox.Text;
        string Details = DetailBox.Text;
        int x = pconsultant.InsertPlacementConsultant(PlacementConsultantName, Password, Details);
        //ClientScript.RegisterClientScriptBlock(Page.GetType(), "ConfirmMsg", "<script language='javascript'>alert(' placementconsultant ID :')"+x+";</script>");
        Label4.Visible = true;
         if(x==0)
            Label4.Text = "Placement Consultant already exists";
        else
        Label4.Text = "Placement Consultant is successfully added with id= " + x;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");

    }
}