using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Types;
using BLLFactory;
using System.Web.UI.WebControls;

public partial class _vacancy : System.Web.UI.Page
{
    static int count = 1;
    static int ii = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(count > (int)Session["positions"])
            Response.Redirect("login.aspx");
        if(ii==1)
        {
        ListItem[] items1 = new ListItem[(int)Session["positions"]];
        //ListItem[] items1 = new ListItem[3];
        for (int i = 0; i < (int)Session["positions"]; i++)
        {
            int j = i + 1;
            string val = j.ToString();
            string s = "vac" + (val);
            items1[i] = new ListItem(s, (val));
        }
        DropDownList1.Items.AddRange(items1);
        ii++;
        }
        domlable.Visible = true;
        domlable.Text = (string)Session["domain"];
        Label1.Text="previously generated vacancy id is:";
        //postxt.Text = "9";
        //RbDtb.Text = "";
        //skilltb.Text = "";
        //extb.Text = "";
        //loctb.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        insert(postxt.Text,DatePicker1.CalendarDateString,extb.Text,loctb.Text);


        if (count > (int)Session["positions"])
        {

            Response.Redirect("HomePage.aspx");
        }
    }
    public void insert(string vac,string rbd,string expp,string loc)
    {
        IVacancyManager v = VacancyManagerFactory.CreateVacancyManager();
        
            int posit = Convert.ToInt32(vac);
            DateTime req = Convert.ToDateTime(rbd);
            string skills = skilltb.Text; 
            string domain = domlable.Text;
            int exp = Convert.ToInt32(expp);
            string location = loctb.Text;
            int uid = (int)Session["uid"];
            int aprved = 1;
            if (uid == 0)
                aprved = 3;
            int vacancyRequestID = (int)Session["vacancyRequestID"];
            int vacancyID = v.InsertVacancy(posit, req, skills, domain, exp, location, aprved, vacancyRequestID);
            count++;
            DropDownList1.SelectedItem.Enabled = false;
            Label1.Visible = true;
            Label1.Text = "generated vacancy id :";
            Label2.Visible = true;
            Label2.Text = vacancyID.ToString();
            System.Threading.Thread.Sleep(1000);
        

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        postxt.Text="";
           
        extb.Text="";
        loctb.Text = "";
    }
}