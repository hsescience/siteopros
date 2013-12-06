using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hofstede_s_dimensions_analysier
{
    public partial class AboutProject : System.Web.UI.Page
    {
        int user_id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] suser_id = Request.QueryString.GetValues("user_id");
            user_id = int.Parse(suser_id[0]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test.aspx?user_id=" + user_id, false);
        }
    }
}