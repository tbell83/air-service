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
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AirService : System.Web.Services.WebService{
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        string strSQL;

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
            objDB.CloseConnection();
            return carriers;
        }


        //This function accepts as input as an AirCarrierID for the air carrier of their choice, and returns a DataSet containing records for available flights to and from a city. You must provide pricing for each record that will be used by the customer booking the trip and the web application to calculate the total cost. You need to give the user the ability to find flights based on some criteria, too. This should be implemented in the next web service function.
        //(carrier As Object, Departure City, Departure State, Arrival City, Arrival State
        [WebMethod]
        public DataSet GetFlights(int carrierID, string departureCity, string departureState, string arrivalCity, string arrivalState)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "getFlights";

            SqlParameter inputParam_carrierID = new SqlParameter("@carrierID", carrierID);
            inputParam_carrierID.Direction = ParameterDirection.Input;
            inputParam_carrierID.SqlDbType = SqlDbType.Int;
            inputParam_carrierID.Size = 4; //4 bytes

            SqlParameter inputParam_departureCity = new SqlParameter("@departureCity", departureCity);
            inputParam_departureCity.Direction = ParameterDirection.Input;
            inputParam_departureCity.SqlDbType = SqlDbType.VarChar;
            inputParam_departureCity.Size = 50;

            SqlParameter inputParam_departureState = new SqlParameter("@departureState", departureState);
            inputParam_departureState.Direction = ParameterDirection.Input;
            inputParam_departureState.SqlDbType = SqlDbType.VarChar;
            inputParam_departureState.Size = 50;

            SqlParameter inputParam_arrivalCity = new SqlParameter("@arrivalCity", arrivalCity);
            inputParam_arrivalCity.Direction = ParameterDirection.Input;
            inputParam_arrivalCity.SqlDbType = SqlDbType.VarChar;
            inputParam_arrivalCity.Size = 50;

            SqlParameter inputParam_arrivalState = new SqlParameter("@arrivalState", arrivalState);
            inputParam_arrivalState.Direction = ParameterDirection.Input;
            inputParam_arrivalState.SqlDbType = SqlDbType.VarChar;
            inputParam_arrivalState.Size = 50; 

            objCommand.Parameters.Add(inputParam_carrierID);
            objCommand.Parameters.Add(inputParam_departureCity);
            objCommand.Parameters.Add(inputParam_departureState);
            objCommand.Parameters.Add(inputParam_arrivalCity);
            objCommand.Parameters.Add(inputParam_arrivalState);

            DataSet flights = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            return flights;
        }

        //This function accepts as input either an object of a class that represents the requirements for a flight, or an array of items representing each amenity they want like non-stop or first-class seating, and returns a DataSet containing records that meet the requirements. You must provide pricing for each record that will be used by the customer booking the trip and the web application to calculate the total cost.
        //(requirements As Object, Departure City, Departure State, Arrival City, Arrival State) 
        [WebMethod]
        public DataSet FindFlights(string[] requirements, string originCityName, string originState, string destinationCityName, string destinationState){
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindFlights";
            objCommand.Parameters.AddWithValue("@originCity", originCityName);
            objCommand.Parameters.AddWithValue("@originState", originState);
            objCommand.Parameters.AddWithValue("@destinationCity", destinationCityName);
            objCommand.Parameters.AddWithValue("@destinationState", destinationState);
            DataSet flights = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            foreach (string item in requirements){
                if (item == "First Class"){
                    flights.Tables[0].Columns.RemoveAt(7);
                    flights.Tables[0].Columns.RemoveAt(5);
                }else if(item == "Economy"){
                    flights.Tables[0].Columns.RemoveAt(8);
                    flights.Tables[0].Columns.RemoveAt(6);
                }
            }
            return flights;
        }

        //This function returns a dataset containing state, city, and airport information.
        [WebMethod]
        public DataSet getCities(){
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCities";
            DataSet cities = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            return cities;
        }

        [WebMethod]
        public DataSet getFlightsFrom(int originAirportID){
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetFlightsFrom";
            objCommand.Parameters.AddWithValue("@OriginAirportID", originAirportID);
            DataSet flightsFrom = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            return flightsFrom;
        }

        [WebMethod]
        public DataSet getFlightsTo(int destinationAirportID){
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetFlightsTo";
            objCommand.Parameters.AddWithValue("@DestinationAirportID", destinationAirportID);
            DataSet flightsTo = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            return flightsTo;
        }

        [WebMethod(MessageName="ReserveSingle")]
        public Boolean Reserve(int customerID, int flightID, string seatType, string dateTime){
            DateTime flightDate = Convert.ToDateTime(dateTime);
            bool success;
            if (CheckAvailability(flightID, flightDate, seatType)){
                success = true;
            } else {
                return false;
            }

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CreateTrip";

            SqlParameter inputParam_customerID = new SqlParameter("@customerID", customerID);
            inputParam_customerID.Direction = ParameterDirection.Input;
            inputParam_customerID.SqlDbType = SqlDbType.Int;
            inputParam_customerID.Size = 4;
            objCommand.Parameters.Add(inputParam_customerID); 

            SqlParameter outputParam_tripID = new SqlParameter("@tripID", DbType.Int32);
            outputParam_tripID.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputParam_tripID);

            try {
                objDB.DoUpdateUsingCmdObj(objCommand);
                objDB.CloseConnection();
            }
            catch (Exception e){
                objDB.CloseConnection();
                return false; 
            }

            int tripID = int.Parse(objCommand.Parameters["@tripID"].Value.ToString());

            SqlCommand objCommand2 = new SqlCommand(); 
            objCommand2.CommandType = CommandType.StoredProcedure;
            objCommand2.CommandText = "CreateReservation";

            SqlParameter inputParam_tripID = new SqlParameter("@tripID", tripID);
            inputParam_tripID.Direction = ParameterDirection.Input;
            inputParam_tripID.SqlDbType = SqlDbType.Int;
            inputParam_tripID.Size = 4;

            SqlParameter inputParam_flightID = new SqlParameter("@flightID", flightID);
            inputParam_flightID.Direction = ParameterDirection.Input;
            inputParam_flightID.SqlDbType = SqlDbType.Int;
            inputParam_flightID.Size = 4; //4 bytes

            SqlParameter inputParam_seatType = new SqlParameter("@seatType", seatType);
            inputParam_seatType.Direction = ParameterDirection.Input;
            inputParam_seatType.SqlDbType = SqlDbType.VarChar;
            inputParam_seatType.Size = 50;

            SqlParameter inputParam_flightDate = new SqlParameter("@flightDate", flightDate);
            inputParam_flightDate.Direction = ParameterDirection.Input;
            inputParam_flightDate.SqlDbType = SqlDbType.DateTime; 
            inputParam_flightDate.Size = 50;

            objCommand2.Parameters.Add(inputParam_tripID);
            objCommand2.Parameters.Add(inputParam_flightID);
            objCommand2.Parameters.Add(inputParam_seatType);
            objCommand2.Parameters.Add(inputParam_flightDate);

            try {
                objDB.DoUpdateUsingCmdObj(objCommand2);
                objDB.CloseConnection();
            }
            catch (Exception e){
                objDB.CloseConnection();
                return false;
            }

            return success;
        }


        [WebMethod(MessageName="Reserve")]
        public Boolean Reserve(int customerID, int flightID1, string seatType1, string dt1, int flightID2, string seatType2, string dt2)  //default params for flightID2, seatType2, dt2 make them optional
        {
            DateTime flightDate1 = Convert.ToDateTime(dt1);
            DateTime flightDate2 = Convert.ToDateTime(dt2);
            bool success;
            if (CheckAvailability(flightID1, flightDate1, seatType1) && CheckAvailability(flightID2, flightDate2, seatType2))
            {
                success = true;
            }
            else
            {
                success = false;
                return success;
            }
       
            //create trip for customer with tripID as output parameter
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CreateTrip";

            SqlParameter inputParam_customerID = new SqlParameter("@customerID", customerID);
            inputParam_customerID.Direction = ParameterDirection.Input;
            inputParam_customerID.SqlDbType = SqlDbType.Int;
            inputParam_customerID.Size = 4;
            objCommand.Parameters.Add(inputParam_customerID); 

            SqlParameter outputParam_tripID = new SqlParameter("@tripID", DbType.Int32);
            outputParam_tripID.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputParam_tripID);

            //execute stored procedure
            try {
                objDB.DoUpdateUsingCmdObj(objCommand);
                objDB.CloseConnection();
            }
            catch (Exception e) 
            {
                objDB.CloseConnection();
                success = false;
                return success; 
            }
            
            //get tripID, to be used in creating reservations
            int tripID = int.Parse(objCommand.Parameters["@tripID"].Value.ToString());  
            
            //create first reservation
            SqlCommand objCommand2 = new SqlCommand(); 
            objCommand2.CommandType = CommandType.StoredProcedure;
            objCommand2.CommandText = "CreateReservation";

            SqlParameter inputParam_tripID = new SqlParameter("@tripID", tripID);
            inputParam_tripID.Direction = ParameterDirection.Input;
            inputParam_tripID.SqlDbType = SqlDbType.Int;
            inputParam_tripID.Size = 4;

            SqlParameter inputParam_flightID1 = new SqlParameter("@flightID", flightID1);
            inputParam_flightID1.Direction = ParameterDirection.Input;
            inputParam_flightID1.SqlDbType = SqlDbType.Int;
            inputParam_flightID1.Size = 4; //4 bytes

            SqlParameter inputParam_seatType1 = new SqlParameter("@seatType", seatType1);
            inputParam_seatType1.Direction = ParameterDirection.Input;
            inputParam_seatType1.SqlDbType = SqlDbType.VarChar;
            inputParam_seatType1.Size = 50;

            SqlParameter inputParam_flightDate1 = new SqlParameter("@flightDate", flightDate1);
            inputParam_flightDate1.Direction = ParameterDirection.Input;
            inputParam_flightDate1.SqlDbType = SqlDbType.DateTime; 
            inputParam_flightDate1.Size = 50;

            objCommand2.Parameters.Add(inputParam_tripID);
            objCommand2.Parameters.Add(inputParam_flightID1);
            objCommand2.Parameters.Add(inputParam_seatType1);
            objCommand2.Parameters.Add(inputParam_flightDate1);

            //execute stored procedure
            try {
                objDB.DoUpdateUsingCmdObj(objCommand2);
                objDB.CloseConnection();
            }
            catch (Exception e)
            {
                objDB.CloseConnection();
                success = false;
                return success;
            }

            if (flightID2 > 0)  //will give flightID2 a default val of 0 
            {
                //create second reservation
                SqlCommand objCommand3 = new SqlCommand();
                objCommand3.CommandType = CommandType.StoredProcedure;
                objCommand3.CommandText = "CreateReservation";

                SqlParameter inputParam_tripID2 = new SqlParameter("@tripID", tripID);
                inputParam_tripID.Direction = ParameterDirection.Input;
                inputParam_tripID.SqlDbType = SqlDbType.Int;
                inputParam_tripID.Size = 4;

                SqlParameter inputParam_flightID2 = new SqlParameter("@flightID", flightID2);
                inputParam_flightID1.Direction = ParameterDirection.Input;
                inputParam_flightID1.SqlDbType = SqlDbType.Int;
                inputParam_flightID1.Size = 4; //4 bytes

                SqlParameter inputParam_seatType2 = new SqlParameter("@seatType", seatType2);
                inputParam_seatType1.Direction = ParameterDirection.Input;
                inputParam_seatType1.SqlDbType = SqlDbType.VarChar;
                inputParam_seatType1.Size = 50;

                SqlParameter inputParam_flightDate2 = new SqlParameter("@flightDate", flightDate2);
                inputParam_flightDate2.Direction = ParameterDirection.Input;
                inputParam_flightDate2.SqlDbType = SqlDbType.DateTime;
                inputParam_flightDate2.Size = 50;

                objCommand3.Parameters.Add(inputParam_tripID2);
                objCommand3.Parameters.Add(inputParam_flightID2);
                objCommand3.Parameters.Add(inputParam_seatType2);
                objCommand3.Parameters.Add(inputParam_flightDate2);

                //execute stored procedure
                try {
                    objDB.DoUpdateUsingCmdObj(objCommand3);
                    objDB.CloseConnection();
                }
                catch (Exception e)
                {
                    objDB.CloseConnection();
                    success = false;
                    return success;
                }            
            }
            return success; //returns true for function successful
        }

        [WebMethod]
        public DataSet GetTable(string tableName)
        {
            strSQL = "SELECT * FROM " + tableName; 
            DataSet results = objDB.GetDataSet(strSQL);
            objDB.CloseConnection();
            return results;
        }

        [WebMethod]
        public int CheckAvailable(int flightID, DateTime flightDate, string seatClass){
            bool output = false;
            SqlCommand objCommandCheck = new SqlCommand(); 
            objCommandCheck.CommandType = CommandType.StoredProcedure;

            if(seatClass == "Economy"){
                objCommandCheck.CommandText = "CheckEconomyAvailability";
            }else if(seatClass == "First Class"){
                objCommandCheck.CommandText = "CheckFirstClassAvailability";
            }

            objCommandCheck.Parameters.AddWithValue("@flightID", flightID);
            objCommandCheck.Parameters.AddWithValue("@flightDate", flightDate);
            DataSet availability = objDB.GetDataSetUsingCmdObj(objCommandCheck);
            objDB.CloseConnection();
            int available = int.Parse(availability.Tables[0].Rows[0][0].ToString());

            return available;
        }

        private bool CheckAvailability(int flightID, DateTime flightDate, string seatClass){
            bool output = false;
            SqlCommand objCommandCheck = new SqlCommand(); 
            objCommandCheck.CommandType = CommandType.StoredProcedure;

            if(seatClass == "Economy"){
                objCommandCheck.CommandText = "CheckEconomyAvailability";
            }else if(seatClass == "First Class"){
                objCommandCheck.CommandText = "CheckFirstClassAvailability";
            }

            objCommandCheck.Parameters.AddWithValue("@flightID", flightID);
            objCommandCheck.Parameters.AddWithValue("@flightDate", flightDate);
            DataSet availability = objDB.GetDataSetUsingCmdObj(objCommandCheck);
            objDB.CloseConnection();
            int available = int.Parse(availability.Tables[0].Rows[0][0].ToString());

            if (available > 0){
                output = true;
            }

            return output;
        }
    }
}
