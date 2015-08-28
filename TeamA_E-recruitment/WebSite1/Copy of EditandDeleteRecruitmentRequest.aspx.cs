using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLFactory;
using Types;
using System.Collections.Specialized;
using System.Text;
using System.Data;


public partial class EditandDeleteRecruitmentRequest : System.Web.UI.Page
{
    List<IRecruitmentRequest> recruitmentRequest = new List<IRecruitmentRequest>();
    IRecruitmentRequestManager recruitmentManager = RecruitmentRequestManagerFactory.CreateRecruitmentRequestManager();
    static int ii = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        recruitmentRequest = recruitmentManager.SelectingRecruitmentRequest();
        //if (ii == 1)
        if(!(IsPostBack))
        {
            ListItem[] items1 = new ListItem[recruitmentRequest.Count()];
            //ListItem[] items1 = new ListItem[3];
            int i = 0;
            foreach (IRecruitmentRequest r in recruitmentRequest)
            {

                string val = r.RecruitmentRequestID.ToString();
                string s = r.RecruitmentRequestID.ToString();
                items1[i] = new ListItem(s, (val));
                i++;
            }
            
            DropDownList1.Items.AddRange(items1);
            ii++;
        }
        //GridView2.Visible = false;
        if (!Page.IsPostBack)

            GridView1.Visible = false;
    }

    private void BindGridView(int recruitmentRequestId)
    {
        GridView1.Visible = true;
        GridView1.DataSource = recruitmentManager.getRecruitmentRequests(recruitmentRequestId);
        GridView1.DataBind();
        //GridView2.DataSource = recruitmentManager.SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(1);
        //GridView2.DataBind();
        // Should also create a dictionary which holds Placement Consultant ID and Placement Consultant Name as key-value pair

    }


    protected void Edit(Object sender, EventArgs e)
    {
        int index = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
        Label recruitmentRequestID = (Label)GridView1.Rows[index].Cells[2].FindControl("Label1");

        int value = Convert.ToInt32(recruitmentRequestID.Text);

        //int value = Convert.ToInt32(1);
        Session["recruitmentRequestID"] = value;
        add(value);
        //GridView2.DataSource = recruitmentManager.SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID(1);
        //GridView2.DataBind();
        //GridView2.Visible = true;
    }

    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        Label l1 = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
        int result = recruitmentManager.DeleteRecruitmentRequest(Convert.ToInt32(l1.Text));

        if (result != 0)
        {
            Label10.Visible = false;
            DropDownList1.SelectedItem.Enabled = false;
        }
        else
        {
            Label10.Visible = true;
        }

    }

    public void add(int recruitmentRequestID)
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

        List<IVacancy> vacancyList = recruitmentManager.SearchOpenStatusedVacancyOrWithNULLRecruitmentRequestID((int)Session["recruitmentRequestID"]);

        List<int> vacancyIDs = recruitmentManager.getAssignedVacancies(recruitmentRequestID);

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

        GridView2.DataSource = dt;
        GridView2.DataBind();
        int count = 0;
        foreach (IVacancy i in vacancyList)
        {
            foreach (int vacid in vacancyIDs)
            {
                if (vacid == i.VacancyID)
                {
                    CheckBox cb = (CheckBox)GridView2.Rows[count].Cells[0].FindControl("CheckBox1");

                    cb.Checked = true;
                }
            }

            count++;
        }
        Button1.Visible = true;
        Button2.Visible = true;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        List<int> IDs = new List<int>();

        int id;

        for (int i = 0; i < GridView2.Rows.Count; i++)
        {

            CheckBox cb = (CheckBox)GridView2.Rows[i].Cells[0].FindControl("CheckBox1");

            if (cb != null)
            {
                if (cb.Checked)
                {
                    //id = Convert.ToInt32(GridView2.Rows[i].Cells[1].Text);
                    Label label1 = (Label)(GridView2.Rows[i].Cells[0].FindControl("Label1"));
                    id = Convert.ToInt32(label1.Text);
                    IDs.Add(id); // Adding checked IDs to list
                }
            }
        }
        if (IDs.Count == 0)
        {
            Label9.Visible = false;
            Label9.Text = "Select a vacancy";
        }
        else
        {
            Label9.Visible = false;
            UpdateRecords(IDs);
        }

    }

    private void UpdateRecords(List<int> list)
    {

        // Traverse the grid view and get the checked rows

        //use session saved earlier
        int recid = (int)Session["recruitmentRequestID"];
        int result = recruitmentManager.EditRecruitmentRequest(recid, list);

        if (result == 0)
        {
            Label10.Visible = true;
        }
        else
        {
            Label10.Visible = false;
        }
    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string select = DropDownList1.SelectedItem.Text.ToString();
        if (!select.Equals("--select--"))
        {
            int recruitmentRequestId = Convert.ToInt32(DropDownList1.SelectedItem.Text);

            //Label9.Text = recruitmentRequestID.ToString();
            BindGridView(recruitmentRequestId);
        }
        else
        {
            GridView1.Visible = false;
            GridView2.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}