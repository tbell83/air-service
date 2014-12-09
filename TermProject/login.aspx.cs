using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using ECommerceLibrary;
using System.Data;

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

                DataSet flights = new DataSet();
                flights.Tables.Add(new DataTable());
                flights.Tables[0].Columns.Add("flightID", typeof(int));
                flights.Tables[0].Columns.Add("carrierName", typeof(string));
                flights.Tables[0].Columns.Add("OriginCity", typeof(string));
                flights.Tables[0].Columns.Add("DestinationCity", typeof(string));
                flights.Tables[0].Columns.Add("departureTime", typeof(string));
                flights.Tables[0].Columns.Add("date", typeof(string));
                flights.Tables[0].Columns.Add("economyPrice", typeof(double));
                flights.Tables[0].Columns.Add("economySeats", typeof(int));
                flights.Tables[0].Columns.Add("firstClassPrice", typeof(double));
                flights.Tables[0].Columns.Add("firstClassSeats", typeof(int));
                flights.Tables[0].Columns.Add("seatsAvailable", typeof(int));
                DataSet events = new DataSet();
                events.Tables.Add(new DataTable());
                events.Tables[0].Columns.Add("EventID", typeof(int));
                events.Tables[0].Columns.Add("AgencyID", typeof(int));
                events.Tables[0].Columns.Add("CustomerID", typeof(int));
                events.Tables[0].Columns.Add("EventDate", typeof(string));
                events.Tables[0].Columns.Add("EventTime", typeof(string));
                events.Tables[0].Columns.Add("EventName", typeof(string));
                events.Tables[0].Columns.Add("Activity", typeof(string));
                events.Tables[0].Columns.Add("City", typeof(string));
                events.Tables[0].Columns.Add("State", typeof(string));
                events.Tables[0].Columns.Add("Capacity", typeof(int));
                events.Tables[0].Columns.Add("TicketPrice", typeof(int));
                events.Tables[0].Columns.Add("Venue", typeof(string));

                Serialize s = new Serialize();
                VacationPackage cart;
                string user = Session["user"].ToString();
                if (s.CheckCartExists(user))
                {
                    if (s.ReadCartFromDB(user) != null) //if user has cart in db
                    {
                        cart = (VacationPackage)s.ReadCartFromDB(user); //retrieve cart
                    }
                    else //cart exists but is null for some reason
                    {
                        cart = new VacationPackage();
                    }
                }
                else //if user has no recorded cart 
                {
                    s.CreateNewCart(user);
                    cart = new VacationPackage(); //get a new cart set up for them
                }

                cart.FlightReservations.Add(flights);
                cart.EventReservations.Add(events);

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