

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Update_MedicalStatus_byHR.aspx.cs
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
using System.Data.SqlClient;
using E_Recruitment.Types;
using E_Recruitment.BLLFactory;

public partial class _Default : System.Web.UI.Page
{
    List<int> lstnum = new List<int>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pop_ddl_vac();
        }
    }
   
   
  
    public void med_Status( int vac_ID)
    {
        try
        {
            ICandidateManager objCandidate = CandidateManagerFactory.Candidate_Manager();
            List<ICandidateProfile> lstCandidates = objCandidate.display_candidate_toPC();
            DataTable objDataTable = new DataTable();
            DataColumn objDatacolum1 = new DataColumn("CandidateID");
            objDataTable.Columns.Add(objDatacolum1);
            DataColumn objDatacolum2 = new DataColumn("TestStatus");
            objDataTable.Columns.Add(objDatacolum2);
            DataColumn objDatacolum3 = new DataColumn("MedicalTestStatus");
            objDataTable.Columns.Add(objDatacolum3);

            foreach (ICandidateProfile element in lstCandidates)
            {
                DataRow objDataRow = objDataTable.NewRow();
                if (element.get_VacancyID == vac_ID)
                {
                    objDataRow["CandidateID"] = element.get_CandidateProfileID;
                    if (element.get_TestStatus == 0)
                        objDataRow["TestStatus"] = "not initialised";
                    else if (element.get_TestStatus == 1)
                        objDataRow["TestStatus"] = "written conducted";
                    else if (element.get_TestStatus == 2)
                        objDataRow["TestStatus"] = "technical conducted";
                    else if (element.get_TestStatus == 3)
                        objDataRow["TestStatus"] = "HR conducted";
                    else if (element.get_TestStatus == 4)
                        objDataRow["TestStatus"] = "medical testing";
                    else if (element.get_TestStatus == 5)
                        objDataRow["TestStatus"] = "BGC initiated";
                    else
                        objDataRow["TestStatus"] = "confirmed";

                    if (element.get_MedicalTestStatus == 0)
                        objDataRow["MedicalTestStatus"] = "not initiated";
                    if (element.get_MedicalTestStatus == 1)
                        objDataRow["MedicalTestStatus"] = "cleared";
                    if (element.get_MedicalTestStatus == 2)
                        objDataRow["MedicalTestStatus"] = "rejected";

                    objDataTable.Rows.Add(objDataRow);
                }
            }
            gv_UpdateMedicalStatus.DataSource = objDataTable;
            gv_UpdateMedicalStatus.DataBind();

        }
        catch (Exception)
        {
        }

    }
    protected void gv_UpdateMedicalStatus_RowEditing(object sender, GridViewEditEventArgs e)
    {

        gv_UpdateMedicalStatus.EditIndex = e.NewEditIndex;
        med_Status( Convert.ToInt32(ddlVacancyID.SelectedValue));

    }
    protected void gv_UpdateMedicalStatus_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            DropDownList ddlmedical = gv_UpdateMedicalStatus.Rows[e.RowIndex].FindControl("ddlMedicalStatus") as DropDownList;
            ICandidateManager objcandidateManager = CandidateManagerFactory.Candidate_Manager();
            Label lb1 = (Label)gv_UpdateMedicalStatus.Rows[e.RowIndex].FindControl("lbCandidateID");
            Label lb2 = (Label)gv_UpdateMedicalStatus.Rows[e.RowIndex].FindControl("lbTestStatus");


            if (ddlmedical.SelectedValue != "rejected" && lb2.Text == "medical testing")
            {
                lb2.Text = "BGC initiated";
            }
            int inta = Convert.ToInt32(ddlmedical.SelectedIndex);
            inta++;
            int intb = 0;
            if (lb2.Text == "written conducted")
            { intb = 1; }
            else if (lb2.Text == "technical conducted")
            { intb = 2; }
            else if (lb2.Text == "HR conducted")
            { intb = 3; }
            else if (lb2.Text == "medical testing")
            { intb = 4; }
            else if (lb2.Text == "BGC initiated")
            { intb = 5; }
            else if (lb2.Text == "confirmed")
            { intb = 6; }

            int inti = objcandidateManager.med_update(Convert.ToInt32(lb1.Text), intb, inta);
            if (inti == 0)
            {
                string script2 = "alert('The test status is "+lb2.Text+" for candidate with id: "+lb1.Text+".');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
            else
            {
                string script2 = "alert('Successfully updated Medical Test Status.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
            gv_UpdateMedicalStatus.EditIndex = -1;
            med_Status(Convert.ToInt32(ddlVacancyID.SelectedValue));
        }
        catch (Exception)
        {
        }
    }
    protected void gv_UpdateMedicalStatus_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_UpdateMedicalStatus.EditIndex = -1;
        med_Status( Convert.ToInt32(ddlVacancyID.SelectedValue));
    }
    
    

    public void pop_ddl_vac()
    {
        try
        {
            ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ddlVacancyID.SelectedValue != "--select--")
            med_Status(Convert.ToInt32(ddlVacancyID.SelectedValue));
        gv_UpdateMedicalStatus.Visible = true;
    }


    protected void gv_UpdateMedicalStatus_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_UpdateMedicalStatus.PageIndex = e.NewPageIndex;
        gv_UpdateMedicalStatus.EditIndex = -1;
        med_Status(Convert.ToInt32(ddlVacancyID.SelectedValue));
    }
    protected void ddlVacancyID_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            gv_UpdateMedicalStatus.EditIndex = -1;
            med_Status(Convert.ToInt32(ddlVacancyID.SelectedValue));

            gv_UpdateMedicalStatus.Visible = false;
        }
        catch (Exception)
        {
            gv_UpdateMedicalStatus.Visible = false;
        }
    }
}