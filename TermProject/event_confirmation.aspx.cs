using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TermProject{
    public partial class event_confirmation : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            if(!IsPostBack){
                if(Session["EventsToRegister"] != null){
//                    List<GridViewRow> eventsToRegister = (List<GridViewRow>)Session["EventsToRegister"];
                    DataSet eventsToRegister = (DataSet)Session["EventsToRegister"];
                    gvEventsToRegister.DataSource = eventsToRegister;
                    gvEventsToRegister.DataBind();
                }
            }
        }
    }
}