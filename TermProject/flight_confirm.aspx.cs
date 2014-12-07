using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject{
    public partial class flight_confirm : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            List<object> FlightReservation = (List<Object>)Session["FlightReservation"];

            if(FlightReservation != null){
                int carrierID = (int)FlightReservation[0];
                lblCarrierID.Text = carrierID.ToString();
                    
                int originAirport = (int)FlightReservation[1];
                lblFrom.Text = originAirport.ToString();
                int destinationAirport = (int)FlightReservation[2];
                lblTo.Text = destinationAirport.ToString();

                List<object> Outgoing = (List<Object>)FlightReservation[3];
                int outgoingFlightID = (int)Outgoing[0];
                lblOutgoingFlightID.Text = outgoingFlightID.ToString();
                DateTime outgoingDate = (DateTime)Outgoing[1];
                lblOutgoingDate.Text = outgoingDate.ToShortDateString();

                string seatType = (string)Outgoing[2];
                lblSeatType.Text = seatType;

                if(FlightReservation.Count == 5){
                    List<object> Incoming = (List<Object>)FlightReservation[4];
                    int incomingFlightID = (int)Incoming[0];
                    lblIncomingFlightID.Text = incomingFlightID.ToString();
                    DateTime incomingDate = (DateTime)Incoming[1];
                    lblIncomingDate.Text = incomingDate.ToShortDateString();
                }
            }
        }
    }
}