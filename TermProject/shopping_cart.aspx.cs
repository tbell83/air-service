﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using ECommerceLibrary;

namespace TermProject
{
    public partial class shopping_cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VacationPackage cart = (VacationPackage)Session["cart"];
            gvCars.DataSource = cart.CarReservations;
            gvCars.DataBind();
            gvHotels.DataSource = cart.HotelReservations;
            gvHotels.DataBind();
            gvFlights.DataSource = cart.FlightReservations;
            gvFlights.DataBind();
            gvEvents.DataSource = cart.EventReservations;
            gvEvents.DataBind();

          

        }
    }
}