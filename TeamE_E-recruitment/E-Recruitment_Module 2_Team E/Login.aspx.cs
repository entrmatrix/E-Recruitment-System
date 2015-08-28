

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Login.aspx.cs
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
using System.Windows.Forms;

public partial class _Default : System.Web.UI.Page
{

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
       
        string strDisAbleBackButton;
        strDisAbleBackButton = "<script language='javascript'>\n";
        strDisAbleBackButton += "window.history.forward(1);\n";
        strDisAbleBackButton += "\n</script>";
        ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", strDisAbleBackButton);

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = DateTime.Now.ToString();
        if (!IsPostBack)
        {
        
            Session.RemoveAll();

            if (Request.Cookies["UserID"] != null)
                user_id.Text = Request.Cookies["UserID"].Value;
            if (Request.Cookies["Password"] != null)
                password.Attributes.Add("value", Request.Cookies["Password"].Value);
            if (Request.Cookies["UserID"] != null && Request.Cookies["Password"] != null)
                cb_rememberme.Checked = true;
        }
        

    }
    private static string encrypt(string str)
    {
        string result = string.Empty;
        char[] temp = str.ToCharArray();
        foreach (var singleChar in temp)
        {
            var i = (int)singleChar;
            i = i + 3;
            result += (char)i;
        }
        return result;
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        if (cb_rememberme.Checked == true)
        {
            Response.Cookies["UserID"].Value = user_id.Text;
            Response.Cookies["Password"].Value = password.Text;
            Response.Cookies["UserID"].Expires = DateTime.Now.AddMonths(2);
            Response.Cookies["Password"].Expires = DateTime.Now.AddMonths(2);
        }
        else
        {
            Response.Cookies["UserID"].Expires = DateTime.Now.AddMonths(-1);
            Response.Cookies["Password"].Expires = DateTime.Now.AddMonths(-1);
        }
        IEmployeeManager objEmployeeManager = (IEmployeeManager)EmployeeManagerFactory.Create_EmployeeManager();
        List<IEmployee> lstEmployees = objEmployeeManager.ListOfEmployees();
        ITestAdministratorManager objTestAdminManager = (ITestAdministratorManager)TestAdministratorManagerFactory.Create_TestAdministratorManager();
        List<ITestAdministrator> lstTestAdmins = objTestAdminManager.getTestAdministrator();


        foreach (IEmployee employee in lstEmployees)
        {
            string pswd = encrypt(password.Text);
            try
            {
                if (employee.get_EmployeeID == Convert.ToInt32(user_id.Text) && (employee.get_Password == pswd))
                {

                    Session["ID"] = user_id.Text;
                    if (employee.get_IsHR == true)
                    {
                        Session["Name"] = "HR";
                        Response.Redirect("Home_HR.aspx");
                        break;
                    }
                    try
                    {
                        int t = Convert.ToInt32(employee.get_UnitHeadID);
                    }
                    catch
                    {
                        employee.get_UnitHeadID = 0;
                    }

                    if ((employee.get_UnitHeadID == 0) && (employee.get_IsHR == false))
                    {
                        foreach (ITestAdministrator test in lstTestAdmins)
                        {

                            if (test.get_IsTestAdmin == true && test.get_EmployeeID == employee.get_EmployeeID)
                            {
                                Session["Name"] = "TA_UH";
                                Response.Redirect("Home_TestAdmin_UnitHead.aspx");
                            }
                        }
                        Session["Name"] = "UH";
                        Response.Redirect("Home_UnitHead.aspx");
                    }
                }
            }
         catch (FormatException)
            {
             string script2 = "alert('User ID or Password is invalid');";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
        }

        IPlacementConsultantManager objPlacementConsultant = (IPlacementConsultantManager)PlacementConsultantManagerFactory.PlacementConsultant_Manager();
        List<IPlacementConsultant> lstplacementConsultants = objPlacementConsultant.ListPlacement();


        foreach (IPlacementConsultant placementconsultant in lstplacementConsultants)
        {
            string pwd = encrypt(password.Text);
            try
            {
                if (placementconsultant.get_PlacementConsultantID == Convert.ToInt32(user_id.Text) && (placementconsultant.get_Password == pwd))
                {
                    Session["Name"] = "PC";
                    Session["ID"] = user_id.Text;
                    Session["Name"] = "PC";
                    Response.Redirect("Home_PlacementConsultant.aspx");
                }
            }
            catch (FormatException)
            {
                string script2 = "alert('User ID or Password is invalid');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
            
        }


        foreach (ITestAdministrator test_admin in lstTestAdmins)
        {
            try
            {
                if ((test_admin.get_EmployeeID == Convert.ToInt32(user_id.Text) && (test_admin.get_IsTestAdmin = true)))
                {

                    foreach (IEmployee emp in lstEmployees)
                    {
                        string pwd = encrypt(password.Text);
                        if ((emp.get_EmployeeID == test_admin.get_EmployeeID) && (emp.get_Password == pwd))
                        {
                            Session["Name"] = "TA";
                            Session["ID"] = user_id.Text;
                            Response.Redirect("Home_TestAdministrator.aspx");
                        }
                    }

                }
            }
            catch (FormatException)
            {
                string script2 = "alert('User ID or Password is invalid');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script2, true);
            }
        }
        string script1 = "alert('User ID or Password is Invalid');";
        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script1, true);
        Response.Cookies["Password"].Expires = DateTime.Now.AddMonths(-1);

    }
}

        
        
    
 

