


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Add_TestAdmin_byHR.aspx.cs
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
using System.Data.SqlClient;
using E_Recruitment.Types;
using E_Recruitment.DALFactory;
using E_Recruitment.BLLFactory;
using System.Windows.Forms;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            populate_ddl();
    }
    
    public void populate_ddl()
    {
        IEmployeeDB objEmployeeDB = EmployeeDBFactory.Create_EmployeeDB();
        List<IEmployee> lstEmployee = objEmployeeDB.getEmployees();
        ddlemployees.Items.Clear();
        int inti = 0;
        ddlemployees.Items.Add("--select--");
        while(inti < lstEmployee.Count)
        {
            int empid = lstEmployee.ElementAt(inti).get_EmployeeID;
            ListItem ddl_list = new ListItem(Convert.ToString(empid), Convert.ToString(empid), true);

            ddlemployees.Items.Add(ddl_list);
            inti++;
        }
    }


    protected void Submit_Click(object sender, EventArgs e)
    {
        string strempid = ddlemployees.SelectedItem.Text;
        IEmployeeManager objEmployeemanager = EmployeeManagerFactory.Create_EmployeeManager();
        List<IEmployee> lstEmployees = objEmployeemanager.ListOfEmployees();
       
            foreach (IEmployee emp in lstEmployees)
            {
                if (emp.get_EmployeeID == Convert.ToInt32(strempid))
                {

                    if ((objEmployeemanager.addtestadmin(Convert.ToInt32(strempid))) == 1)
                    {
                        if (emp.get_Designation == "unithead")
                        {
                            DialogResult result = MessageBox.Show("Employee with ID: " + emp.get_EmployeeID + " is added as Test Administrator succcessfully.", "Success:", MessageBoxButtons.OK);

                            break;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Employee with ID: " + emp.get_EmployeeID + " is selected as Test Administrator.\nYet to be approved by Unit Head.", "Success:", MessageBoxButtons.OK);
                            
                            break;
                        }

                    }
                }

            }

            populate_ddl();
     }
}
