using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_Recruitment.Types;
using E_Recruitment.BLLFactory;
using System.Data;
using System.Windows.Forms;

public partial class _Default : System.Web.UI.Page
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
        ITestAdministratorManager objTestAdministratorManager = TestAdministratorManagerFactory.Create_TestAdministratorManager();

        int intUserid = Convert.ToInt32(Session["ID"]);

        List<ITestAdministrator> lstTestAdministrator = objTestAdministratorManager.ApproveTestAdministrators(intUserid);

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

    protected void gv_testadmin_SelectedIndexChanged1(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure to approve the employee as Test Administrator?", "Confirm:", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            System.Web.UI.WebControls.Label EmployeeID = gv_testadmin.Rows[gv_testadmin.SelectedIndex].FindControl("EmployeeID") as System.Web.UI.WebControls.Label;
            string empid = EmployeeID.Text;
            ITestAdministratorManager objTestAdminManager = (ITestAdministratorManager)TestAdministratorManagerFactory.Create_TestAdministratorManager();
            if (objTestAdminManager.UpdateTestAdministrator(Convert.ToInt32(EmployeeID.Text)) == 1)
            {
                MessageBox.Show(" Employee with ID: " + empid + " has been added as TestAdministrator.", "Success:", MessageBoxButtons.OK);

            }
            gv_testadmin.EditIndex = -1;
            showgrid();
        }
        else
        {

        }
    }

    protected void gv_testadmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure to reject the employee as Test Administrator?", "Confirm:", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            System.Web.UI.WebControls.Label EmployeeID = gv_testadmin.Rows[e.RowIndex].FindControl("EmployeeID") as System.Web.UI.WebControls.Label;
            string empid = EmployeeID.Text;
            ITestAdministratorManager objTestAdminManager = (ITestAdministratorManager)TestAdministratorManagerFactory.Create_TestAdministratorManager();
            if (objTestAdminManager.DeleteTestAdministrator(Convert.ToInt32(EmployeeID.Text)) == 1)
            {
                MessageBox.Show(" Employee with ID: " + empid + " has been rejected as Test Administartor.", "Success:", MessageBoxButtons.OK);
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