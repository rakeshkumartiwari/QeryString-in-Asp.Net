using System;

namespace QueryStringInAsp.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx?UserName=" + Server.UrlEncode(txtName.Text) + "&UserEmail=" + Server.UrlEncode(txtEmail.Text));
        }
    }
}