using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Hofstede_s_dimensions_analysier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int topID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int statusID = int.Parse(Request.Form["status"]); //статус относительно Вышки
            string branch = Request.Form["filial"]; //филиал
            string faculty = Request.Form["faculty"]; ; //факультет
            string homeland = Request.Form["countrybr"]; ; //родная страна
            string residence = Request.Form["countryliv"]; //страна проживания


          
                SqlDataSource1.SelectCommand = "SELECT TOP 1 ID FROM Respondent ORDER BY ID DESC";
                DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                try
                {
                    topID = (int)dv.Table.Rows[0][0];
                    topID++;
                }
                catch
                {
                    topID = 0;
                }
                SqlDataSource1.InsertCommand = "INSERT INTO Respondent VALUES (" + topID + ", " + statusID + ", '" + branch + "', '" + faculty + "', '" + homeland + "', '" + residence + "')";
                SqlDataSource1.Insert();


                Response.Redirect("AboutProject.aspx?user_id=" + topID, false);
            

        }
    }
}