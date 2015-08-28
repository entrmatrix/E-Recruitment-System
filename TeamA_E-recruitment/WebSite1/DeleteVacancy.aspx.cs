using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Types;
using BLLFactory;

public partial class DeleteVacancyRequest : System.Web.UI.Page
{
    IVacancyManager vacancyManager = VacancyManagerFactory.CreateVacancyManager();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!(IsPostBack))
            add();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //TextBox t1 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("noofpos");
        Label l1 = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
        string x = l1.Text.ToString();

        int result = vacancyManager.DeleteVacany(Convert.ToInt32(l1.Text));

        if (result == 0)
        {
            Label9.Visible = true;
            add();
        }
        else
        {
            Label9.Visible = false;
            add();
        }
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
  
}