

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Edit_TestSchedule_byTestAdmin.aspx.cs
 * This source is subject to the to ABC Public License. 
 * http://www.abc.erecruitment.com/  
 * All other rights reserved.  
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  EITHER 
 * EXPRESSED  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED  WARRANTIES OF
 * MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using E_Recruitment.Types;
using E_Recruitment.BLLFactory;
using System.Globalization;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pop_ddl_vac();
            
        }
    }  
      
    public void showgrid()
    {
        ITestStatusManager objTestStatusManager = TestStatusManagerFactory.Create_TestStatusManager();
        List<ITestStatus> lstTestStatus = objTestStatusManager.GetTestStatus(Convert.ToInt32(ddlVacancyID.SelectedValue));
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

        foreach (ITestStatus element in lstTestStatus)
        {
            DataRow objDataRow = objDataTable.NewRow();
            objDataRow["CandidateID"] = element.get_CandidateID;
            objDataRow["WrittenTestDate"] = element.get_Written_TestDate.ToString("dd/MM/yyyy");
            objDataRow["WrittenTestStatus"] = element.get_Written_TestStatus;
            objDataRow["TechnicalInterviewDate"] = element.get_Technical_InterviewDate.ToString("dd/MM/yyyy");
            objDataRow["TechnicalInterviewStatus"] = element.get_Technical_InterviewStatus;
            objDataRow["HRInterviewDate"] = element.get_HR_InterviewDate.ToString("dd/MM/yyyy");
            objDataRow["HRInterviewStatus"] = element.get_HR_InterviewStatus;
            objDataTable.Rows.Add(objDataRow);
        }
        gv.DataSource = objDataTable;
        gv.DataBind();
    }
    public void pop_ddl_vac()
    {
        try
        {
            ICandidateManager objCandidateManager = (ICandidateManager)CandidateManagerFactory.Candidate_Manager();
            List<int> lstVacancy = objCandidateManager.getVacancies();
            ddlVacancyID.Items.Add("--select--");
            foreach (int element in lstVacancy)
            {
                ddlVacancyID.Items.Add(element.ToString());
            }
        }
        catch (Exception)
        {
        }
    }
  
    public DateTime compare(int cand_id, string type)
    {
        try
        {
            DateTime objdate = Convert.ToDateTime("1/1/2012");
            ITestStatusManager objstatus = TestStatusManagerFactory.Create_TestStatusManager();
            List<ITestStatus> lstTeststatus = objstatus.GetTestStatus(Convert.ToInt32(ddlVacancyID.SelectedValue));
            if (type == "HR")
            {
                foreach (ITestStatus element in lstTeststatus)
                {
                    if (element.get_CandidateID == cand_id)
                    {
                        return element.get_HR_InterviewDate;
                    }
                }
            }
            if (type == "tech")
            {
                foreach (ITestStatus element in lstTeststatus)
                {
                    if (element.get_CandidateID == cand_id)
                    {
                        return element.get_Technical_InterviewDate;
                    }
                }
            }
            if (type == "written")
            {
                foreach (ITestStatus element in lstTeststatus)
                {
                    if (element.get_CandidateID == cand_id)
                    {
                        return element.get_Written_TestDate;
                    }
                }
            }
            return objdate;
        }
        catch (Exception)
        {
            return Convert.ToDateTime("1/1/2012");
        }
    }

   
    protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
    {
        lbWritten.Visible = false;
        lbTechnical.Visible = false;
        lbHR.Visible = false;
        gv.EditIndex = e.NewEditIndex;
        showgrid();
    }
    protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            DateTimeFormatInfo date = new DateTimeFormatInfo();
            date.ShortDatePattern = "dd/MM/yyyy";
            lbWritten.Visible = false;
            lbTechnical.Visible = false;
            lbHR.Visible = false;

            ITestStatusManager objTestStatusManager = TestStatusManagerFactory.Create_TestStatusManager();
            Label lbcandidateID = (Label)gv.Rows[e.RowIndex].FindControl("lbCandidateID");
            TextBox tb1 = (TextBox)gv.Rows[e.RowIndex].FindControl("tbWrittenTestDate");
            int intcandidate = Convert.ToInt32(lbcandidateID.Text);
            TextBox tbTechnicalDate = (TextBox)gv.Rows[e.RowIndex].FindControl("tbTechnicalInterviewDate");
            TextBox tb3 = (TextBox)gv.Rows[e.RowIndex].FindControl("tbHRInterviewDate");


            Label lbWrittenStatus = (Label)gv.Rows[e.RowIndex].FindControl("lbWrittenTestStatus");
            Label lbTechnicalStatus = (Label)gv.Rows[e.RowIndex].FindControl("lbTechnicalInterviewStatus");
            Label lbHRStatus = (Label)gv.Rows[e.RowIndex].FindControl("lbHRInterviewStatus");
            DateTime dtWritten, dtTechnical, dtHR;
            if (tb1.Text != "" && tbTechnicalDate.Text != "" && tb3.Text != "")
            {

                dtWritten = Convert.ToDateTime(tb1.Text, date);
                dtTechnical = Convert.ToDateTime(tbTechnicalDate.Text, date);
                dtHR = Convert.ToDateTime(tb3.Text, date);
                if (tb1.Text == tbTechnicalDate.Text || tbTechnicalDate.Text == tb3.Text || tb3.Text == tb1.Text)
                {
                    string script2 = "alert('No two test or interview dates can be same');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                }

                else if (dtWritten < dtTechnical && dtTechnical < dtHR)
                {


                    if (lbHRStatus.Text == "pending")
                    {
                        bool st = objTestStatusManager.validateTest(Convert.ToInt32(ddlVacancyID.SelectedValue), Convert.ToInt32(lbcandidateID.Text), dtHR);
                        if (st == false)
                        {
                            string script2 = "alert('HR interview date cannot be scheduled more than 3 days from the scheduled date.');";
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);

                        }
                        else
                        {
                            if (compare(intcandidate, "HR") != dtHR)
                                lbHR.Visible = true;
                            objTestStatusManager.updatetest(Convert.ToInt32(ddlVacancyID.SelectedValue), Convert.ToInt32(lbcandidateID.Text), "HR", dtHR);

                            if (lbTechnicalStatus.Text == "pending")
                            {
                                bool st1 = objTestStatusManager.validateTest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(lbcandidateID.Text), dtTechnical);
                                if (st1 == false)
                                {
                                    string script = "alert('Technical interview date cannot be scheduled more than 3 days from the scheduled date');";
                                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);

                                }
                                else
                                {
                                    if (compare(intcandidate, "tech") != dtTechnical)
                                        lbTechnical.Visible = true;
                                    objTestStatusManager.updatetest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(lbcandidateID.Text), "technical", dtTechnical);

                                    if (lbWrittenStatus.Text == "pending")
                                    {
                                        bool st2 = objTestStatusManager.validateTest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(lbcandidateID.Text), dtWritten);
                                        if (st2 == false)
                                        {
                                            string script = "alert(' Written test date cannot be scheduled more than 3 days from the scheduled date.');";
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);

                                        }
                                        else
                                        {
                                            if (compare(intcandidate, "written") != dtWritten)
                                                lbWritten.Visible = true;
                                            objTestStatusManager.updatetest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(lbcandidateID.Text), "written", dtWritten);

                                        }
                                    }
                                    else
                                    {
                                        string script5 = "alert('The written test status is cleared for canidate with id: '"+lbcandidateID.Text+".');";
                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script5, true);
                                    }
                                }
                            }
                            else
                            {
                                string script6 = "alert('The technical Interview status is cleared for candidate with id: '"+lbcandidateID.Text+".');";
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script6, true);
                            }
                        }
                    }
                    else
                    {
                        string script2 = "alert('The HR interview status is cleared for candidate with id: '"+lbcandidateID.Text+".');";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    }
                }
                else
                {
                    string script2 = "alert('Please check the entered dates.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                }
            }
            else
            {
                string script2 = "alert('Please enter valid dates.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
            gv.EditIndex = -1;
            showgrid();
        }
        catch (Exception)
        {
            string script2 = "alert('Please enter valid dates.');";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        gv.EditIndex = -1;
        showgrid();
    }
    protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        lbWritten.Visible = false;
        lbTechnical.Visible = false;
        lbHR.Visible = false;
        gv.EditIndex = -1;
        showgrid();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lbWritten.Visible = false;
        lbTechnical.Visible = false;
        lbHR.Visible = false;
        gv.Visible = true;
        gv.EditIndex = -1;
        showgrid();
    }
    protected void ddlVacancyID_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gv.Visible = false;
            lbWritten.Visible = false;
            lbTechnical.Visible = false;
            lbHR.Visible = false;
        }
        catch (Exception)
        {
            gv.Visible = false;
        }
    }
}
