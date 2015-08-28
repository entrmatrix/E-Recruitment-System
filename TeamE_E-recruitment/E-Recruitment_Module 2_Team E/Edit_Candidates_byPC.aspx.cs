

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Edit_Candidate_byPC.aspx.cs
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
    DateTimeFormatInfo date = new DateTimeFormatInfo();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            showlist();
             gv.Visible = false;
        }
    }

    public void showlist()
    {
        try
        {
            ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
            List<int> lstVancancies = objCandidateManager.getVacancies();
            List<ICandidateProfile> lstcandidates = objCandidateManager.display_candidate_toPC();

            for (int i = 0; i < lstVancancies.Count; i++)
            {
                foreach (ICandidateProfile objcandidate in lstcandidates)
                {
                    if (objcandidate.get_VacancyID == lstVancancies.ElementAt(i) && (objcandidate.get_TestID == 0))
                    {
                        ListItem Dropdownlist = new ListItem(Convert.ToString(lstVancancies.ElementAt(i)), Convert.ToString(lstVancancies.ElementAt(i)), true);

                        ddlvacancy.Items.Add(Dropdownlist);
                        break;
                    }
                }
            }
        }
        catch (Exception)
        {
        }
    }



    public void showgrid(int VacancyID)
    {
        try
        {
            string gap_ineducation, gap_inexperience;
            ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
            List<ICandidateProfile> lstCandidateProfile = objCandidateManager.display_candidate_toPC();

            DataTable objDataTable = new DataTable();
            DataColumn objDataColumn1 = new DataColumn("CandidateProfileID");
            objDataTable.Columns.Add(objDataColumn1);
            DataColumn objDataColumn2 = new DataColumn("DOB");
            objDataTable.Columns.Add(objDataColumn2);
            DataColumn objDataColumn3 = new DataColumn("Location");
            objDataTable.Columns.Add(objDataColumn3);
            DataColumn objDataColumn4 = new DataColumn("Gender");
            objDataTable.Columns.Add(objDataColumn4);
            DataColumn objDataColumn5 = new DataColumn("Percentage_10");
            objDataTable.Columns.Add(objDataColumn5);
            DataColumn objDataColumn6 = new DataColumn("Percentage_12");
            objDataTable.Columns.Add(objDataColumn6);
            DataColumn objDataColumn7 = new DataColumn("GapInEducation");
            objDataTable.Columns.Add(objDataColumn7);
            DataColumn objDataColumn8 = new DataColumn("GapInExperience");
            objDataTable.Columns.Add(objDataColumn8);

            foreach (ICandidateProfile candidate in lstCandidateProfile)
            {
                if (candidate.get_VacancyID == VacancyID && candidate.get_TestID == 0)
                {
                    DataRow objDataRow = objDataTable.NewRow();
                    objDataRow["CandidateProfileID"] = candidate.get_CandidateProfileID;
                    objDataRow["DOB"] = candidate.get_DOB.ToString("dd/MM/yyyy"); //"dd/MM/yyyy"
                    objDataRow["Location"] = candidate.get_Location;
                    objDataRow["Gender"] = candidate.get_Gender;
                    objDataRow["Percentage_10"] = candidate.get_Percentage_10;
                    objDataRow["Percentage_12"] = candidate.get_Percentage_12;

                    if (candidate.get_GapInEducation == 0)
                        gap_ineducation = "No";
                    else gap_ineducation = "Yes";

                    if (candidate.get_GapInExperience == 0)
                        gap_inexperience = "No";
                    else gap_inexperience = "Yes";

                    objDataRow["GapInEducation"] = gap_ineducation;
                    objDataRow["GapInExperience"] = gap_inexperience;

                    objDataTable.Rows.Add(objDataRow);
                }
            }

            gv.DataSource = objDataTable;
            gv.DataBind();
            gv.Visible = true;
        }
        catch (Exception)
        {
        }
    }
    protected void gv_SelectedIndexChanged(object sender, EventArgs e)
    {
       date.ShortDatePattern = "dd/MM/yyyy";
        try
        {
            GridViewRow row = gv.SelectedRow;
            int intCandidateProfileID = Convert.ToInt32(((Label)row.FindControl("CandidateProfileID")).Text);
            Session["DOB"] = Convert.ToDateTime(((Label)row.FindControl("DOB")).Text,date);
            Session["Location"] = Convert.ToString(((Label)row.FindControl("Location")).Text);
            Session["Gender"] = Convert.ToString(((Label)row.FindControl("Gender")).Text);
            Session["Percentage_10"] = Convert.ToDouble(((Label)row.FindControl("Percentage_10")).Text);
            Session["Percentage_12"] = Convert.ToDouble(((Label)row.FindControl("Percentage_12")).Text);
            Session["GapInEducation"] = Convert.ToString(((Label)row.FindControl("GapInEducation")).Text);
            Session["GapInExperience"] = Convert.ToString(((Label)row.FindControl("GapInExperience")).Text);
            Session["CandidateProfileID"] = intCandidateProfileID;

            Response.Redirect("Edit_Candidates_Page 2.aspx");
        }
        catch (Exception)
        {
        }
    }

    protected void gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int intCandidateProfileID = Convert.ToInt32(((Label)gv.Rows[e.RowIndex].FindControl("CandidateProfileID")).Text);
            ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
            if (objCandidateManager.DeleteCandidateProfile(intCandidateProfileID) == 0)
            {
                string script2 = "alert('Candidate with ID:'" + intCandidateProfileID + "' has been deleted');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }

            showgrid(Convert.ToInt32(ddlvacancy.SelectedItem.Text));
        }
        catch (Exception)
        {
        }
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        string strVacancyID = ddlvacancy.SelectedItem.Text;
        Session["VacancyID"] = strVacancyID;
        showgrid(Convert.ToInt32(strVacancyID));
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        gv.EditIndex = -1;
        showgrid(Convert.ToInt32(ddlvacancy.SelectedItem.Text));
    }
}