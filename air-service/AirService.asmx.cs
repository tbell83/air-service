using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace air_service
{
    /// <summary>
    /// Summary description for AirService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AirService : System.Web.Services.WebService
    {
        DataSet tempFill = new DataSet(); 

        [WebMethod]
        public DataSet GetAirCarriers(string city, string state)
        {
            //This function returns a list of air carriers from a table in your database for a given city and state. The Dataset returned by the function consists of fields that are unknown to the user of your web service. You need to create a simple HTML or ASPX page named (ServiceDesription.html or .aspx) that explains the usage of your web service, and publish it to the same folder the ASMX file will be located TermProjectWS. 

            return tempFill; 
        }


        [WebMethod]
        public DataSet GetFlights() //(carrier As Object, city, state) 
        {
           //This function accepts as input as an AirCarrierID for the air carrier of their choice, and returns a DataSet containing records for available flights to and from a city. You must provide pricing for each record that will be used by the customer booking the trip and the web application to calculate the total cost. You need to give the user the ability to find flights based on some criteria, too. This should be implemented in the next web service function.

            return tempFill;   
        }

        [WebMethod]
        public DataSet FindFlights()//(flight object or array or flight specifications)
        {
           //This function accepts as input either an object of a class that represents the requirements for a flight, or an array of items representing each amenity they want like non-stop or first-class seating, and returns a DataSet containing records that meet the requirements. You must provide pricing for each record that will be used by the customer booking the trip and the web application to calculate the total cost.
            return tempFill;
        }

        [WebMethod]
        public Boolean Reserve()//(flight As Object, customer as Object) )
        {
//            This function accepts a FlightID for the flight the user wants to reserve, and a customer. The function updates the necessary tables to record the flight’s reservation.
//You need to have the ability to book one-way flights and two-way flights. 

            return true; 
        }

    }
}
