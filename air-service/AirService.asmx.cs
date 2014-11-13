using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace air_service{
    /// <summary>
    /// Summary description for AirService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AirService : System.Web.Services.WebService{
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        DataSet tempFill = new DataSet();

        //This function returns a list of air carriers from a table in your database for a given city and state. The Dataset returned by the function consists of fields that are unknown to the user of your web service. You need to create a simple HTML or ASPX page named (ServiceDesription.html or .aspx) that explains the usage of your web service, and publish it to the same folder the ASMX file will be located TermProjectWS. 
        [WebMethod]
        public DataSet GetAirCarriers(string originCityName, string originState, string destinationCityName, string destinationState){
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAirCarriers";
            objCommand.Parameters.AddWithValue("@originCity", originCityName);
            objCommand.Parameters.AddWithValue("@originState", originState);
            objCommand.Parameters.AddWithValue("@destinationCity", destinationCityName);
            objCommand.Parameters.AddWithValue("@destinationState", destinationState);
            DataSet carriers = objDB.GetDataSetUsingCmdObj(objCommand);
            return carriers;
        }


        //This function accepts as input as an AirCarrierID for the air carrier of their choice, and returns a DataSet containing records for available flights to and from a city. You must provide pricing for each record that will be used by the customer booking the trip and the web application to calculate the total cost. You need to give the user the ability to find flights based on some criteria, too. This should be implemented in the next web service function.
        //(carrier As Object, Departure City, Departure State, Arrival City, Arrival State
        [WebMethod]
        public DataSet GetFlights(){
            return tempFill;   
        }

        //This function accepts as input either an object of a class that represents the requirements for a flight, or an array of items representing each amenity they want like non-stop or first-class seating, and returns a DataSet containing records that meet the requirements. You must provide pricing for each record that will be used by the customer booking the trip and the web application to calculate the total cost.
        //(requirements As Object, Departure City, Departure State, Arrival City, Arrival State) 
        [WebMethod]
        public DataSet FindFlights(){
            return tempFill;
        }

        //This function accepts a FlightID for the flight the user wants to reserve, and a customer. The function updates the necessary tables to record the flight’s reservation.
        //You need to have the ability to book one-way flights and two-way flights.
        // (flight As Object, customer as Object)
        [WebMethod]
        public Boolean Reserve(){
            return true; 
        }
    }
}
