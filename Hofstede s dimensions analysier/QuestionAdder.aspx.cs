using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
 * CREATE TABLE Question (
ID INTEGER NOT NULL,
Type INTEGER NOT NULL,
Description CHAR(275),
Question CHAR(200),
Answers CHAR (200),
StatusID INTEGER NOT NULL)
 */


namespace Hofstede_s_dimensions_analysier
{
    public partial class QuestionAdder : System.Web.UI.Page
    {
        int topID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "SELECT TOP 1 ID FROM Question ORDER BY ID DESC";
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
            SqlDataSource1.InsertCommand = "INSERT INTO Question VALUES (" + HttpUtility.UrlEncode(topID.ToString(), Encoding.ASCII) + ", " + HttpUtility.UrlEncode(CheckBoxList1.SelectedIndex.ToString(), Encoding.UTF8) + ", '" + HttpUtility.UrlEncode(TextBox1.Text, Encoding.UTF8) + "', '" + HttpUtility.UrlEncode(TextBox2.Text, Encoding.UTF8) + "', '" + HttpUtility.UrlEncode(TextBox3.Text, Encoding.UTF8) + "', '" + HttpUtility.UrlEncode(TextBox4.Text, Encoding.UTF8) + "')";

            try
            {
                SqlDataSource1.Insert();
                SqlDataSource1.SelectCommand = "SELECT Description FROM Question WHERE id=10";
                dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                //Encoding Code = Encoding.GetEncoding("windows-1251");
                //Encoding Code = Encoding.GetEncoding("windows-1251");
                //byte[] srcBytes = Code.GetBytes(dv.Table.Rows[0][0].ToString());

                //MessageBox.Show(HttpUtility.UrlEncode("aagdsg+%d1%84%d0%b0%d1%8b%d1%84%d0%b0%d1%84", Encoding.));

                //byte[] srcBytes = Code.GetBytes("aagdsg+%d1%84%d0%b0%d1%8b%d1%84%d0%b0%d1%84");
                //String Text1 = Code.GetString(srcBytes);
                String Text1 = dv.Table.Rows[0][0].ToString();
                Text1 = Uri.UnescapeDataString(Text1);
                MessageBox.Show(Text1);
            }
            catch (Exception ex)
            {
                //StreamWriter sr=new StreamWriter("aagdsg+%d1%84%d0%b0%d1%8b%d1%84%d0%b0%d1%84",true,System.Text.Encoding.GetEncoding(866));


                MessageBox.Show(ex.Message);
            }

        }
    }
}