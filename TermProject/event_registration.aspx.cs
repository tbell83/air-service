using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ECommerceLibrary;

namespace TermProject{
    public partial class event_registration : System.Web.UI.Page{
        EventService.WS eventService = new EventService.WS();
        EventService.Event activityObject = new EventService.Event();
        DataSet eventAgencies = new DataSet();
        DataSet events = new DataSet();
        string city;
        string state;
        string agencyName;
        int agencyID;
        List<string> venues = new List<string>();
        List<string> activity = new List<string>();

        protected void Page_Load(object sender, EventArgs e){
            
            //Check if user is logged in
            if (Session["user"] == null){
                Response.AddHeader("REFRESH", "50;URL=login.aspx");
                Response.Redirect("login.aspx");
            }
        }

        protected void btnSelectLocation_Click(object sender, EventArgs e){
            city = ddlLocation.SelectedValue.ToString().Split(',')[0];
            state = ddlLocation.SelectedValue.ToString().Split(',')[1];

            activityObject.Activity = "";
            activityObject.Date = "";
            activityObject.Time = "";
            activityObject.Venue = "";

            eventAgencies = eventService.GetEventAgencies(city, state);
            events = eventService.FindEvents(activityObject, city, state);

            foreach(DataRow row in events.Tables[0].Rows){
                activity.Add(row[6].ToString());
                venues.Add(row[11].ToString());
            }
            venues = venues.Distinct().ToList();
            activity = activity.Distinct().ToList();

            ListItem liShowAll = new ListItem();
            liShowAll.Value = "";
            liShowAll.Text = "Show All";
            liShowAll.Selected = true;

            ddlVenues.Items.Clear();
            ddlVenues.Items.Add(liShowAll);
            ddlVenues.DataSource = venues;
            ddlVenues.DataBind();

            ddlActivityType.Items.Clear();
            ddlActivityType.Items.Add(liShowAll);
            ddlActivityType.DataSource = activity;
            ddlActivityType.DataBind();

            divResults.Visible = false;
            eventOptions.Visible = true;
        }

        protected void btnSearch_Click(object sender, EventArgs e){
            city = ddlLocation.SelectedValue.ToString().Split(',')[0];
            state = ddlLocation.SelectedValue.ToString().Split(',')[1];

            activityObject.Venue = ddlVenues.SelectedValue.ToString();
            activityObject.Activity = ddlActivityType.SelectedValue.ToString();
            
            if(chkAnyTime.Checked){ activityObject.Time = ""; }
            else { activityObject.Time = (int.Parse(ddlHour.SelectedValue) + int.Parse(ddlAMPM.SelectedValue)).ToString() + ddlMinute.SelectedValue.ToString(); }
            
            if(chkShowAllDates.Checked){ activityObject.Date = ""; }
            else { 
                string date = calEventDate.SelectedDate.ToShortDateString().Split('/')[0] + "/" + calEventDate.SelectedDate.ToShortDateString().Split('/')[1];
                activityObject.Date = date;
            }

            events = eventService.FindEvents(activityObject, city, state);
            Session["EventsToRegister"] = events;

            gvEvents.DataSource = events;
            gvEvents.DataBind();

            divResults.Visible = true;
        }

        protected void btnSelectEvents_Click(object sender, EventArgs e){
            VacationPackage cart = (VacationPackage)Session["cart"];
            DataSet eventsFromCart = (DataSet)cart.EventReservations[0];

            List<int> eventsToRegister = new List<int>();
            if(Session["EventsToRegister"] != null){
                events = (DataSet)Session["EventsToRegister"];
            }

            foreach(GridViewRow row in gvEvents.Rows){
                CheckBox checkBox = (CheckBox)row.FindControl("chkSelectEvent");
                if(checkBox.Checked){
                    eventsToRegister.Add(int.Parse(row.Cells[6].Text));
                }
            }

            foreach(DataRow row in events.Tables[0].Rows){
                int eventID = int.Parse(row[0].ToString());
                bool delete = true;
                foreach(int number in eventsToRegister){
                    if(number == eventID){
                        delete = false;
                    }
                }
                if(delete){
                    row.Delete();
                }
            }
            events.AcceptChanges();

            foreach(DataRow row in events.Tables[0].Rows){
                eventsFromCart.Tables[0].ImportRow(row);
            }

            cart.EventReservations.Add(events);
            Session["cart"] = cart;
            Response.Redirect("./shopping_cart.aspx");
        }
    }
}