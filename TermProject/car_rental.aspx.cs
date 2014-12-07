using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Drawing;
using ECommerceLibrary;

namespace TermProject
{
    public partial class car_rental : System.Web.UI.Page
    {
        CarService.CarWebService carProxy = new CarService.CarWebService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.AddHeader("REFRESH", "50;URL=login.aspx");
                Response.Redirect("login.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
                btnSearch.Visible = false;
                btnNewSearch.Visible = true;
                lblErrorMsg.Text = ""; //get rid of old error messages

                if (txtCity.Text.Length > 0)
                {
                    string city = txtCity.Text;
                    string state = ddlStates.SelectedValue;
                    gvAgencies.DataSource = carProxy.GetRentalCarAgencies(city, state);
                    gvAgencies.DataBind();

                    if (gvAgencies.Rows.Count > 0)
                    {
                        pnlCars.Visible = true;
                    }
                    else
                    {
                        lblErrorMsg.Text = "No hotels were found were for that city and state";
                    }
                }
                else
                {
                    lblErrorMsg.Text = "Please enter the name of a city";
                }
        }
        
        protected void btnNewSearch_Click(object sender, EventArgs e)
        {
            btnNewSearch.Visible = false;
            btnSearch.Visible = true;
            pnlCars.Visible = false;
            pnlCarResults.Visible = false;
            lblErrorMsg.Text = " ";
            txtCity.Text = "";
            ddlStates.SelectedIndex = 0;
        }

        protected void gvAgencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCarResults.Visible = true;
            lblErrorCars.Text = " "; 
            string city = gvAgencies.SelectedRow.Cells[4].Text;
            string state = gvAgencies.SelectedRow.Cells[5].Text;
            CarService.Agency agency = new CarService.Agency();
            agency.AgencyID = gvAgencies.SelectedRow.Cells[1].Text;
            gvCars.DataSource = carProxy.GetCars(agency, city, state);
            gvCars.DataBind();
           
        }

        protected void btnSearchByAmenities_Click(object sender, EventArgs e)
        {
            pnlCarResults.Visible = true;
            lblErrorCars.Text = " "; 

            CarService.Requirements reqs = new CarService.Requirements();
            reqs.GetCarType = ddlType.SelectedValue;
            reqs.Getmake = ddlMake.SelectedValue;
            reqs.GetModel = ddlModel.SelectedValue;
            reqs.GetnumberOfDoors = ddlDoors.SelectedValue;
            reqs.GetYearMade = ddlYear.SelectedValue;
            reqs.GetTransmission = ddlTransmission.SelectedValue;
            reqs.GetIsAllWheelDrive = ddlAWD.SelectedValue;
            reqs.GetHasSunroof = ddlSunroof.SelectedValue;
            reqs.GetHasRearviewCamera = ddlRearviewCamera.SelectedValue;
            reqs.GetHasNavigation = ddlGPS.SelectedValue;
            reqs.GetColor = ddlColor.SelectedValue;

            gvCars.DataSource = carProxy.FindCars(reqs, gvAgencies.Rows[1].Cells[4].Text, gvAgencies.Rows[1].Cells[5].Text);
            gvCars.DataBind();

        }

        protected void gvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarService.Car car = new CarService.Car();
            car.GetCarID = Int16.Parse(gvCars.SelectedRow.Cells[1].Text);
            car.GetYearMade = gvCars.SelectedRow.Cells[2].Text;
            car.GetMake = gvCars.SelectedRow.Cells[3].Text;
            car.GetCarType = gvCars.SelectedRow.Cells[4].Text; //model
            //type =5
            car.GetnumberOfDoors = gvCars.SelectedRow.Cells[6].Text;
            car.GetTransmission = gvCars.SelectedRow.Cells[7].Text;
            car.GetHasNavigation = gvCars.SelectedRow.Cells[8].Text;
            car.GetHasRearviewCamera = gvCars.SelectedRow.Cells[9].Text;
            car.GetColor = gvCars.SelectedRow.Cells[10].Text;
            car.GetIsAllWheelDrive = gvCars.SelectedRow.Cells[11].Text;
            car.GetDailyRate = gvCars.SelectedRow.Cells[12].Text;

            //BIND THE GRIDVIEW TO THE CORRECT FIELDS AND THEN FILL IN THE REST OF THESE WITH OTHER PARTS OF OBJECT
            
            
            if (Session["cart"] != null)
            {
                VacationPackage cart = (VacationPackage)Session["cart"];
                cart.CarReservations.Add(car); 
                Session["cart"] = cart;
            }


            lblErrorCars.Text = "Car " + car.GetCarID + ": " + car.GetYearMade + " " + car.GetMake + " " + car.GetCarType + " has been added to your cart."; 
        }
    }
}