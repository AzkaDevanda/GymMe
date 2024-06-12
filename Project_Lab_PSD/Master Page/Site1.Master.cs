using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab_PSD.Master_Page
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void btnOrder_click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderSupplement.aspx");
        }

        protected void btnHistory_click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/History.aspx");
        }

        protected void btnProfile_click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void btnLogout_click(object sender, EventArgs e)
        {

        }
    }
}