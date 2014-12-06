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
    public partial class hotel_rental : System.Web.UI.Page
    {
        HotelService.HotelService hotelProxy = new HotelService.HotelService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            btnSearch.Visible = false;
            btnNewSearch.Visible = true; 
            lblErrorMsg.Text = ""; //get rid of old error messages
            gvHotel.DataSource = ""; //reset gridview
            gvHotel.DataBind();

            if (txtCity.Text.Length > 0)
            {
                string city = txtCity.Text;
                string state = ddlStates.SelectedValue;
                gvHotel.DataSource = hotelProxy.GetHotels(city, state);
                gvHotel.DataBind();

                if (gvHotel.Rows.Count > 0)
                {
                    ddlHotel.DataSource = hotelProxy.GetHotels(city, state);
                    ddlHotel.DataTextField = "Name";
                    ddlHotel.DataValueField = "HotelID";
                    ddlHotel.DataBind();

                    pnlHotels.Visible = true;

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
            pnlHotels.Visible = false;
            lblErrorMsg.Text = " ";
            txtCity.Text = "";
            ddlStates.SelectedIndex = 0;
        }

        protected void btnSearchRooms_Click(object sender, EventArgs e)
        {
            HotelService.Hotel hotel = new HotelService.Hotel();
            hotel.Id = Int32.Parse(ddlHotel.SelectedValue);
            DataSet roomsByHotel = hotelProxy.GetRooms(hotel);

            gvRooms.DataSource = hotelProxy.GetRooms(hotel);
            gvRooms.DataBind();

            HotelService.Amenities amenities = new HotelService.Amenities();

            amenities.Wifi = Int32.Parse(ddlWifi.SelectedValue);
            amenities.Smoking = Int32.Parse(ddlSmoking.SelectedValue);
            amenities.ValetParking = Int32.Parse(ddlValetParking.SelectedValue);
            amenities.Gym = Int32.Parse(ddlGym.SelectedValue);
            amenities.PoolsideBar = Int32.Parse(ddlPoolsideBar.SelectedValue);
            amenities.FreeBreakfast = Int32.Parse(ddlBreakfast.SelectedValue);

            DataSet roomsByAmenities = hotelProxy.GetRoomsByAmenities(amenities, gvHotel.Rows[0].Cells[2].Text, gvHotel.Rows[0].Cells[3].Text);

           
            //iterates through gridview of rooms by hotel and compares it to dataset of rooms by amenities
            for (int i = 0; i < gvRooms.Rows.Count; i++)
            {
                string roomID1 = gvRooms.Rows[i].Cells[2].Text;
                bool foundmatch = false;

                for (int j = 0; j < roomsByAmenities.Tables[0].Rows.Count; j++)
                {
                    string roomID2 = roomsByAmenities.Tables[0].Rows[j].ItemArray.GetValue(2).ToString();
                    if (roomID1 == roomID2)
                    {
                        foundmatch = true;
                    }
                }
                if (!foundmatch) 
                { //hide all rows that did not appear in both datasets
                    gvRooms.Rows[i].Visible = false;
                }
            }    
        }

        protected void gvRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}