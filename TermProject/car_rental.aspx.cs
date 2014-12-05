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
            gvAgencies.DataSource = carProxy.GetRentalCarAgencies("Philadelphia", "PA");
            gvAgencies.DataBind();
        }
        
        protected void btnNewSearch_Click(object sender, EventArgs e)
        {
            string city = gvAgencies.Rows[0].Cells[4].Text;
            string state = gvAgencies.Rows[0].Cells[5].Text;
            CarService.Agency agency = new CarService.Agency();
            agency.AgencyID = "1"; 



        }
    }
}