using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Windows.Forms;

namespace Hofstede_s_dimensions_analysier
{
    public partial class Selection : System.Web.UI.Page
    {
        public static List<Country> countries = new List<Country>();

        private static bool stoper = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            prepareDefaultData();
            stoper = true;
            //DataResetButton.IsEnabled = false;
            //prepareDefaultData();
            //DataResetButton.IsEnabled = true; MessageBox.Show("Failed to get default recomendations. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
               
        }

        private void prepareDefaultData()
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
                    xlWorkBook = xlApp.Workbooks.Open(@"C:\ВШЭ\4 курс\Диплом\Hofstede's Dimensions Analysier\Hofstede's Dimensions Analysier\bin\Debug\Aldunin_dimensions_clasters.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get data about counties from Excel. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Label1.Text = "Data delivered!";
                //this.waitingLabel.Content = "Data is ready!";
                //progressBar1.Value = progressBar1.Maximum;
                //}));
                //}));

                //t.Start();
            }
        }

        private void releaseObject(object obj)
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

        protected void DataResetButton_Click(object sender, EventArgs e)
        {
            prepareDefaultData();
        }

        protected void Button2_Click(object sender, EventArgs e)
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
                Response.Redirect("http://localhost:51087/Recomendations_form.aspx?PDI_mark=" + PDI_mark.Text + "&IDV_mark=" + IDV_mark.Text + "&MAS_mark=" + MAS_mark.Text + "&UAI_mark=" + UAI_mark.Text + "&LTO_mark=" + LTO_mark.Text + "&IVR_mark=" + IVR_mark.Text + "&Country=" + DropDownList1.SelectedValue.ToString(), false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect ranks input. Ranks should be non-negative double.\n" + ex.Message, "Fix it and try again, please!");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get country's ranks. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error");
            }
        }
    }
}