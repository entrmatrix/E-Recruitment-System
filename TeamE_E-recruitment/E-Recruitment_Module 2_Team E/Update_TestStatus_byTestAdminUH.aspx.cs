using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_Recruitment.Types;
using E_Recruitment.BLLFactory;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            display();
        }
    }
    void display()
    {
        ITestManager objTestManager = TestManagerFactory.CreateTestManager();
        List<ITest> lstVacancies = objTestManager.GetTest();
        ddl_VacancyID.Items.Clear();

        foreach (ITest objelement in lstVacancies)
        {
            ddl_VacancyID.Items.Add(objelement.get_VacancyID.ToString());
        }
        ddl_VacancyID.SelectedIndex = 0;
    }



    protected void Submit_Click(object sender, EventArgs e)
    {
        showgrid();
    }

    public void showgrid()
    {
        ITestStatusManager objTestAdminManager = TestStatusManagerFactory.Create_TestStatusManager();
        List<ITestStatus> lstTestStatus = new List<ITestStatus>();
        lstTestStatus = objTestAdminManager.GetTestStatus(Convert.ToInt32(ddl_VacancyID.SelectedValue));
        DataTable objDataTable = new DataTable();
        DataColumn objDataColumn1 = new DataColumn("CandidateID");
        objDataTable.Columns.Add(objDataColumn1);
        DataColumn objDataColumn2 = new DataColumn("WrittenTestDate");
        objDataTable.Columns.Add(objDataColumn2);
        DataColumn objDataColumn3 = new DataColumn("WrittenTestStatus");
        objDataTable.Columns.Add(objDataColumn3);
        DataColumn objDataColumn4 = new DataColumn("TechnicalInterviewDate");
        objDataTable.Columns.Add(objDataColumn4);
        DataColumn objDataColumn5 = new DataColumn("TechnicalInterviewStatus");
        objDataTable.Columns.Add(objDataColumn5);
        DataColumn objDataColumn6 = new DataColumn("HRInterviewDate");
        objDataTable.Columns.Add(objDataColumn6);
        DataColumn objDataColumn7 = new DataColumn("HRInterviewStatus");
        objDataTable.Columns.Add(objDataColumn7);

        foreach (ITestStatus TestStatus in lstTestStatus)
        {
            DataRow objDataRow = objDataTable.NewRow();
            objDataRow["CandidateID"] = TestStatus.get_CandidateID;
            objDataRow["WrittenTestDate"] = TestStatus.get_Written_TestDate.ToString("dd/MM/yyyy");
            objDataRow["WrittenTestStatus"] = TestStatus.get_Written_TestStatus;
            objDataRow["TechnicalInterviewDate"] = TestStatus.get_Technical_InterviewDate.ToString("dd/MM/yyyy");
            objDataRow["TechnicalInterviewStatus"] = TestStatus.get_Technical_InterviewStatus;
            objDataRow["HRInterviewDate"] = TestStatus.get_HR_InterviewDate.ToString("dd/MM/yyyy");
            objDataRow["HRInterviewStatus"] = TestStatus.get_HR_InterviewStatus;
            objDataTable.Rows.Add(objDataRow);

        }
        gv_TestStatus.DataSource = objDataTable;
        gv_TestStatus.DataBind();


    }

    protected void gv_TestStatus_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gv_TestStatus.EditIndex = e.NewEditIndex;
        showgrid();
    }
    protected void gv_TestStatus_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_TestStatus.EditIndex = -1;
        showgrid();
    }

    protected void gv_TestStatus_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        ITestStatusManager objTestStatusManager = TestStatusManagerFactory.Create_TestStatusManager();
        Label lbCandidateID = (Label)gv_TestStatus.Rows[e.RowIndex].FindControl("CandidateID");
        DropDownList ddlWrittenTestStatus = (DropDownList)gv_TestStatus.Rows[e.RowIndex].FindControl("WrittenTestStatus");
        DropDownList ddlTechnicalInterviewStatus = (DropDownList)gv_TestStatus.Rows[e.RowIndex].FindControl("TechnicalInterviewStatus");
        DropDownList ddlHRInterviewStatus = (DropDownList)gv_TestStatus.Rows[e.RowIndex].FindControl("HRInterviewStatus");
        int i = objTestStatusManager.update_TestStatus(Convert.ToInt32(lbCandidateID.Text), ddlWrittenTestStatus.Text, ddlTechnicalInterviewStatus.Text, ddlHRInterviewStatus.Text);
        ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
        List<ICandidateProfile> lstCandidateProfile = new List<ICandidateProfile>();
        lstCandidateProfile = objCandidateManager.display_candidate_toPC();
        switch (i)
        {
            case 1: int status = 0;
                foreach (ICandidateProfile element in lstCandidateProfile)
                {
                    if (element.get_CandidateProfileID == Convert.ToInt32(lbCandidateID.Text))
                    {
                        if (element.get_TestStatus == 2)
                        {
                            status = 1;
                        }
                        else if (element.get_TestStatus == 3)
                        {
                            status = 2;
                        }
                        else if (element.get_TestStatus == 4)
                        {
                            status = 3;
                        }
                    }
                }
                switch (status)
                {
                    case 1: string script2 = "alert('Candidate ID :" + lbCandidateID.Text + " Written Test status has been updated successfully.');";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                        break;

                    case 2: string script3 = "alert('Candidate ID :" + lbCandidateID.Text + " Technical Interview status has been updated successfully.');";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script3, true);
                        break;

                    case 3: string script4 = "alert('Candidate ID :" + lbCandidateID.Text + " HR Interview status has been updated successfully.');";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script4, true);
                        break;
                }

                break;
            case 2: string script5 = "alert('HR Interview cannot be cleared before Technical and Written Test.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script5, true);
                break;
            case 3: string script6 = "alert('Technical Interview cannot be cleared before Written Test.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script6, true);
                break;
            case 4: string script7 = "alert('Technical or HR Interview cannot be cleared before Written Test.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script7, true);
                break;
            case 5: string script8 = "alert('HR cannot be cleared before Technical.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script8, true);
                break;

        }

        gv_TestStatus.EditIndex = -1;
        showgrid();
    }


    protected void gv_TestStatus_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_TestStatus.PageIndex = e.NewPageIndex;
        showgrid();
    }


}
