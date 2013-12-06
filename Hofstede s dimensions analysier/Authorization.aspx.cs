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
            int statusID = DropDownList1.SelectedIndex; //статус относительно Вышки
            string branch = DropDownList2.SelectedItem.Text; //филиал
            string faculty = DropDownList4.SelectedItem.Text; //факультет
            string homeland = DropDownList5.SelectedItem.Text; //родная страна
            string residence = DropDownList6.SelectedItem.Text; //страна проживания


            if (CheckBox1.Checked==true)
            {
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
}