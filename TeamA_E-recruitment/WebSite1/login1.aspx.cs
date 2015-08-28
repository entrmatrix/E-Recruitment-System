using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLFactory;
using Types;

public partial class _login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!(IsPostBack))
            Session.Clear();
    }
    protected void sub_Click(object sender, EventArgs e)
    {
        validate(empidtb.Text,pswtb.Text);
    }
    public void validate(string eid, string password)
    {
        
        IEmployee employee = null;
        IEmployeeManager employeeManager = EmployeeManagerFactory.CreateEmployeeManager();
        int employeeID = Convert.ToInt32(eid);
        employee = employeeManager.SelectEmployeeDetails(employeeID, password);
        if (employee != null)
        {
            Session["empid"] = employee.EmployeeID;
            Session["empname"] = employee.Name;
            Session["domain"] = employee.BussinessDomain;
            Session["uid"] = employee.UnitHead;
            Session["ishr"] = employee.IsHR;
            Response.Redirect("HomePage.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Employee Not found";
        }
    }

}