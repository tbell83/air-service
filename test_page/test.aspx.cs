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

            string[] requirements = new string[] {"First Class"};
            gvFindFlights.DataSource=AirService.FindFlights(requirements, "Philadelphia","PA","Las Vegas","NV");
            gvFindFlights.DataBind();

            gvGetFlights.DataSource = AirService.GetFlights(1, "Philadelphia", "PA", "Las Vegas", "NV");
            gvGetFlights.DataBind();

            ddlCustomers.DataSource = AirService.GetTable("airService_Customers");
            ddlCustomers.DataTextField = "customerName";
            ddlCustomers.DataValueField = "customerID";
            ddlCustomers.DataBind();

            ddlOutgoingFlightID.DataSource = AirService.GetTable("airService_Flights");
            ddlOutgoingFlightID.DataTextField = "flightID";
            ddlOutgoingFlightID.DataValueField = "flightID";
            ddlOutgoingFlightID.DataBind();

            ddlReturningFlightID.DataSource = AirService.GetTable("airService_Flights");
            ddlReturningFlightID.DataTextField = "flightID";
            ddlReturningFlightID.DataValueField = "flightID";
            ddlReturningFlightID.DataBind();

        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            int custID = int.Parse(ddlCustomers.SelectedValue);
            int flightID1 = int.Parse(ddlOutgoingFlightID.SelectedValue);
            string seatType1 = "Economy";
            int flightID2 = int.Parse(ddlReturningFlightID.SelectedValue);
            string seatType2 = "First Class";

            AirService.Reserve(custID, flightID1, seatType1, flightID2, seatType2); 
        }     
    }
}