using ECommerceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using ECommerceLibrary;
using System.Data;

namespace TermProject
{
    public partial class shopping_cart : System.Web.UI.Page
    {

        HotelService.HotelService hotelProxy = new HotelService.HotelService();
        AirService.AirService airProxy = new AirService.AirService();
        CarService.CarWebService carProxy = new CarService.CarWebService();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] == null)
            {
                Response.AddHeader("REFRESH", "50;URL=login.aspx");
                Response.Redirect("login.aspx");
            }

           

            VacationPackage cart = (VacationPackage)Session["cart"];

            try{
                DataSet events = (DataSet)cart.EventReservations[0];
                gvEvents.DataSource = events;
                gvEvents.DataBind();
            }catch{}

            try{
                DataSet flights = (DataSet)cart.FlightReservations[0];
                gvFlights.DataSource = flights;
                gvFlights.DataBind();
            }catch{}

            try{
                gvCars.DataSource = cart.CarReservations;
                gvCars.DataBind();
            }catch{}

            try{
                gvHotels.DataSource = cart.HotelReservations;
                gvHotels.DataBind();
            }catch{}
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }

        protected void gvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            VacationPackage cart = (VacationPackage)Session["cart"];
            cart.CarReservations.RemoveAt(gvCars.SelectedIndex); //indeces will be same for arraylist and gv
            gvCars.DataSource = cart.CarReservations;
            gvCars.DataBind(); //updates gv of object removed
            Session["cart"] = cart; 

        }

        protected void gvHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            VacationPackage cart = (VacationPackage)Session["cart"];
            cart.HotelReservations.RemoveAt(gvHotels.SelectedIndex); //indeces will be same for arraylist and gv
            gvHotels.DataSource = cart.HotelReservations;
            gvHotels.DataBind(); //updates gv of object removed
            Session["cart"] = cart;
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            VacationPackage cart = (VacationPackage)Session["cart"];

            Serialize s = new Serialize();
            string email = Session["user"].ToString();
            int customerID = s.GetCustomerIDFromEmail(email); 

            //iterate events
            DataSet events = (DataSet)cart.EventReservations[0];
            EventService.WS eventService = new EventService.WS();
            foreach(DataRow row in events.Tables[0].Rows){
                eventService.Reserve((int)row[0], customerID);
            }

            //iterate flights
            DataSet flights = (DataSet)cart.FlightReservations[0];
            AirService.AirService airService = new AirService.AirService();
            foreach(DataRow row in flights.Tables[0].Rows){
                int flightID = (int)row[0];
                string seatType = "First Class";
                if(row[5] != ""){
                    seatType = "Economy";
                }
                string date = (string)row[5];
                try{
                    airService.ReserveSingle(customerID, flightID, seatType, date);
                }catch{}
            }

            //iterate through cars
            foreach(CarService.Car car in cart.CarReservations){
                CarService.Customer customer = new CarService.Customer();
                customer.custID = customerID;
                CarService.CarWebService carService = new CarService.CarWebService();
                carService.Reserve(car, customer);
            }

            //iterate through hotels
            for (int i = 0; i < cart.HotelReservations.Count; i++)
            {
                HotelRoom hr = (HotelRoom)cart.HotelReservations[i];
                HotelService.Room room = new HotelService.Room();
                room.RoomID = hr.RoomID;
                HotelService.Customer cust = new HotelService.Customer();
                cust.CustID = customerID;

                hotelProxy.Reserve(room, cust);
            }

            //after all reservations have been made
            if (Session["cart"] != null) //this if might not be necessary
            {
                s.WriteTransactionToDB(cart, customerID); 
            }

            cart = new VacationPackage();
            Session["cart"] = cart;
            Response.Redirect("shopping_cart.aspx"); 

        }

        protected void gvFlights_SelectedIndexChanged(object sender, EventArgs e){
            VacationPackage cart = (VacationPackage)Session["cart"];
            DataSet flights = (DataSet)cart.FlightReservations[0];
            cart.FlightReservations.RemoveAt(0);
            flights.Tables[0].Rows.RemoveAt(gvFlights.SelectedIndex);
            cart.FlightReservations.Add(flights);
            Session["cart"] = cart;
            gvFlights.DataSource = flights;
            gvFlights.DataBind();
        }

        protected void gvEvents_SelectedIndexChanged(object sender, EventArgs e){
            VacationPackage cart = (VacationPackage)Session["cart"];
            DataSet events = (DataSet)cart.FlightReservations[0];
            cart.EventReservations.RemoveAt(0);
            events.Tables[0].Rows.RemoveAt(gvEvents.SelectedIndex);
            cart.EventReservations.Add(events);
            Session["cart"] = cart;
            gvEvents.DataSource = events;
            gvEvents.DataBind();
        }

        
    }
}
