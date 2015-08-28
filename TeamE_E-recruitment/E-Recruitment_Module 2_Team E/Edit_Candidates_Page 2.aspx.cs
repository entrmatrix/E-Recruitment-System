

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Edit_Candidate_PC.aspx.cs
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
using E_Recruitment.Types;
using E_Recruitment.BOFactory;
using E_Recruitment.BLLFactory;
using System.Windows.Forms;
using System.Globalization;

public partial class _Default : System.Web.UI.Page
{
    DateTimeFormatInfo dateinfo = new DateTimeFormatInfo();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            vacancy.Text = Convert.ToString(Session["VacancyID"]);
            dob.Visible = true;
            gapsexp_months.Visible = false;
            gapsedu_months.Visible = false;


            Candidate.Text = Convert.ToString(Session["CandidateProfileID"]);

            dob.Text = Convert.ToDateTime(Session["DOB"]).ToString("MM/dd/yyyy");
            location.Text = Convert.ToString(Session["Location"]);
            gender.SelectedItem.Text = Convert.ToString(Session["Gender"]);
            tenth.Text = Convert.ToString(Session["Percentage_10"]);
            twelfth.Text = Convert.ToString(Session["Percentage_12"]);
        }


    }


    protected void gaps_SelectedIndexChanged(object sender, EventArgs e)
    {
        if ((gapsedu.SelectedItem.ToString()) == "Yes")
        {
            lb_1.Visible = true;
            gapsedu_months.Visible = true;
        }
        else
        {
            lb_1.Visible = false;
            gapsedu_months.Visible = false;
        }
    }



    protected void gapsexp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if ((gapsexp.SelectedItem.ToString()) == "Yes")
        {
            lb_2.Visible = true;
            gapsexp_months.Visible = true;
        }
        else
        {
            lb_2.Visible = false;
            gapsexp_months.Visible = false;
        }
    }




    protected void submit_Click1(object sender, EventArgs e)
    {
        //dateinfo.ShortDatePattern = "DD/MM/YYYY";
        
        ICandidateProfile objCandidateProfile = CandidateProfileFactory.create_Candidates();
        objCandidateProfile.get_CandidateProfileID = (Int32)Session["CandidateProfileID"];
        try
        {
            objCandidateProfile.get_DOB = Convert.ToDateTime(dob.Text);
        }
        catch (Exception)
        {
            string script = "alert('please enter date of birth in DD/MM/YYYY');";
            ClientScript.RegisterClientScriptBlock(this.GetType(),"Alert",script);
        }


        objCandidateProfile.get_Gender = gender.Text;
        objCandidateProfile.get_Location = location.Text;
        objCandidateProfile.get_Percentage_10 = Convert.ToSingle(tenth.Text);
        objCandidateProfile.get_Percentage_12 = Convert.ToSingle(twelfth.Text);

        if (gapsedu.SelectedItem.Text == "No")
            objCandidateProfile.get_GapInEducation = 0;
        else objCandidateProfile.get_GapInEducation = Convert.ToInt32(gapsedu_months.Text);

        if (gapsexp.SelectedItem.Text == "No")
            objCandidateProfile.get_GapInExperience = 0;
        else objCandidateProfile.get_GapInExperience = Convert.ToInt32(gapsexp_months.Text);

        objCandidateProfile.get_VacancyID = Convert.ToInt32(Session["VacancyID"]);
        objCandidateProfile.get_TestID = 0;
        objCandidateProfile.get_TestStatus = 0;
        objCandidateProfile.get_MedicalTestStatus = 0;
        objCandidateProfile.get_BGCTestID = 0;
        objCandidateProfile.get_BGCTestStatus = false;


        ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
        if (objCandidateManager.candidate_update(objCandidateProfile) == 1)
        {
            DialogResult result = MessageBox.Show(" Do you want to edit more candidates? ", "Success:", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Response.Redirect("Edit_Candidates_byPC.aspx");
            }
            else
            {
                Response.Redirect("Home_PlacementConsultant.aspx");
            }
        }

    }
}
       


    

