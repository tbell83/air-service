using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net;
using ECommerceLibrary;

namespace TermProject{
    public partial class registration : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){

        }

        protected void btnRegister_Click(object sender, EventArgs e){
            if(chkRemember.Checked){
                WriteCookie();
            }else{
                DeleteCookie();
            }

            string password;
            if(txtPassword.Text == txtPasswordConfirm.Text){
                password = txtPassword.Text;
            }else{
                lblPassword.Text="Password:  Passwords don't match!";
                return;
            }
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string hashedPassword = TermProject.password.hashPassword(SHA512.Create(), password);

            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "createUser";
            objCommand.Parameters.AddWithValue("@FirstName", firstName);
            objCommand.Parameters.AddWithValue("@LastName", lastName);
            objCommand.Parameters.AddWithValue("@email", email);
            objCommand.Parameters.AddWithValue("@PasswordHash", hashedPassword);
            objCommand.Parameters.AddWithValue("@ShippingAddress", address);
            objDB.DoUpdateUsingCmdObj(objCommand);

            Response.Redirect("login.aspx");
        }

        protected void WriteCookie(){
            HttpCookie cookie = new HttpCookie("termproject_cookie");
            cookie.Values["email"] = txtEmail.Text;
            Response.Cookies.Add(cookie);
        }

        protected void DeleteCookie(){
            if(Request.Cookies["termproject_cookie"] != null){
                Response.Cookies["termproject_cookie"].Expires = DateTime.Now.AddDays(-1);
            }
        }
    }
}