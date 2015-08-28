using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using BLLFactory;

public partial class _Default : System.Web.UI.Page
{
    public IEmployee employee=null;
    protected void Page_Load(object sender, EventArgs e)
    {

        empname.Text = (string)Session["empname"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
   
        request(posttb.Text);
        
   } 
    public void request(string p)
    {

        int eid = (int)Session["empid"];
        int pnum = Convert.ToInt32(p);

        IVacancyRequestManager vacancyRequestManager = VacancyRequestManagerFactory.CreateVacancyRequestManager();
        
        int vacancyRequestID = vacancyRequestManager.InsertVacancyRequest(eid, pnum);
        //Response.Write(@"<script language='javascript'>alert('vacancy request id is '"+vacancyRequestID.ToString()+") </script>" );
        outll.Visible = true;
        outll.Text = "vacancy request id generated is :" + vacancyRequestID;
                //Console.WriteLine("+ k.Key);
                //for (int j = 0; j < i; j++)
                //{
                //    //Ivacancy_UI vui = new vacancy_UI();
                //    ////vui.vacancyidreq(k.Key,k.Value);
                //    //vui.addvacancydetails(k.Key, k.Value);
                //}
        System.Threading.Thread.Sleep(3000);
        Session["positions"] = pnum;
        Session["vacancyRequestID"] = vacancyRequestID;
        Response.Redirect("addvacancy.aspx");
            
        
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}
