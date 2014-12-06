using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Drawing;

namespace TermProject
{
    public partial class car_rental : System.Web.UI.Page
    {
        CarService.CarWebService carProxy = new CarService.CarWebService();

        protected void Page_Load(object sender, EventArgs e)
        {

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
            lblErrorMsg.Text = " ";
            txtCity.Text = "";
            ddlStates.SelectedIndex = 0;
        }

        protected void gvAgencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = gvAgencies.SelectedRow.Cells[4].Text;
            string state = gvAgencies.SelectedRow.Cells[5].Text;
            CarService.Agency agency = new CarService.Agency();
            agency.AgencyID = gvAgencies.SelectedRow.Cells[1].Text;
            gvCars.DataSource = carProxy.GetCars(agency, city, state);
            gvCars.DataBind();
        }

        protected void btnSearchByAmenities_Click(object sender, EventArgs e)
        {
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
    }
}