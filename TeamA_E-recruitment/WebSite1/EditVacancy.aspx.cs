using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using BLLFactory;
using System.Data;
public partial class EditVacancyRequest : System.Web.UI.Page
{
    IVacancyManager vacancyManager = VacancyManagerFactory.CreateVacancyManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        //int employeeID = (int)Session["empid"];
        //IVacancyManager vacancyManager = VacancyManagerFactory.CreateVacancytManager();
        //List<IVacancy> vacancyList= vacancyManager.SelectVacancy(2);
        if(!(IsPostBack))
        add();
        
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {


    }

  
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        add();
    }
    public void add()
    {
        DataTable dt = new DataTable();
        DataColumn dc1 = new DataColumn("Vacancy Id");
        dt.Columns.Add(dc1);
        DataColumn dc2 = new DataColumn("Number of Positions");
        dt.Columns.Add(dc2);
        DataColumn dc3 = new DataColumn("Required Date");
        dt.Columns.Add(dc3);
        DataColumn dc4 = new DataColumn("Skills");
        dt.Columns.Add(dc4);
        DataColumn dc = new DataColumn("Domain");
        dt.Columns.Add(dc);
        DataColumn dc6 = new DataColumn("Experience");
        dt.Columns.Add(dc6);
        DataColumn dc7 = new DataColumn("Loctaion");
        dt.Columns.Add(dc7);
        DataColumn dc8 = new DataColumn("Status");
        dt.Columns.Add(dc8);

        List<IVacancy> vacancyList = vacancyManager.SelectVacancy((int)Session["empid"]);
        if (vacancyList.Count != 0)
        {
            Error.Visible = false;
            foreach (IVacancy vacancy in vacancyList)
            {
                DataRow dr = dt.NewRow();
                dr["Vacancy Id"] = vacancy.VacancyID;
                dr["Number of Positions"] = vacancy.NoOfPositions;
                dr["Required Date"] = vacancy.RequiredDate;
                dr["Skills"] = vacancy.Skills;
                dr["Domain"] = vacancy.Domain;
                dr["Experience"] = vacancy.Experience;
                dr["Loctaion"] = vacancy.Location;
                dr["Status"] = vacancy.Status;
                dt.Rows.Add(dr);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            Error.Visible = true;
        }
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label l1=(Label)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
        TextBox t1 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("noofpos");
        TextBox t2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("reqdate");
        TextBox t3 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("skills");
        Label l = (Label)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
        TextBox t4 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("experience");
        TextBox t5 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("location");
        
        int uid = (int)Session["uid"];
            int aprved = 1;
            if (uid == 0)
                aprved = 3;
            
            int result = vacancyManager.UpdateVacancy(Convert.ToInt32(l1.Text), Convert.ToInt32(t1.Text), Convert.ToDateTime(t2.Text), t3.Text.ToString(), Convert.ToInt32(t4.Text), t5.Text.ToString(), aprved);
            
            if (result == 0)
            {
                Label9.Visible = true;
            }
            else
            {
                Label9.Visible = false;
            }

            GridView1.EditIndex = -1;
    
            add();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}
