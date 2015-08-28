

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Display_Candidates_toPC.aspx.cs
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
            popvacancy();
        }
    }
 

    void showgrid(int VacancyID)
    {
        try
        {
            ICandidateManager objcandidatemanager = CandidateManagerFactory.Candidate_Manager();
            List<ICandidateProfile> lstcandidate = objcandidatemanager.display_candidate_toPC();

            DataTable objDataTable = new DataTable();
            DataColumn objDataColumn2 = new DataColumn("get_CandidateProfileID");
            objDataTable.Columns.Add(objDataColumn2);
            DataColumn objDataColumn3 = new DataColumn("get_DOB");
            objDataTable.Columns.Add(objDataColumn3);
            DataColumn objDataColumn4 = new DataColumn("get_Gender");
            objDataTable.Columns.Add(objDataColumn4);
            DataColumn objDataColumn5 = new DataColumn("get_Location");
            objDataTable.Columns.Add(objDataColumn5);
            DataColumn objDataColumn6 = new DataColumn("get_Percentage_10");
            objDataTable.Columns.Add(objDataColumn6);
            DataColumn objDataColumn7 = new DataColumn("get_Percentage_12");
            objDataTable.Columns.Add(objDataColumn7);
            DataColumn objDataColumn8 = new DataColumn("get_GapInEducation");
            objDataTable.Columns.Add(objDataColumn8);
            DataColumn objDataColumn9 = new DataColumn("get_GapInExperience");
            objDataTable.Columns.Add(objDataColumn9);

            foreach (ICandidateProfile candidate in lstcandidate)
            {
                if (candidate.get_VacancyID == VacancyID)
                {
                    DataRow objDataRow = objDataTable.NewRow();
                    objDataRow["get_CandidateProfileID"] = candidate.get_CandidateProfileID;
                    objDataRow["get_DOB"] = candidate.get_DOB.ToString("dd/MM/yyyy");
                    objDataRow["get_Gender"] = candidate.get_Gender;
                    objDataRow["get_Location"] = candidate.get_Location;
                    objDataRow["get_Percentage_10"] = candidate.get_Percentage_10;
                    objDataRow["get_Percentage_12"] = candidate.get_Percentage_12;
                    objDataRow["get_GapInEducation"] = candidate.get_GapInEducation;
                    objDataRow["get_GapInExperience"] = candidate.get_GapInExperience;
                    objDataTable.Rows.Add(objDataRow);
                }
            }

            gv_CandidateProfile.DataSource = objDataTable;
            gv_CandidateProfile.DataBind();
        }
        catch (Exception)
        {
        }
    }
    protected void gv_CandidateProfile_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_CandidateProfile.PageIndex = e.NewPageIndex;
        showgrid(Convert.ToInt32(ddlvacancyID.SelectedValue));
    }
    public void popvacancy()
    {
        ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
        List<int> lstVacancy = objCandidateManager.getVacancies();
        List<ICandidateProfile> lstcandidateprofile = objCandidateManager.display_candidate_toPC();
        ddlvacancyID.Items.Add("--select--");
        foreach (int element in lstVacancy)
        {
            foreach (ICandidateProfile candidate in lstcandidateprofile)
            {


                if (candidate.get_VacancyID == element)
                {
                    ddlvacancyID.Items.Add(element.ToString());
                    break;
                }
            }
        }
        
    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        gv_CandidateProfile.Visible = true;
        showgrid(Convert.ToInt32(ddlvacancyID.SelectedValue));
    }
    
}
