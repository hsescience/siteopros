using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hofstede_s_dimensions_analysier
{
    public partial class landing_v2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Selection.aspx", false);
            //Server.Transfer("Selection.aspx", false);
        }      
    }
}