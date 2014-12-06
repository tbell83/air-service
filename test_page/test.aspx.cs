using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace test_page{
    public partial class test : System.Web.UI.Page{
        AirService.AirService AirService = new AirService.AirService(); //proxy object
        protected void Page_Load(object sender, EventArgs e){
            gvCarriers.DataSource=AirService.GetAirCarriers("Philadelphia","PA","Las Vegas","NV");
            gvCarriers.DataBind();

            string[] requirements = new string[] {"Economy"};
            gvFindFlights.DataSource=AirService.FindFlights(requirements, "Philadelphia","PA","Las Vegas","NV");
            gvFindFlights.DataBind();

            gvGetFlights.DataSource = AirService.GetFlights(1, "Philadelphia", "PA", "Las Vegas", "NV");
            gvGetFlights.DataBind();

            gvCities.DataSource = AirService.getCities();
            gvCities.DataBind();

            //ddlCustomers.DataSource = AirService.GetTable("airService_Customers");
            //ddlCustomers.DataTextField = "customerID";
            //ddlCustomers.DataValueField = "customerID";
            //ddlCustomers.DataBind();

            //ddlOutgoingFlightID.DataSource = AirService.GetTable("airService_Flights");
            //ddlOutgoingFlightID.DataTextField = "flightID";
            //ddlOutgoingFlightID.DataValueField = "flightID";
            //ddlOutgoingFlightID.DataBind();

            //ddlReturningFlightID.DataSource = AirService.GetTable("airService_Flights");
            //ddlReturningFlightID.DataTextField = "flightID";
            //ddlReturningFlightID.DataValueField = "flightID";
            //ddlReturningFlightID.DataBind();

        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            //int custID = int.Parse(ddlCustomers.SelectedValue);
            //int flightID1 = int.Parse(ddlOutgoingFlightID.SelectedValue);
            //string seatType1 = "Economy";
            //int flightID2 = int.Parse(ddlReturningFlightID.SelectedValue);
            //string seatType2 = "First Class";

            int custID = 2; 
            int flightID1 = 3; 
            string seatType1 = "Economy"; 
            string flightDate1 = "11/22/2014"; 
            int flightID2 = 5;
            string seatType2 = "First Class"; 
            string flightDate2 = "11/24/2014"; 
            AirService.Reserve(custID, flightID1, seatType1,flightDate1, flightID2, seatType2, flightDate2); 
        }     
    }
}