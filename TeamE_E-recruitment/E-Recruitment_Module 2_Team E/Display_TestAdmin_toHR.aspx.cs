

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Display_TestAdmin_toHR.aspx.cs
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
using E_Recruitment.BLLFactory;
using E_Recruitment.Types;
using E_Recruitment.BOFactory;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            showgrid();
        }
    }

    void showgrid()
    {
        try
        {
            ITestAdministratorManager objTestAdministrator = TestAdministratorManagerFactory.Create_TestAdministratorManager();
            List<ITestAdministrator> lstTestAdministrator = objTestAdministrator.DisplayTestAdministrators();
            if (lstTestAdministrator.Count == 0)
            {
                string script = "alert('Test Administrators are not available.');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
            }
            else
            {
                DataTable objDataTable = new DataTable();
                DataColumn objDataColumn1 = new DataColumn("EmployeeID");
                objDataTable.Columns.Add(objDataColumn1);
                DataColumn objDataColumn2 = new DataColumn("EmployeeName");
                objDataTable.Columns.Add(objDataColumn2);
                DataColumn objDataColumn3 = new DataColumn("Designation");
                objDataTable.Columns.Add(objDataColumn3);
                DataColumn objDataColumn4 = new DataColumn("Location");
                objDataTable.Columns.Add(objDataColumn4);
                DataColumn objDataColumn5 = new DataColumn("Experience");
                objDataTable.Columns.Add(objDataColumn5);

                foreach (ITestAdministrator test_admin in lstTestAdministrator)
                {
                    DataRow objDataRow = objDataTable.NewRow();
                    objDataRow["EmployeeID"] = test_admin.get_EmployeeID;
                    objDataRow["EmployeeName"] = test_admin.get_EmployeeName;
                    objDataRow["Designation"] = test_admin.get_EmployeeDesignation;
                    objDataRow["Location"] = test_admin.get_EmployeeLocation;
                    objDataRow["Experience"] = test_admin.get_EmployeeExperience;
                    objDataTable.Rows.Add(objDataRow);
                }

                gv_testadmin.DataSource = objDataTable;
                gv_testadmin.DataBind();
            }
        }
        catch (Exception)
        {
        }
    }



    protected void gv_testadmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_testadmin.PageIndex = e.NewPageIndex;
        showgrid();
    }
}
