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
    public partial class hotel_rental : System.Web.UI.Page
    {
        HotelService.HotelService hotelProxy = new HotelService.HotelService();

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
            pnlRooms.Visible = false;
            lblErrorMsg.Text = " ";
            txtCity.Text = "";
            ddlStates.SelectedIndex = 0;
        }

        protected void btnSearchRooms_Click(object sender, EventArgs e)
        {
            pnlRooms.Visible = true;
            lblErrorRooms.Text = ""; 
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
            //gvRooms.Columns[2].Visible = false;
            
        }

        protected void gvRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean reserved = Convert.ToBoolean(gvRooms.SelectedRow.Cells[5].Text);
            string hotel = gvRooms.SelectedRow.Cells[1].Text;
            string roomID = gvRooms.SelectedRow.Cells[2].Text;
            string roomNum = gvRooms.SelectedRow.Cells[3].Text; 
            string price = gvRooms.SelectedRow.Cells[4].Text;
            

            if (reserved)
            {
                lblErrorRooms.Text = "Sorry, that room is already reserved.";
            }

            else
            {
                //HotelService.Room room = new HotelService.Room();
                HotelRoom room = new HotelRoom(); //class created in ecommercelibrary
                room.RoomID = Int16.Parse(roomID);
                room.RoomNum = Int16.Parse(roomNum);
                room.Price = Convert.ToInt32(price); 

                if (Session["cart"] != null)
                {
                    VacationPackage cart = (VacationPackage)Session["cart"];
                    cart.HotelReservations.Add(room);
                    Session["cart"] = cart;
                }

                lblErrorRooms.Text = "Room " + roomNum + " at " + hotel + " has been added to your cart";
                gvRooms.SelectedRow.Enabled = false; //check to see if this works
            }
        }

    }
}