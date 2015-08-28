


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: AddTest_byHR.aspx.cs
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
using System.Globalization;

public partial class _Default : System.Web.UI.Page
{
   
    DateTimeFormatInfo date = new DateTimeFormatInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label3.Text = "";
            display();
        }
    }

    public void display()
    {
        lbRequiredbyDate.Visible = true;
        lbReqbyDate.Visible = true;
        
        ITestAdministratorManager objTestAdminManager = TestAdministratorManagerFactory.Create_TestAdministratorManager();
        List<ITestAdministrator> LstTestAdmin = new List<ITestAdministrator>();
        LstTestAdmin = objTestAdminManager.getTestAdministrator();

        ddltestadminID.Items.Clear();
        ddltestadminID.Items.Add("--select--");
        for(int i = 0; i < LstTestAdmin.Count; i++)
        {
            if (LstTestAdmin.ElementAt(i).get_IsTestAdmin == true)
            {
                ddltestadminID.Items.Add(Convert.ToString(LstTestAdmin.ElementAt(i).get_EmployeeID));
            }
        }



      
        bool blflag = false;
        IVacancyManager objVacancyManager = VacancyManagerFactory.Create_VacancyManager();
        List<IVacancy> lstVacancy = new List<IVacancy>();
        ITestManager objTestManager = TestManagerFactory.CreateTestManager();
        List<ITest> lstTest = new List<ITest>();
        lstTest = objTestManager.GetTest();
        lstVacancy = objVacancyManager.GetVacancy();
        ddlvacancyID.Items.Clear();
        ddlvacancyID.Items.Add("--select--");
        foreach (IVacancy element1 in lstVacancy)
        {
            if (element1.get_Status == 2)
            {
                blflag = false;
                foreach (ITest element in lstTest)
                {
                    if (element1.get_VacancyID == element.get_VacancyID)
                    {
                        blflag = true;
                        break;

                    }

                }
                if (!blflag)
                {
                    ddlvacancyID.Items.Add(Convert.ToString(element1.get_VacancyID));
                }
            }


        }
    }


    protected void Submit_Click(object sender, EventArgs e)
    {
      
        date.ShortDatePattern = "dd/MM/yyyy";
        ITestManager objTestManager = (ITestManager)TestManagerFactory.CreateTestManager();
        int intres=0;
        int intTestAdminID = Convert.ToInt32(ddltestadminID.SelectedValue);
        int intVacancyID = Convert.ToInt32(ddlvacancyID.SelectedValue);
        DateTime date1 = Convert.ToDateTime(tbwritten.Text, date);
        DateTime date2 = Convert.ToDateTime(tbtechnical.Text, date);
        DateTime date3 = Convert.ToDateTime(tbHR.Text, date);
        int inttestAdminID = 0;
        List<ITest> lsttest = new List<ITest>();
        ITestManager objtestmanager = TestManagerFactory.CreateTestManager();
        lsttest = objtestmanager.GetTest();
        foreach (ITest element in lsttest)
        {
            if (element.get_VacancyID == intVacancyID)
            {
                inttestAdminID = element.get_TestAdministratorID;
            }
        }
        intres = objTestManager.Validate(intTestAdminID, intVacancyID, date1, date2, date3);
        switch (intres)
        {
            case 0: int newTestID = 0;
                    List<ITest> lsttest1 = new List<ITest>();
                    ITestManager objtestManager = TestManagerFactory.CreateTestManager();
                    lsttest1 = objtestManager.GetTest();
                    foreach (ITest element in lsttest1)
                    {
                       newTestID = Convert.ToInt32(element.get_TestID);
                    }
                    string script2 = "alert('Test with Test ID:"+newTestID+" is scheduled successfully.')";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 1: script2 = "alert('Test Administrator with ID:" + intTestAdminID + " is already assigned to VacancyID '" + intVacancyID + ".');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 2: script2 = "alert('The Vacancy ID:'" + intVacancyID + "' is assigned to Test Administrator with ID:'" + inttestAdminID + "'.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 3: script2 = "alert('Please select future date for Written Test.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 4: script2 = "alert('Please select future date for Technical Interview.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 5: script2 = "alert('Please select future date for HR Interview.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 6: script2 = "alert('Written Test and Technical Interview cannot be on same date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 7: script2 = "alert('Technical Interview and HR Interview cannot be on same date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 8: script2 = "alert('Written Test and HR Interview cannot be on same date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 9: script2 = "alert('All Test dates cannot be same.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 10:script2 = "alert('Please select written test date before required by date.');";
                     ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                     break;
            case 11:script2 = "alert('Please select Technical test date before required by date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 12:script2 = "alert('Please select HR Interview date before required by date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 13:script2 = "alert('Written Test cannot be after Technical Interview date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 14:script2 = "alert('Technical Interview cannot be after HR Interview date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 15:script2 = "alert('Written test  cannot be after HR Interview date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 16:script2 = "alert('Technical Interview  cannot be  within  2 days after written test date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;
            case 17:script2 = "alert('HR Interview  cannot be  within  2 days after Technical Interview date.');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
                    break;


        }
        display();
    }

   
   
    protected void ddlvacancyID_SelectedIndexChanged(object sender, EventArgs e)
    {
        IVacancyManager objvacmanager = VacancyManagerFactory.Create_VacancyManager();
        List<IVacancy> lstvacancy= objvacmanager.GetVacancy();
        try
        {
            foreach (IVacancy element in lstvacancy)
            {
                if (element.get_VacancyID == Convert.ToInt32(ddlvacancyID.SelectedValue))
                {
                    lbRequiredbyDate.Visible = true;
                    lbReqbyDate.Text = element.get_RequiredByDate.ToString("dd/MM/yyyy");
                    lbReqbyDate.Visible = true;
                    lbWrittenTestDate.Visible = true;
                    lbTechnicalInterviewDate.Visible = true;
                    lbHRInterviewDate.Visible = true;
                    tbwritten.Visible = true;
                    tbtechnical.Visible = true;
                    tbHR.Visible = true;

                    break;

                }
            }
        }
        catch (Exception)
        {
            RequiredFieldValidator2.Visible=true;
        }
    }
    protected void Cal_SelectionChanged(object sender, EventArgs e)
    {
        if (  Label3.Text  == "1")
        {
            tbwritten.Text = Cal.SelectedDate.ToString("dd/MM/yyyy");
            Cal.Visible = false;
            Label3.Text = "";
            Cal.SelectedDate = DateTime.MinValue;
        }
        else if (Label3.Text == "2")
        {
            tbtechnical.Text = Cal.SelectedDate.ToString("dd/MM/yyyy");
            Cal.Visible = false;
            Label3.Text = "";
            Cal.SelectedDate = DateTime.MinValue;
        }
        else if (Label3.Text == "3")
        {
            tbHR.Text = Cal.SelectedDate.ToString("dd/MM/yyyy");
            Cal.Visible = false;
            Label3.Text = "";
            Cal.SelectedDate = DateTime.MinValue;
        }

    }
    protected void Calwritten_Click(object sender, ImageClickEventArgs e)
    {
        Cal.Visible = true;
        Label3.Text = "1";
    }
    protected void CalTechnical_Click(object sender, ImageClickEventArgs e)
    {
        Cal.Visible = true;
        Label3.Text = "2";
    }
    protected void CalHR_Click(object sender, ImageClickEventArgs e)
    {
        Cal.Visible = true;
        Label3.Text = "3";
    }

    protected void ddltestadminID_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}


