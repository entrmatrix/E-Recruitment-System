using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using BLLFactory;
using System.Data;

public partial class EditandDeletePlacementConsultant : System.Web.UI.Page
{
    IPlacementConsultantManager pconsultant = PlacementConsultantManagerFactory.CreatePlacementConsultantManager();
    List<IPlacementConsultant> placementConsultantList = new List<IPlacementConsultant>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(IsPostBack))
        {
            add();
        }
        else
        {
            GridView1.Visible = true;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string PlacementConsultantName = Textbox1.Text;
        placementConsultantList= pconsultant.SelectPlacementConsultant(PlacementConsultantName);
        
        if (placementConsultantList.Count != 0)
        {
            Error.Visible = false;
            GridView1.Visible = true;
            add();
        }
        else
        {
            Error.Visible = true;
            add();
        }
    }
    public void add()
    {
       
        GridView1.Visible = true;
        DataTable dt = new DataTable();
        DataColumn dc1 = new DataColumn("PlacementConsultantID");
        dt.Columns.Add(dc1);
        DataColumn dc2 = new DataColumn("Placement Consultant Name");
        dt.Columns.Add(dc2);
        DataColumn dc3 = new DataColumn("Placement Consultant Details");
        dt.Columns.Add(dc3);
        foreach (IPlacementConsultant placementConsultant in placementConsultantList)
        {
            DataRow dr = dt.NewRow();
            dr["PlacementConsultantID"] = placementConsultant.PlacementConsultantID;
            dr["Placement Consultant Name"] = placementConsultant.PlacementConsultantName;
            dr["Placement Consultant Details"] = placementConsultant.PlacementConsultantDetails;
            dt.Rows.Add(dr);
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label l1 = (Label)GridView1.Rows[e.RowIndex].FindControl("placementConsultantID");
        TextBox t1 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("name");
        TextBox t2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("details");
        pconsultant.UpdatePlacementConsultant(Convert.ToInt32(l1.Text), t1.Text.ToString(), t2.Text.ToString());
        GridView1.EditIndex = -1;
        add();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        add();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label l1 = (Label)GridView1.Rows[e.RowIndex].FindControl("Label3");
        pconsultant.DeletePlacementConsultant(Convert.ToInt32(l1.Text));
        add();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");

    }
}