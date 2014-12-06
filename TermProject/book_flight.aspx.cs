using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TermProject{
    public partial class book_flight : System.Web.UI.Page{

        AirService.AirService airService = new AirService.AirService();
        DataSet cityInfo = new DataSet();
        int originAirportID;
        string originState;
        string originCity;
        int destinationAirportID;
        string destinationState;
        string destinationCity;

        protected void Page_Load(object sender, EventArgs e){
            cityInfo = airService.getCities();
            List<string> States = new List<string>();

            foreach(DataRow row in cityInfo.Tables[0].Rows){
                States.Add(row[5].ToString());
            }

            States = States.Distinct().ToList();

            if(!IsPostBack){
                ddlState.Items.Clear();
                ddlState.Items.Add(new ListItem("--Select a State--",""));
                ddlState.DataSource = States;
                ddlState.DataBind();

                ddlArrivalState.Items.Clear();
                ddlArrivalState.Items.Add(new ListItem("--Select a State--",""));
                ddlArrivalState.DataSource = States;
                ddlArrivalState.DataBind();

            }
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e){
            string state = ddlState.SelectedItem.ToString();
            originState = state;
            List<string> cities = new List<string>();

            foreach(DataRow row in cityInfo.Tables[0].Rows){
                if(row[5].ToString() == state){
                    cities.Add(row[4].ToString());
                }
            }

            ddlCity.Items.Clear();
            ddlCity.Items.Add(new ListItem("--Select a City--",""));
            ddlCity.DataSource = cities;
            ddlCity.DataBind();
            ddlAirport.Items.Clear();
        }

        protected void ddlAirport_SelectedIndexChanged(object sender, EventArgs e){
            if(ddlAirport.SelectedItem.ToString() == "--Select an Airport--"){ return; }
            originAirportID = int.Parse(ddlAirport.SelectedValue.ToString());
            lblFrom.Text = originAirportID.ToString();
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e){
            string city = ddlCity.SelectedItem.ToString();
            originCity = city;
            List<string> airports = new List<string>();
            DataTable airportsNCodes = new DataTable();
            airportsNCodes.Columns.Add("Name", typeof(string));
            airportsNCodes.Columns.Add("ID", typeof(int));

            foreach(DataRow row in cityInfo.Tables[0].Rows){
                if(row[4].ToString() == city){
                    DataRow newRow = airportsNCodes.NewRow();
                    newRow["Name"] = row[2].ToString();
                    newRow["ID"] = row[0];
                    airportsNCodes.Rows.Add(newRow);
                    airports.Add(row[2].ToString() + ";" + row[0].ToString());
                }
            }

            ddlAirport.Items.Clear();
            ddlAirport.Items.Add(new ListItem("--Select an Airport--",""));
            ddlAirport.DataSource = airportsNCodes;
            ddlAirport.DataTextField = "Name";
            ddlAirport.DataValueField = "ID";
            ddlAirport.DataBind();
        }

        protected void ddlArrivalState_SelectedIndexChanged(object sender, EventArgs e){
            string state = ddlArrivalState.SelectedItem.ToString();
            destinationState = state;
            List<string> cities = new List<string>();

            foreach(DataRow row in cityInfo.Tables[0].Rows){
                if(row[5].ToString() == state){
                    cities.Add(row[4].ToString());
                }
            }

            ddlArrivalCity.Items.Clear();
            ddlArrivalCity.Items.Add(new ListItem("--Select a City--",""));
            ddlArrivalCity.DataSource = cities;
            ddlArrivalCity.DataBind();
            ddlArrivalAirport.Items.Clear();
        }

        protected void ddlArrivalAirport_SelectedIndexChanged(object sender, EventArgs e){
            if(ddlArrivalAirport.SelectedItem.ToString() == "--Select an Airport--"){ return; }
            destinationAirportID = int.Parse(ddlArrivalAirport.SelectedValue.ToString());
            lblTo.Text = destinationAirportID.ToString();
        }

        protected void ddlArrivalCity_SelectedIndexChanged(object sender, EventArgs e){
            string city = ddlArrivalCity.SelectedItem.ToString();
            destinationCity = city;
            List<string> airports = new List<string>();
            DataTable airportsNCodes = new DataTable();
            airportsNCodes.Columns.Add("Name", typeof(string));
            airportsNCodes.Columns.Add("ID", typeof(int));

            foreach(DataRow row in cityInfo.Tables[0].Rows){
                if(row[4].ToString() == city){
                    DataRow newRow = airportsNCodes.NewRow();
                    newRow["Name"] = row[2].ToString();
                    newRow["ID"] = row[0];
                    airportsNCodes.Rows.Add(newRow);
                    airports.Add(row[2].ToString() + ";" + row[0].ToString());
                }
            }

            ddlArrivalAirport.Items.Clear();
            ddlArrivalAirport.Items.Add(new ListItem("--Select an Airport--",""));
            ddlArrivalAirport.DataSource = airportsNCodes;
            ddlArrivalAirport.DataTextField = "Name";
            ddlArrivalAirport.DataValueField = "ID";
            ddlArrivalAirport.DataBind();
        }

        protected void btnFindCarriers_Click(object sender, EventArgs e){
                ddlCarriers.DataSource = airService.GetAirCarriers(ddlCity.SelectedItem.ToString(),ddlState.SelectedItem.ToString(),ddlArrivalCity.SelectedItem.ToString(),ddlArrivalState.SelectedItem.ToString());
                ddlCarriers.DataTextField = "carrierName";
                ddlCarriers.DataValueField = "carrierID";
                ddlCarriers.DataBind();
        }

        protected void btnShowFlights_Click(object sender, EventArgs e){
            string requirements = ddlSeatType.SelectedItem.ToString();
            string[] requirementsIsSilly = new string[]{requirements};
            gvAvailableFlights.DataSource = airService.FindFlights(requirementsIsSilly, ddlCity.SelectedItem.ToString(),ddlState.SelectedItem.ToString(),ddlArrivalCity.SelectedItem.ToString(),ddlArrivalState.SelectedItem.ToString());
            gvAvailableFlights.DataBind();

            if(chkFlightType.Checked){
                returning.Visible = true;
                gvAvailableFlightsReturning.DataSource = airService.FindFlights(requirementsIsSilly,ddlArrivalCity.SelectedItem.ToString(),ddlArrivalState.SelectedItem.ToString(),ddlCity.SelectedItem.ToString(),ddlState.SelectedItem.ToString());
                gvAvailableFlightsReturning.DataBind();
            }
        }

    }
}