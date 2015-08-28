

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Edit_TestSchedule_byHR.aspx.cs
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
        List<ITestStatus> lstTestStatus= objTestStatusManager.GetTestStatus(Convert.ToInt32(ddlVacancyID.SelectedValue));
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
        
        foreach (ITestStatus objelement in lstTestStatus)
        {
            DataRow objDataRow = objDataTable.NewRow();
            objDataRow["CandidateID"] = objelement.get_CandidateID;
            objDataRow["WrittenTestDate"] = objelement.get_Written_TestDate.ToString("dd/MM/yyyy");
            objDataRow["WrittenTestStatus"] = objelement.get_Written_TestStatus;
            objDataRow["TechnicalInterviewDate"] = objelement.get_Technical_InterviewDate.ToString("dd/MM/yyyy");
            objDataRow["TechnicalInterviewStatus"] = objelement.get_Technical_InterviewStatus;
            objDataRow["HRInterviewDate"] = objelement.get_HR_InterviewDate.ToString("dd/MM/yyyy");
            objDataRow["HRInterviewStatus"] = objelement.get_HR_InterviewStatus;
            objDataTable.Rows.Add(objDataRow);
        }
        gv.DataSource = objDataTable;
        gv.DataBind();
    }
   

   

    public void pop_ddl_vac()
    {
        try
        {
            ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
            List<int> lstVacancies = objCandidateManager.getVacancies();
            ddlVacancyID.Items.Add("--select--");
            foreach (int element in lstVacancies)
            {
                ddlVacancyID.Items.Add(element.ToString());
            }
        }
        catch (Exception)
        {
        }

    }
   
    public DateTime compare(int cand_id,string type)
    {
        try
        {
            DateTime date = Convert.ToDateTime("1/1/2012");
            ITestStatusManager objTestStatusManager = TestStatusManagerFactory.Create_TestStatusManager();
            List<ITestStatus> lstTestStatus = objTestStatusManager.GetTestStatus(Convert.ToInt32(ddlVacancyID.SelectedValue));
            if (type == "HR")
            {
                foreach (ITestStatus element in lstTestStatus)
                {
                    if (element.get_CandidateID == cand_id)
                    {
                        return element.get_HR_InterviewDate;
                    }
                }
            }
            if (type == "tech")
            {
                foreach (ITestStatus objelement in lstTestStatus)
                {
                    if (objelement.get_CandidateID == cand_id)
                    {
                        return objelement.get_Technical_InterviewDate;
                    }
                }
            }
            if (type == "written")
            {
                foreach (ITestStatus objelement in lstTestStatus)
                {
                    if (objelement.get_CandidateID == cand_id)
                    {
                        return objelement.get_Written_TestDate;
                    }
                }
            }
            return date;
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
    protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            DateTimeFormatInfo w = new DateTimeFormatInfo();
            w.ShortDatePattern = "dd/MM/yyyy";
            lbWritten.Visible = false;
            lbTechnical.Visible = false;
            lbHR.Visible = false;

            ITestStatusManager objTestStatusManager = TestStatusManagerFactory.Create_TestStatusManager();
            Label l1 = (Label)gv.Rows[e.RowIndex].FindControl("CandidateID");
            TextBox tb1 = (TextBox)gv.Rows[e.RowIndex].FindControl("WrittenTestDate");
            int c = Convert.ToInt32(l1.Text);
            TextBox tb2 = (TextBox)gv.Rows[e.RowIndex].FindControl("TechnicalInterviewDate");
            TextBox tb3 = (TextBox)gv.Rows[e.RowIndex].FindControl("HRInterviewDate");


            Label l2 = (Label)gv.Rows[e.RowIndex].FindControl("WrittenTestStatus");
            Label l3 = (Label)gv.Rows[e.RowIndex].FindControl("TechnicalInterviewStatus");
            Label l4 = (Label)gv.Rows[e.RowIndex].FindControl("HRInterviewStatus");
            DateTime written, tech, hr;
            if (tb1.Text != "" && tb2.Text != "" && tb3.Text != "")
            {

                written = Convert.ToDateTime(tb1.Text, w);
                tech = Convert.ToDateTime(tb2.Text, w);
                hr = Convert.ToDateTime(tb3.Text, w);
                if (tb1.Text == tb2.Text || tb2.Text == tb3.Text || tb3.Text == tb1.Text)
                {
                    string script2 = "alert('No two test or interview dates can be same');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                }

                else if (written < tech && tech < hr)
                {


                    if (l4.Text == "pending")
                    {
                        bool st = objTestStatusManager.validateTest(Convert.ToInt32(ddlVacancyID.SelectedValue), Convert.ToInt32(l1.Text), hr);
                        if (st == false)
                        {
                            string script2 = "alert('HR interview date cannot be rescheduled more than 3 days from the scheduled date.');";
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);

                        }
                        else
                        {
                            if (compare(c, "HR") != hr)
                                lbHR.Visible = true;
                         
                            
                            objTestStatusManager.updatetest(Convert.ToInt32(ddlVacancyID.SelectedValue), Convert.ToInt32(l1.Text), "HR", hr);

                            if (l3.Text == "pending")
                            {
                                bool st1 = objTestStatusManager.validateTest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(l1.Text), tech);
                                if (st1 == false)
                                {
                                    string script = "alert('Technical interview date cannot be rescheduled more than 3 days from the scheduled date.');";
                                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);

                                }
                                else
                                {
                                    if (compare(c, "tech") != tech)
                                        lbTechnical.Visible = true;
                                  
                                    objTestStatusManager.updatetest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(l1.Text), "technical", tech);

                                    if (l2.Text == "pending")
                                    {
                                        bool st2 = objTestStatusManager.validateTest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(l1.Text), written);
                                        if (st2 == false)
                                        {
                                            string script = "alert(' Written test date cannot be rescheduled more than 3 days from the scheduled date.');";
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);

                                        }
                                        else
                                        {
                                            if (compare(c, "written") != written)
                                                lbWritten.Visible = true;
                                           
                                                objTestStatusManager.updatetest(Convert.ToInt32(ddlVacancyID.SelectedItem.Text), Convert.ToInt32(l1.Text), "written", written);

                                        }
                                    }
                                    else
                                    {
                                        string script5 = "alert('The written test status is cleared for candidate with id: '"+l1.Text+".');";
                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script5, true);
                                    }
                                }
                            }
                            else
                            {
                                string script6 = "alert('The technical Interview status is cleared for candidate with id: '"+l1.Text+".');";
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script6, true);
                            }
                        }
                    }
                    else
                    {
                        string script2 = "alert('The HR interview status is cleared for the candidate with id: '"+l1.Text+".');";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    }
                }
                else
                {
                    string script2 = "alert('Please check the entered dates');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                }
            }
            else
            {
                string script2 = "alert('Please enter the  valid dates');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
            gv.EditIndex = -1;
            showgrid();
        }
        catch (Exception)
        {
            string script2 = "alert('Please enter the valid dates');";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
        }
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
