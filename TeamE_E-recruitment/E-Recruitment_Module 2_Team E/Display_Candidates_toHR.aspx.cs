

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Display_Candidates_ToHR.aspx.cs
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
using BLLFactory;
using System.Globalization;

public partial class Default2 : System.Web.UI.Page
{
    DateTimeFormatInfo dateinfo = new DateTimeFormatInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            popvacancy();
        }
    }

    void showgrid(int VacancyID)
    {
        ICandidate_TestManager objCandidateTestManager = Candidate_TestManagerFactory.CandidateTest_Manager();
        List<ICandidate_Test> lstCandidateTest = objCandidateTestManager.display_candidate_toHR();

        DataTable objDataTable = new DataTable();
        DataColumn objDataColumn1 = new DataColumn("get_VacancyID");
        objDataTable.Columns.Add(objDataColumn1);
        DataColumn objDataColumn2 = new DataColumn("get_CandidateProfileID");
        objDataTable.Columns.Add(objDataColumn2);
        DataColumn objDataColumn3 = new DataColumn("get_DOB");
        objDataTable.Columns.Add(objDataColumn3);
        DataColumn objDataColumn4 = new DataColumn("get_Gender");
        objDataTable.Columns.Add(objDataColumn4);
        DataColumn objDataColumn5 = new DataColumn("get_TestID");
        objDataTable.Columns.Add(objDataColumn5);
        DataColumn objDataColumn6 = new DataColumn("get_TestStatus");
        objDataTable.Columns.Add(objDataColumn6);
        DataColumn objDataColumn7 = new DataColumn("get_WrittenTestDate");
        objDataTable.Columns.Add(objDataColumn7);
        DataColumn objDataColumn8 = new DataColumn("get_TechnicalInterviewDate");
        objDataTable.Columns.Add(objDataColumn8);
        DataColumn objDataColumn9 = new DataColumn("get_HRInterviewDate");
        objDataTable.Columns.Add(objDataColumn9);

        foreach (ICandidate_Test candidate in lstCandidateTest)
        {
            if (candidate.get_VacancyID == VacancyID)
            {
                DataRow objDataRow = objDataTable.NewRow();
                objDataRow["get_VacancyID"] = candidate.get_VacancyID;
                objDataRow["get_CandidateProfileID"] = candidate.get_CandidateProfileID;
                objDataRow["get_DOB"] = candidate.get_DOB.ToString("dd/MM/yyyy");
                objDataRow["get_HRInterviewDate"] = candidate.get_HRInterviewDate.ToString("dd/MM/yyyy");
                objDataRow["get_Gender"] = candidate.get_Gender;
                objDataRow["get_TestID"] = candidate.get_TestID;
                objDataRow["get_TestStatus"] = candidate.get_TestStatus;
                objDataRow["get_WrittenTestDate"] = candidate.get_WrittenTestDate.ToString("dd/MM/yyyy");
                objDataRow["get_TechnicalInterviewDate"] = candidate.get_TechnicalInterviewDate.ToString("dd/MM/yyyy");
                objDataRow["get_HRInterviewDate"] = candidate.get_HRInterviewDate.ToString("dd/MM/yyyy");
                objDataTable.Rows.Add(objDataRow);
            }
        }

        gv_CandidateProfile.DataSource = objDataTable;
        gv_CandidateProfile.DataBind();
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
        ICandidate_TestManager candidate_test = Candidate_TestManagerFactory.CandidateTest_Manager();
        List<ICandidate_Test> lstcandidateprofile = candidate_test.display_candidate_toHR();
        ddlvacancyID.Items.Add("--select--");
        
        foreach (int element in lstVacancy)
        {
            foreach (ICandidate_Test candidate in lstcandidateprofile)
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