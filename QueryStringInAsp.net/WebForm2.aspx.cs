using System;

namespace QueryStringInAsp.net
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = Request.QueryString["UserName"];
            lblEmail.Text = Request.QueryString["UserEmail"];
        }
    }
}