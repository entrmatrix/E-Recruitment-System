


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Add_Candidates_byPC.aspx.cs
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
using E_Recruitment.BLLFactory;
using E_Recruitment.BOFactory;
using System.Windows.Forms;
using System.Globalization;

public partial class Default2 : System.Web.UI.Page
{
    DateTimeFormatInfo date = new DateTimeFormatInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
       
     
        if (!IsPostBack)
        {
            showlist();
            dob.Visible = true;
            gapsexp_months.Visible = false;
            gapsedu_months.Visible = false;
            Complete.Visible = false;
            Cancel.Visible = false;
            
        }
      
    }

    public void showcomplete(int vacancyID)
    {
        int count = 0;
        ICandidateManager objcandidatemanager = CandidateManagerFactory.Candidate_Manager();
        List<ICandidateProfile> candidate = objcandidatemanager.display_candidate_toPC();
        foreach (ICandidateProfile element in candidate)
        {
            if (element.get_VacancyID == vacancyID)
            {
                count++;
            }
        }
        tbtotal.Text = count.ToString();
        if ((objcandidatemanager.filledstatus_20percent(vacancyID) == true) && (objcandidatemanager.filledstatus_bydate(vacancyID) == false))
        {
            Panel2.Visible = true;
            Panel1.Visible = true;
            Complete.Visible = true;
            Cancel.Visible = false;

        }

        else if ((objcandidatemanager.filledstatus_20percent(vacancyID) == false) && (objcandidatemanager.filledstatus_bydate(vacancyID) == true))
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
            Complete.Visible = false;
            Cancel.Visible = true;
        }

        else if ((objcandidatemanager.filledstatus_20percent(vacancyID) == true) && (objcandidatemanager.filledstatus_bydate(vacancyID) == true))
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
            Complete.Visible = true;
            Cancel.Visible = true;
        }
        else if ((objcandidatemanager.filledstatus_20percent(vacancyID) == false) && (objcandidatemanager.filledstatus_bydate(vacancyID) == false))
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
           
            
        }
           
    }

    public void showlist()
    {
        ddl_vacancy.Items.Clear();
        IVacancyManager objVacancyManager = VacancyManagerFactory.Create_VacancyManager();
        List<IVacancy> list_vacancies = objVacancyManager.GetVacancy();
        ICandidateManager candidate_manager = CandidateManagerFactory.Candidate_Manager();
        ddl_vacancy.Items.Add("--select--");
        foreach (IVacancy vacancy in list_vacancies)
        {
            if ((vacancy.get_Status != 2) && (candidate_manager.filledstatus_50percent(vacancy.get_VacancyID) == false) && (candidate_manager.filledstatus_bydate_TestID(vacancy.get_VacancyID) == true)) 
            {
                if ((vacancy.get_Status == 0) && (candidate_manager.filledstatus_bydate(vacancy.get_VacancyID) == true))
                {
                    
                }
                else
                {
                    ListItem dropdownlist = new ListItem(Convert.ToString(vacancy.get_VacancyID), Convert.ToString(vacancy.get_VacancyID), true);

                    ddl_vacancy.Items.Add(dropdownlist);
                }
            }
            if ((candidate_manager.filledstatus_50percent(vacancy.get_VacancyID) == true) && (candidate_manager.filledstatus_bydate(vacancy.get_VacancyID) == true))
            {
                objVacancyManager.updateStatus(vacancy.get_VacancyID, 2); 
            }
        }
        ddl_vacancy.SelectedIndex = 0;
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
      //  date.ShortDatePattern="dd-MM-yyyy";
        try
        {
            
            Session["VacancyID"] = ddl_vacancy.SelectedItem.Text;
            ICandidateProfile candidate = CandidateProfileFactory.create_Candidates();

           
                candidate.get_DOB = Convert.ToDateTime(dob.Text);
            
            //catch (Exception)
            //{

            //    DialogResult result = MessageBox.Show(" Date of birth should be in the MM/DD/YYYY format.  ", "Failure:", MessageBoxButtons.OK);
            //}

            candidate.get_Gender = gender.Text;
            candidate.get_Location = location.Text;
            candidate.get_Percentage_10 = Convert.ToSingle(tenth.Text);
            candidate.get_Percentage_12 = Convert.ToSingle(twelfth.Text);

            if (gapsedu.SelectedItem.Text == "No")
                candidate.get_GapInEducation = 0;
            else candidate.get_GapInEducation = Convert.ToInt32(gapsedu_months.SelectedItem.Text);

            if (gapsexp.SelectedItem.Text == "No")
                candidate.get_GapInExperience = 0;
            else candidate.get_GapInExperience = Convert.ToInt32(gapsexp_months.SelectedItem.Text);

            int intvacancyid = Convert.ToInt32(Convert.ToString(Session["VacancyID"]));
            candidate.get_VacancyID = intvacancyid;
            candidate.get_TestID = 0;
            candidate.get_TestStatus = 0;
            candidate.get_MedicalTestStatus = 0;
            candidate.get_BGCTestID = 0;
            candidate.get_BGCTestStatus = false;

            ICandidateManager objCandidateManager = CandidateManagerFactory.Candidate_Manager();
            int inti = objCandidateManager.AddCandidateProfile(candidate);
            List<ICandidateProfile> lstCandidateProfile = new List<ICandidateProfile>();
            lstCandidateProfile = objCandidateManager.display_candidate_toPC();
            int CandidateID = 0;
            foreach (ICandidateProfile objCandidateProfile in lstCandidateProfile)
            {
                CandidateID = objCandidateProfile.get_CandidateProfileID;
            }
            string Requirebydate = "";
            IVacancyManager objVacancyManager = VacancyManagerFactory.Create_VacancyManager();
            List<IVacancy> lstVacancy = new List<IVacancy>();
            foreach (IVacancy element in lstVacancy)
            {
                if (element.get_VacancyID == intvacancyid)
                {
                    Requirebydate = Convert.ToString(element.get_RequiredByDate);
                    break;
                }
            }
            if (inti == 1)
            {
                DialogResult result = MessageBox.Show(" Candidate with ID:" + CandidateID + " is Successfully added", "Success:", MessageBoxButtons.OK);
                Response.Redirect("Add_Candidates_byPC.aspx");

            }
            else if (inti == 2)
            {
                DialogResult result = MessageBox.Show(" All candidates for Vacancy ID:" + intvacancyid + " are filled", "Failure:", MessageBoxButtons.OK);
                Response.Redirect("Add_Candidates_byPC.aspx");
            }
            else if (inti == 3)
            {
                DialogResult result = MessageBox.Show(" Date has been expired for this vacancy ", "Failure:", MessageBoxButtons.OK);
                Response.Redirect("Add_Candidates_byPC.aspx");
            }
        }
        catch (Exception)
        {
        }
           
    }

    protected void Complete_Click(object sender, EventArgs e)
    {
        IVacancyManager objVacancyManager = VacancyManagerFactory.Create_VacancyManager();
        int intupdate = objVacancyManager.updateStatus(Convert.ToInt32(Convert.ToString(ddl_vacancy.SelectedItem.Text)), 2);
        if (intupdate == 1 )
        {
            DialogResult result = MessageBox.Show("Vacancy ID:" + ddl_vacancy.SelectedItem.Text + " is updated successfully", "Success:", MessageBoxButtons.OK);
           
            showlist();
        }
      

    }


    

 
    protected void Cancel_Click(object sender, EventArgs e)
    {
        try
        {
            IVacancyManager objVacancyManager = VacancyManagerFactory.Create_VacancyManager();
            int update = objVacancyManager.updateStatus(Convert.ToInt32(Convert.ToString(ddl_vacancy.SelectedItem.Text)), 0);
            if (update == 1)
            {
                DialogResult result = MessageBox.Show("Vacancy ID:" + ddl_vacancy.SelectedItem.Text + " is canceled successfully", "Success:", MessageBoxButtons.OK);
                showlist();
            }
        }
        catch (Exception)
        {
        }
        
    }
    protected void Submit_Click(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ddl_vacancy.SelectedValue != "--select--")
        showcomplete(Convert.ToInt32(ddl_vacancy.SelectedItem.Text));
    }
    protected void ddl_vacancy_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel1.Visible = false;
    }
    protected void tbtotal_TextChanged(object sender, EventArgs e)
    {

    }
}
