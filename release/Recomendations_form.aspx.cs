using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;

namespace Hofstede_s_dimensions_analysier
{
    public partial class Recomendations_form : System.Web.UI.Page
    {

        public static string[, , , , ,] hypercube;
        int[] recomendationCode = new int[] { -100 }; //code of recomendation, which should be taken from hypercube, as an array
        string strRecomendationCode = ""; //code of recomendation, which should be taken from hypercube, as a string
        bool[] missingRanks = new bool[] { false }; //array containing information about, which ranks are provided (taken from previous form)
        string country = ""; //selected country
        static double PDI_mark = 0;
        static double IDV_mark = 0;
        static double MAS_mark = 0;
        static double UAI_mark = 0;
        static double LTO_mark = 0;
        static double IVR_mark = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string [] sPDI = Request.QueryString.GetValues("PDI_mark");
            PDI_mark = double.Parse(sPDI[0]);
            string[] sIDV = Request.QueryString.GetValues("IDV_mark");
            IDV_mark = double.Parse(sIDV[0]);
            string[] sMAS = Request.QueryString.GetValues("MAS_mark");
            MAS_mark = double.Parse(sMAS[0]);
            string[] sUAI = Request.QueryString.GetValues("UAI_mark");
            UAI_mark = double.Parse(sUAI[0]);
            string[] sLTO = Request.QueryString.GetValues("LTO_mark");
            LTO_mark = double.Parse(sLTO[0]);
            string[] sIVR = Request.QueryString.GetValues("IVR_mark");
            IVR_mark = double.Parse(sIVR[0]);
            try
            {
                string[] temoCountry = Request.QueryString.GetValues("Country");
                country = temoCountry[0];
            }
            catch (Exception ex)
            {
                country = "No country selected";
            }

            List<Recomendation> listOfDefaultRecomendations = null;
            //preparing recomendations
            try
            {
                listOfDefaultRecomendations = new List<Recomendation>();
                listOfDefaultRecomendations = Recomendation.SetToDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get default recomendations. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Constructing hypercube with default recomendations
            try
            {
                hypercube = Recomendation.transformToCube(listOfDefaultRecomendations);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to construct hypercube. Please, contact administrator (mailto: redrickshuhart@2ch.hk), providing following information: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //===================
            //creating etalon dimensions
            Dimension PDI = Dimension.PDI();
            Dimension IDV = Dimension.IDV();
            Dimension MAS = Dimension.MAS();
            Dimension UAI = Dimension.UAI();
            Dimension LTO = Dimension.LTO();
            Dimension IVR = Dimension.IVR();

            //creating code of dimension by comparing inputed ranks with etalon ones
            recomendationCode = new int[Recomendation.numberOfDimensions];
            for (int i = 0; i < Recomendation.numberOfDimensions; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < PDI._levels.Count; j++)
                        {
                            if (PDI_mark < PDI._levels[j])
                            {
                                recomendationCode[0] = j;
                                break;
                            }
                        }
                        break;
                    case 1:
                        for (int j = 0; j < IDV._levels.Count; j++)
                        {
                            if (IDV_mark < IDV._levels[j])
                            {
                                recomendationCode[1] = j;
                                break;
                            }
                        }
                        break;
                    case 2:
                        for (int j = 0; j < MAS._levels.Count; j++)
                        {
                            if (MAS_mark < MAS._levels[j])
                            {
                                recomendationCode[2] = j;
                                break;
                            }
                        }
                        break;
                    case 3:
                        for (int j = 0; j < UAI._levels.Count; j++)
                        {
                            if (UAI_mark < UAI._levels[j])
                            {
                                recomendationCode[3] = j;
                                break;
                            }
                        }
                        break;
                    case 4:
                        for (int j = 0; j < LTO._levels.Count; j++)
                        {
                            if (LTO_mark < LTO._levels[j])
                            {
                                recomendationCode[4] = j;
                                break;
                            }
                        }
                        break;
                    case 5:
                        for (int j = 0; j < IVR._levels.Count; j++)
                        {
                            if (IVR_mark < IVR._levels[j])
                            {
                                recomendationCode[5] = j;
                                break;
                            }
                        }
                        break;
                }
            }

            //checking missing ranks
            missingRanks = new bool[Recomendation.numberOfDimensions];
            for (int j = 0; j < Recomendation.numberOfDimensions; j++)
                missingRanks[j] = false;

            if (PDI_mark < 0)
                missingRanks[0] = true;
            if (IDV_mark < 0)
                missingRanks[1] = true;
            if (MAS_mark < 0)
                missingRanks[2] = true;
            if (UAI_mark < 0)
                missingRanks[3] = true;
            if (LTO_mark < 0)
                missingRanks[4] = true;
            if (IVR_mark < 0)
                missingRanks[5] = true;

            //transmitting recommendation code to string
            foreach (int i in recomendationCode)
                strRecomendationCode += i;

            //getting recomendations for this recomendation code
            List<string> recomendationString = Tools.hypercubeCellParser(recomendationCode, hypercube, missingRanks); //getting strings of recomendation

            for (int i = 0; i < recomendationString.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        this.TextBox1.Text = recomendationString[i];
                        break;

                    case 1:
                        this.TextBox2.Text = recomendationString[i];
                        break;

                    case 2:
                        this.TextBox3.Text = recomendationString[i];
                        break;

                    case 3:
                        this.TextBox4.Text = recomendationString[i];
                        break;

                    case 4:
                        this.TextBox5.Text = recomendationString[i];
                        break;
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton1.Enabled = false;
            this.ImageButton2.Enabled = false;
            this.ImageButton2.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark,
            country, "Metaphors", true);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton1.Enabled = false;
            this.ImageButton2.Enabled = false;
            this.ImageButton1.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark,
            country, "Metaphors", false);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton3.Enabled = false;
            this.ImageButton4.Enabled = false;
            this.ImageButton4.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark,
            country, "Mental models", true);
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton3.Enabled = false;
            this.ImageButton4.Enabled = false;
            this.ImageButton3.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark,
            country, "Mentals models", false);
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton5.Enabled = false;
            this.ImageButton6.Enabled = false;
            this.ImageButton6.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark,
            country, "Navigation", true);
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton5.Enabled = false;
            this.ImageButton6.Enabled = false;
            this.ImageButton5.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark, 
            country, "Navigation", false);
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton7.Enabled = false;
            this.ImageButton8.Enabled = false;
            this.ImageButton8.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark, 
            country, "Interaction", true);
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton7.Enabled = false;
            this.ImageButton8.Enabled = false;
            this.ImageButton7.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark, 
            country, "Interaction", false);
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton9.Enabled = false;
            this.ImageButton10.Enabled = false;
            this.ImageButton10.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark, 
            country, "Appearence", true);
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            this.ImageButton9.Enabled = false;
            this.ImageButton10.Enabled = false;
            this.ImageButton9.Visible = false;
            Tools.writeVote(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark, 
            country, "Appearence", false);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Tools.writeFeedback(strRecomendationCode.ToString(),
            PDI_mark,
            IDV_mark,
            MAS_mark,
            UAI_mark,
            LTO_mark,
            IVR_mark, 
            country, TextBox6.Text);
            Button12.Enabled = false;
            TextBox6.Text="Thanks for your feedback!";
            TextBox6.ReadOnly=true;
        }
    }
}