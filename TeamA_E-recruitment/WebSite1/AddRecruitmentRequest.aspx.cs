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


public partial class AddRecruitmentRequest : System.Web.UI.Page
{
    IRecruitmentRequestManager recruitmentManager = RecruitmentRequestManagerFactory.CreateRecruitmentRequestManager();
    
    IPlacementConsultantManager placementManager = PlacementConsultantManagerFactory.CreatePlacementConsultantManager();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)

            BindGridView();
    }

    private void BindGridView()
    {
        
        List<IVacancy> vacancyList = recruitmentManager.VacancyRequestWithNULLRecruitmentRequestID();

        if(vacancyList.Count!=0)
        {
            Error.Visible = false;
            GridView1.DataSource = vacancyList; 
            GridView1.DataBind();
        }
        else
        {
            Error.Visible = true;
        }

        Dictionary<int, string> list = placementManager.loadPlacementConsultant();

        ListItem[] placementConsultantItems = new ListItem[list.Count];

        int i = 0;

        foreach (KeyValuePair<int, string> k in list)
        {
            placementConsultantItems[i] = new ListItem(k.Value, k.Key.ToString());
            i++;
        }

        PlacementConsultantDropDownList.Items.AddRange(placementConsultantItems);

    }

    protected void CreateButton_Click(object sender, EventArgs e)
    {
        List<int> IDs = new List<int>();

        int id;

        for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            CheckBox cb = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("CheckBox1");

            if (cb != null)
            {
                if (cb.Checked)
                {
                    //id = Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                     Label label1 = (Label)(GridView1.Rows[i].Cells[0].FindControl("Label1"));
                     id = Convert.ToInt32(label1.Text);
                    IDs.Add(id); // Adding checked IDs to list
                }
            }
        }
        if (IDs.Count == 0)
        {
            Label11.Visible = true;
            Label11.Text = "Select vacancy";
        }
        else
        {
            Label11.Visible = false;
            AddRecords(IDs);

            BindGridView();
            Label10.Text = "Added Successfully";
            Label10.Visible = true;
        }

    }

    private void AddRecords(List<int> list)
    {
        
        // Traverse the grid view and get the checked rows

        DateTime requiredDate;
        int placementConsultantID;

        requiredDate = Convert.ToDateTime(RequiredDate.CalendarDateString);
        placementConsultantID = Convert.ToInt32(PlacementConsultantDropDownList.SelectedItem.Value);
        recruitmentManager.InsertRecruitmentRequest(requiredDate, placementConsultantID, list);
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}