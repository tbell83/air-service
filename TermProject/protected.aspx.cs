using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject
{
    public partial class _protected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null){
                unauthed.Visible=true;
                Response.AddHeader("REFRESH","50;URL=login.aspx");
                Response.Redirect("login.aspx");
            }else{
                authed.Visible=true;
                lblUsername.Text = "WELCOME BACK, " + Session["user"].ToString() + "!";
            }
        }
    }
}