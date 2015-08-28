using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        string strDisAbleBackButton;
        strDisAbleBackButton = "<script language='javascript'>\n";
        strDisAbleBackButton += "window.history.forward(1);\n";
        strDisAbleBackButton += "\n</script>";
        ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", strDisAbleBackButton);
    }
}