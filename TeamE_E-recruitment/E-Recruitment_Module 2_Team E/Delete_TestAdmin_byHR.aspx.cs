

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Delete_TestAdmin_byHR.aspx.cs
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
using System.Windows.Forms;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            showgrid();
        }
    }

    public void showgrid()
    {
        ITestAdministratorManager objTestAdminManager = TestAdministratorManagerFactory.Create_TestAdministratorManager();
        List<ITestAdministrator> lstTestAdministrator = objTestAdminManager.DisplayTestAdministrators();
        if (lstTestAdministrator.Count == 0)
        {
            string script = "alert('Test Administrators are not available to delete.');";
            ClientScript.RegisterClientScriptBlock(this.GetType(),"Alert",script,true);
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

            foreach (ITestAdministrator testadmin in lstTestAdministrator)
            {
                DataRow objDataRow = objDataTable.NewRow();
                objDataRow["EmployeeID"] = testadmin.get_EmployeeID;
                objDataRow["EmployeeName"] = testadmin.get_EmployeeName;
                objDataRow["Designation"] = testadmin.get_EmployeeDesignation;
                objDataRow["Location"] = testadmin.get_EmployeeLocation;
                objDataRow["Experience"] = testadmin.get_EmployeeExperience;
                objDataTable.Rows.Add(objDataRow);
            }

            gv_testadmin.DataSource = objDataTable;
            gv_testadmin.DataBind();
        }
    }


    protected void gv_testadmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure to delete the Test Administrator?", "Confirm:", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            System.Web.UI.WebControls.Label EmployeeID = gv_testadmin.Rows[e.RowIndex].FindControl("EmployeeID") as System.Web.UI.WebControls.Label;
            string empid = EmployeeID.Text;
            ITestAdministratorManager objTestAdminManager = (ITestAdministratorManager)TestAdministratorManagerFactory.Create_TestAdministratorManager();
            int deleted = objTestAdminManager.DeleteTestAdministrator(Convert.ToInt32(EmployeeID.Text));
            if (deleted == 1)
            {
                MessageBox.Show("Test Administrator with ID: " + empid + ", deleted successfully.", "Successful:", MessageBoxButtons.OK);
            }
            else
            {
               MessageBox.Show("Test Administrator with ID: "+ empid +" is assigned a test, cannot be deleted.", "Failed:", MessageBoxButtons.OK);
            }

            gv_testadmin.EditIndex = -1;
            showgrid();
        }
        else
        {
           
        }
      
    }

    protected void gv_testadmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv_testadmin.PageIndex = e.NewPageIndex;
        gv_testadmin.EditIndex = -1;
        showgrid();
    }
}
