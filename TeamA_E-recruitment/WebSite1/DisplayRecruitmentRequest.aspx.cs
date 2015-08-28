using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using BLLFactory;
using Types;
using BLLFactory;
using System.Data;
public partial class DisplayRecruitmentRequest : System.Web.UI.Page
{
    static int checkin=1;
    List<IRecruitmentRequest> recruitmentRequest = new List<IRecruitmentRequest>();
    IRecruitmentRequestManager recruitmentManager = RecruitmentRequestManagerFactory.CreateRecruitmentRequestManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        recruitmentRequest.Clear();
        recruitmentRequest = recruitmentManager.SelectingRecruitmentRequest();
        //if (checkin == 1)
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
            checkin++;
            
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string select = DropDownList1.SelectedItem.Text.ToString();
        if (!select.Equals("--select--"))
        {
            GridView1.Visible = true;
            int recruitmentRequestID = Convert.ToInt32(DropDownList1.SelectedItem.Text);

            //Label9.Text = recruitmentRequestID.ToString();
            add(recruitmentRequestID);
        }
        else
        {
            GridView1.Visible = false;
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
        List<IVacancy> vacancyList = recruitmentManager.SearchRecruitmentRequest(recruitmentRequestID);
        //List<IVacancy> vacancyList = vacancyManager.SelectVacancy((int)Session["empid"]);
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}