using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject
{
    public partial class dashboard : System.Web.UI.Page
    {
        HotelService.HotelService hotelProxy = new HotelService.HotelService();
        AirService.AirService airProxy = new AirService.AirService();
        CarService.CarWebService carProxy = new CarService.CarWebService();
        //add event proxy 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                unauthed.Visible = true;
                Response.AddHeader("REFRESH", "50;URL=login.aspx");
                Response.Redirect("login.aspx");
            }
            else
            {
                authed.Visible = true;
                lblUsername.Text = "WELCOME BACK, " + Session["user"].ToString() + "!";
            }
        }

        protected void btnSearchFlights_Click(object sender, EventArgs e)
        {
            //redirect to flight page
        }

        protected void btnSearchHotels_Click(object sender, EventArgs e)
        {
            Response.Redirect("hotel_rental.aspx");
        }

        protected void btnSearchCars_Click(object sender, EventArgs e)
        {
            Response.Redirect("car_rental.aspx");
        }
    }
}