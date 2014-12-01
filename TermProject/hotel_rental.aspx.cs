using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject
{
    public partial class hotel_rental : System.Web.UI.Page
    {
        HotelService.HotelService hotelProxy = new HotelService.HotelService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}