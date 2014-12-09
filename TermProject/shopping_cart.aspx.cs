﻿using ECommerceLibrary;
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

            //iterate through cars

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
        }

        
    }
}
