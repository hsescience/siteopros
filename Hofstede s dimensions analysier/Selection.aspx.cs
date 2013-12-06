using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Hofstede_s_dimensions_analysier
{
    public partial class Selection : System.Web.UI.Page
    {
        public static List<Country> countries = new List<Country>();        //list of countries, will be filled from .CSV
        
        private static bool stoper = false;
        private static DataSet ds = null;
        //private static bool arrow1state = true;
        //private static bool arrow2state = false;
        //private static bool arrow3state = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            //prepareDefaultData();
            stoper = true;
            //arrowsCheck(arrow1state, arrow2state, arrow3state);
            //DataResetButton.IsEnabled = false;
            //prepareDefaultData();
            //DataResetButton.IsEnabled = true; MessageBox.Show("Failed to get default recomendations. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
               
        }

        private void arrowsCheck(bool a1s, bool a2s, bool a3s)      //method checking states of arrows on Selection form
        {
            this.FindControl("arrow1").Visible = (bool)this.Session["arrow1state"];
            this.FindControl("label10").Visible = (bool)this.Session["arrow1state"];
            this.FindControl("label11").Visible = (bool)this.Session["arrow2state"];
            this.FindControl("arrow2").Visible = (bool)this.Session["arrow2state"];
            this.FindControl("arrow3").Visible = (bool)this.Session["arrow3state"];
            this.FindControl("label12").Visible = (bool)this.Session["arrow3state"];
        }

        private void prepareDefaultDataCSV() //method reading .CSV source using IOstream (IN USE)
        {
            try
            {
                countries = new List<Country>();
                string name = "";
                double pdi = 0,
                        idv = 0,
                        mas = 0,
                        uai = 0,
                        lto = 0,
                        ivr = 0;
                string path = HttpContext.Current.Server.MapPath(@"~/docs/Aldunin_dimensions_clasters.csv");    //path to .CSV - data source
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string line = file.ReadLine(); //missing 1st line
                while ((line = file.ReadLine()) != null)
                {
                    string[] cells = line.Split(';');

                    for (int i = 0; i < cells.Length; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                name = cells[i];
                                break;
                            case 2:
                                try
                                {
                                    pdi = double.Parse(cells[i]);
                                }
                                catch
                                {
                                    pdi = -1;
                                }
                                break;
                            case 3:
                                try
                                {
                                    idv = double.Parse(cells[i]);
                                }
                                catch
                                {
                                    idv = -1;
                                }
                                break;
                            case 4:
                                try
                                {
                                    mas = double.Parse(cells[i]);
                                }
                                catch
                                {
                                    mas = -1;
                                }
                                break;
                            case 5:
                                try
                                {
                                    uai = double.Parse(cells[i]);
                                }
                                catch
                                {
                                    uai = -1;
                                }
                                break;
                            case 6:
                                try
                                {
                                    lto = double.Parse(cells[i]);
                                }
                                catch
                                {
                                    lto = -1;
                                }
                                break;
                            case 7:
                                try
                                {
                                    ivr = double.Parse(cells[i]);
                                }
                                catch
                                {
                                    ivr = -1;
                                }
                                break;
                        }
                    }
                        Country c = new Country(name, pdi, idv, mas, uai, lto, ivr);
                        countries.Add(c);
                }

                file.Close();
                this.DropDownList1.AutoPostBack = true;
                this.DropDownList1.Items.Clear();

                foreach (Country country in countries)
                {
                    this.DropDownList1.Items.Add(country._name);
                }

                Label1.Text = "Data delivered!";
                this.Session["arrow1state"] = false;
                this.Session["arrow2state"] = true;
                this.Session["arrow3state"] = false;
                arrowsCheck((bool)this.Session["arrow1state"], (bool)this.Session["arrow2state"], (bool)this.Session["arrow2state"]);
            }
            catch (Exception ex)
            {
                Response.Write(@"<script>alert('Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message.ToString().Substring(0, ex.Message.Length - 3) + "');</script>");
                Label1.Text = "Data delivery failed!";
            }
        }

        private void prepareDefaultDataOleDB() //method reading .CSV source using OleDB (NOT IN USE!)
        {
            if (!stoper)
            {
                try
                {Response.Write(@"<script>alert('1 Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    string name = "";
                    double pdi = 0,
                            idv = 0,
                            mas = 0,
                            uai = 0,
                            lto = 0,
                            ivr = 0;

                    string path = HttpContext.Current.Server.MapPath(@"~/docs/Aldunin_dimensions_clasters.xls");
                    string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
                    OleDbConnection conn = new OleDbConnection(strConn);
                    conn.Open();
                    Response.Write(@"<script>alert('2 Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                    Response.Write(@"<script>alert('2 " + path + " Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    Response.Write(@"<script>alert('3 Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                    string strExcel = "";
                    OleDbDataAdapter myCommand = null;
                    strExcel = "select * from [6 dimensions$]";
                    myCommand = new OleDbDataAdapter(strExcel, strConn);
                    ds = new DataSet();

                    Response.Write(@"<script>alert('2 " + path + " Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    try
                    {
                        myCommand.Fill(ds, "table");
                    }
                    catch (Exception ex)
                    {
                        Response.Write(@"<script>alert('TEST! Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    }

                    Response.Write(@"<script>alert('TEST1 " + ds.Tables["table"].Rows.Count + " " + ds.Tables["table"].Columns.Count + " (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    

                    for (int rCnt = 0; rCnt < ds.Tables["table"].Rows.Count; rCnt++)
                    {
                        Response.Write(@"<script>alert('TEST ROW Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                        for (int cCnt = 1; cCnt < ds.Tables["table"].Columns.Count; cCnt++)
                        {
                            Response.Write(@"<script>alert('TEST COLUMN Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                            switch (cCnt)
                            {
                                case 1:
                                    name = ds.Tables["table"].Rows[rCnt][cCnt].ToString();
                                    //name = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value2);
                                    Response.Write(@"<script>alert('TEST2 Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                                    break;
                                case 2:
                                    try
                                    {
                                        pdi = double.Parse(ds.Tables["table"].Rows[rCnt][cCnt].ToString());
                                    }
                                    catch
                                    {
                                        Response.Write(@"<script>alert('TEST3Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                                        pdi = -1;
                                    }
                                    break;
                                case 3:
                                    try
                                    {
                                        idv = double.Parse(ds.Tables["table"].Rows[rCnt][cCnt].ToString());
                                    }
                                    catch
                                    {
                                        idv = -1;
                                    }
                                    break;
                                case 4:
                                    try
                                    {
                                        mas = double.Parse(ds.Tables["table"].Rows[rCnt][cCnt].ToString());
                                    }
                                    catch
                                    {
                                        mas = -1;
                                    }
                                    break;
                                case 5:
                                    try
                                    {
                                        uai = double.Parse(ds.Tables["table"].Rows[rCnt][cCnt].ToString());
                                    }
                                    catch
                                    {
                                        uai = -1;
                                    }
                                    break;
                                case 6:
                                    try
                                    {
                                        lto = double.Parse(ds.Tables["table"].Rows[rCnt][cCnt].ToString());
                                    }
                                    catch
                                    {
                                        Response.Write(@"<script>alert('Test4 Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');</script>");
                    
                                        lto = -1;
                                    }
                                    break;
                                case 7:
                                    try
                                    {
                                        ivr = double.Parse(ds.Tables["table"].Rows[rCnt][cCnt].ToString());
                                    }
                                    catch
                                    {
                                        ivr = -1;
                                    }
                                    break;
                            }
                        }
                        Country c = new Country(name, pdi, idv, mas, uai, lto, ivr);
                        countries.Add(c);
                    }

                    Label1.Text = "Data delivered!";
                    this.Session["arrow1state"] = false;
                    this.Session["arrow2state"] = true;
                    this.Session["arrow3state"] = false;
                    arrowsCheck((bool)this.Session["arrow1state"], (bool)this.Session["arrow2state"], (bool)this.Session["arrow2state"]);
                }
                catch (Exception ex)
                {
                    Response.Write(@"<script>alert('Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message.ToString().Substring(0, ex.Message.Length - 3) + "');</script>");
                    Label1.Text = "Data delivery failed!";
                    //Response.Write("<script>alert('Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \\n" + ex.Message + "');</script>");
                    //Response.Write("<script>function window.onload() {  alert( 'Hi!');}</script>");
                    //Response.Write("<script>function window.onload() {  alert( 'Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');}</script>");
                    //MessageBox.Show("Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //filling listbox with countries
                //this.Dispatcher.Invoke(new ThreadStart(delegate
                //{
                this.DropDownList1.AutoPostBack = true;
                this.DropDownList1.Items.Clear();

                foreach (Country country in countries)
                {
                    this.DropDownList1.Items.Add(country._name);
                }

            }
        }

        private void prepareDefaultData() //method reading .CSV source using Excel driver (NOT IN USE!)
        {
            //Thread t = new Thread(new ThreadStart(delegate
            // {
            //Preparing countries
            if (!stoper)
            {
                try
                {
                    Label1.Text = "Waiting for data preparation...";
                    Recomendation.SetToDefault();

                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    Excel.Range range;

                    string name = "";
                    double pdi = 0,
                            idv = 0,
                            mas = 0,
                            uai = 0,
                            lto = 0,
                            ivr = 0;
                    int rCnt = 0;
                    int cCnt = 0;
                    xlApp = new Excel.Application();
                    
                    //string path = HttpContext.Current.Server.MapPath("~/docs/Aldunin_dimensions_clasters.xls"­);
                    //xlWorkBook = xlApp.Workbooks.Open(HttpContext.Current.Server.MapPath(@"~/docs/Aldunin_dimensions_clasters.xls"));//, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                    xlWorkBook = xlApp.Workbooks.Open(HttpContext.Current.Server.MapPath(@"~/docs/Aldunin_dimensions_clasters.xls"), 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    
                    //xlWorkBook = xlApp.Workbooks.Open(@"liti.somee.com/www.liti.somee.com/v4/docs/Aldunin_dimensions_clasters.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    range = xlWorkSheet.UsedRange;
                    double progressStep = range.Rows.Count / 20;
                    int progressStepCounter = 0;
                    for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
                    {
                        progressStepCounter++;
                        if (progressStep < progressStepCounter)
                        {
                            //this.Dispatcher.Invoke(new ThreadStart(delegate
                            //{
                            //    progressBar1.Value += 5;
                            //}));
                            //progressStepCounter = 0;
                        }

                        for (cCnt = 2; cCnt <= range.Columns.Count; cCnt++)
                        {
                            switch (cCnt)
                            {
                                case 2:
                                    name = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value2);
                                    break;
                                case 3:
                                    pdi = double.Parse(Convert.ToString(((range.Cells[rCnt, cCnt] as Excel.Range).Value2)));
                                    if (pdi < 0)
                                        pdi = -1;
                                    break;
                                case 4:
                                    idv = double.Parse(Convert.ToString(((range.Cells[rCnt, cCnt] as Excel.Range).Value2)));
                                    if (idv < 0)
                                        idv = -1;
                                    break;
                                case 5:
                                    mas = double.Parse(Convert.ToString(((range.Cells[rCnt, cCnt] as Excel.Range).Value2)));
                                    if (mas < 0)
                                        mas = -1;
                                    break;
                                case 6:
                                    uai = double.Parse(Convert.ToString(((range.Cells[rCnt, cCnt] as Excel.Range).Value2)));
                                    if (uai < 0)
                                        uai = -1;
                                    break;
                                case 7:
                                    lto = double.Parse(Convert.ToString(((range.Cells[rCnt, cCnt] as Excel.Range).Value2)));
                                    if (lto < 0)
                                        lto = -1;
                                    break;
                                case 8:
                                    ivr = double.Parse(Convert.ToString(((range.Cells[rCnt, cCnt] as Excel.Range).Value2)));
                                    if (ivr < 0)
                                        ivr = -1;
                                    break;
                            }
                        }
                        Country c = new Country(name, pdi, idv, mas, uai, lto, ivr);
                        countries.Add(c);
                    }
                    xlWorkBook.Close(true, null, null);
                    xlApp.Quit();
                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    Label1.Text = "Data delivered!";
                    this.Session["arrow1state"] = false;
                    this.Session["arrow2state"] = true;
                    this.Session["arrow3state"] = false;
                    arrowsCheck((bool)this.Session["arrow1state"], (bool)this.Session["arrow2state"], (bool)this.Session["arrow2state"]);
                }
                catch (Exception ex)
                {
                    Response.Write(@"<script>alert('Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message.ToString().Substring(0, ex.Message.Length - 3) + "');</script>");
                    Label1.Text = "Data delivery failed!";
                    //Response.Write("<script>alert('Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \\n" + ex.Message + "');</script>");
                    //Response.Write("<script>function window.onload() {  alert( 'Hi!');}</script>");
                    //Response.Write("<script>function window.onload() {  alert( 'Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n');}</script>");
                    //MessageBox.Show("Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //filling listbox with countries
                //this.Dispatcher.Invoke(new ThreadStart(delegate
                //{
                this.DropDownList1.AutoPostBack = true;
                this.DropDownList1.Items.Clear();

                foreach (Country country in countries)
                {
                    this.DropDownList1.Items.Add(country._name);
                }

                
                //this.waitingLabel.Content = "Data is ready!";
                //progressBar1.Value = progressBar1.Maximum;
                //}));
                //}));

                //t.Start();
            }
        }

        private void releaseObject(object obj) //method releasing objects after reading .CSV using Excel driver
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Sudden error. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \nUnable to release the Object " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        protected void DataResetButton_Click(object sender, EventArgs e) //method starting data loading from .CSV
        {
            stoper = false;
            prepareDefaultDataCSV();
        }

        protected void Button2_Click(object sender, EventArgs e) //method collecting filled data and sending it to the next form
        {
            //filling empty fields
            try
            {
                if (PDI_mark.Text == "")
                    PDI_mark.Text = "-1";
                if (IDV_mark.Text == "")
                    IDV_mark.Text = "-1";
                if (MAS_mark.Text == "")
                    MAS_mark.Text = "-1";
                if (UAI_mark.Text == "")
                    UAI_mark.Text = "-1";
                if (LTO_mark.Text == "")
                    LTO_mark.Text = "-1";
                if (IVR_mark.Text == "")
                    IVR_mark.Text = "-1";

                List<double> ranks = new List<double>(new double[] {double.Parse(PDI_mark.Text),
                                                                 double.Parse(IDV_mark.Text),
                                                                 double.Parse(MAS_mark.Text),
                                                                 double.Parse(UAI_mark.Text),
                                                                 double.Parse(LTO_mark.Text),
                                                                 double.Parse(IVR_mark.Text)});
                //Recomendation_window rw = new Recomendation_window(ranks, hypercube);
                //Server.Transfer("Recomendations_form.aspx?PDI_mark=" + PDI_mark.Text + "&IDV_mark=" + IDV_mark.Text + "&MAS_mark=" + MAS_mark.Text + "&UAI_mark=" + UAI_mark.Text + "&LTO_mark=" + LTO_mark.Text + "&IVR_mark=" + IVR_mark.Text + "&Country=" + DropDownList1.SelectedValue.ToString(), false);
                Response.Redirect("Recomendations_form.aspx?PDI_mark=" + PDI_mark.Text + "&IDV_mark=" + IDV_mark.Text + "&MAS_mark=" + MAS_mark.Text + "&UAI_mark=" + UAI_mark.Text + "&LTO_mark=" + LTO_mark.Text + "&IVR_mark=" + IVR_mark.Text + "&Country=" + DropDownList1.SelectedValue.ToString(), false);
                
                //Response.Redirect("http://localhost:51087/Recomendations_form.aspx?PDI_mark=" + PDI_mark.Text + "&IDV_mark=" + IDV_mark.Text + "&MAS_mark=" + MAS_mark.Text + "&UAI_mark=" + UAI_mark.Text + "&LTO_mark=" + LTO_mark.Text + "&IVR_mark=" + IVR_mark.Text + "&Country=" + DropDownList1.SelectedValue.ToString(), false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect ranks input. Ranks should be non-negative double.\n" + ex.Message, "Fix it and try again, please!");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) //method filling field with data for selected country
        {
            //filling ranks fields for country chosen
            try
            {
                foreach (Country country in countries)
                {
                    if (country._name == this.DropDownList1.SelectedItem.Value.ToString())
                    {
                        this.PDI_mark.Text = country._ranks[0].ToString();
                        this.IDV_mark.Text = country._ranks[1].ToString();
                        this.MAS_mark.Text = country._ranks[2].ToString();
                        this.UAI_mark.Text = country._ranks[3].ToString();
                        this.LTO_mark.Text = country._ranks[4].ToString();
                        this.IVR_mark.Text = country._ranks[5].ToString();
                    }
                }
                this.Session["arrow1state"] = false;
                this.Session["arrow2state"] = false;
                this.Session["arrow3state"] = true;
                arrowsCheck((bool)this.Session["arrow1state"], (bool)this.Session["arrow2state"], (bool)this.Session["arrow2state"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get country's ranks. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error");
            }
        }
    }
}