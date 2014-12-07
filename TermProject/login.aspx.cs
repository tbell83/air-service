using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using ECommerceLibrary;

namespace TermProject{
    public partial class login : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            if(!IsPostBack){
                ReadCookie();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e){

            if(password.validateUser(txtUsername.Text, txtPassword.Text)){
                Session["user"] = txtUsername.Text;
                if(chkRemember.Checked){
                    WriteCookie();
                }else{
                    DeleteCookie();
                }
                

                Serialize s = new Serialize();
                VacationPackage cart; 
                string user = (string)Session["user"];
                //if (s.ReadCartFromDB(user) != null) //if user has cart in db
                //{
                //    cart = (VacationPackage)s.ReadCartFromDB(user); //retrieve cart
                //}
                //else //if user has no recorded cart 
                {
                    cart = new VacationPackage(); //get a new cart set up for them
                }
                Session["cart"] = cart; 

                Response.Redirect("dashboard.aspx");
            }
        }

        protected void WriteCookie(){
            HttpCookie cookie = new HttpCookie("termproject_cookie");
            cookie.Values["email"] = txtUsername.Text;
            Response.Cookies.Add(cookie);
        }

        protected bool ReadCookie(){
            if(Request.Cookies["termproject_cookie"] != null){
                HttpCookie cookie = Request.Cookies["termproject_cookie"];
                txtUsername.Text = cookie.Values["email"].ToString();
                chkRemember.Checked = true;
                return true;
            }else{
                txtUsername.Text="";
                chkRemember.Checked = false;
                return false;
            }
        }

        protected void DeleteCookie(){
            if(Request.Cookies["termproject_cookie"] != null){
                Response.Cookies["termproject_cookie"].Expires = DateTime.Now.AddDays(-1);
            }
            txtUsername.Text="";
        }

        protected void btnClearCookies_Click(object sender, EventArgs e){
            DeleteCookie();
        }

        protected void btnRegister_Click(Object sender, EventArgs e){
            Response.Redirect("registration.aspx"); 
        }
    }
}