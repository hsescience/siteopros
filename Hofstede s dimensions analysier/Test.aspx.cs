using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

//Do not use Question with ID = 0!

namespace Hofstede_s_dimensions_analysier
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int user_id = 0;
        int total_questions = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] suser_id = Request.QueryString.GetValues("user_id");
            user_id = int.Parse(suser_id[0]);
            this.Session["currentQuestionNum"] = (int)this.Session["currentQuestionNum"] + 1;

            SqlDataSource1.SelectCommand = "SELECT COUNT(ID) FROM Question WHERE StatusID = (SELECT StatusID FROM Respondent WHERE ID = " + user_id + ")  OR StatusID = 0";
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            try
            {
                total_questions = (int)dv.Table.Rows[0][0];

                Label1.Text = "Тестирование. Вопрос " + (int)this.Session["currentQuestionNum"] + " из " + total_questions;
            }
            catch
            {
            }

            SqlDataSource1.SelectCommand = "SELECT TOP 1 * FROM Question WHERE ID > " + this.Session["currentQuestionNumInDB"] + " ORDER BY ID";
            dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            try
            {
                TextBox1.Text = dv.Table.Rows[0][2].ToString();
                TextBox1.Text = Uri.UnescapeDataString(TextBox1.Text);
                TextBox2.Text = dv.Table.Rows[0][3].ToString();
                TextBox1.Text = Uri.UnescapeDataString(TextBox2.Text);
            }
            catch
            {
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}