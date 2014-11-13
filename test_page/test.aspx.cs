using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace test_page{
    public partial class test : System.Web.UI.Page{
        AirService.AirService AirService = new AirService.AirService();
        protected void Page_Load(object sender, EventArgs e){
            gvCarriers.DataSource=AirService.GetAirCarriers("Philadelphia","PA","Las Vegas","NV");
            gvCarriers.DataBind();
        }
    }
}