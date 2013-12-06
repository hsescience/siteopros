using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hofstede_s_dimensions_analysier
{
    public class Dimension
    {
        private string name_ru;
        public string _name_ru
        {
            get { return name_ru; }
        }

        private string name_en;
        public string _name_en
        {
            get { return name_en; }
        }

        private string name_short;
        public string _name_short
        {
            get { return name_short; }
        }

        private List<double> levels; //top boders for levels (now 3 levels)
        public List<double> _levels
        {
            get { return levels; }
        }

        public Dimension(string name_ru, string name_en, string name_short, List<double> levels)
        {
            this.name_ru = name_ru;
            this.name_en = name_en;
            this.name_short = name_short;
            this.levels = levels;
        }

        public static Dimension PDI()
        {
            List<double> l = new List<double>(new double[] { 48.22916667, 74.65277778, 104 }); //CARE! >100!
            Dimension PDI = new Dimension("Дистанцированность от власти", "Power Distance", "PDI", l);
            return PDI;
        }

        public static Dimension IDV()
        {
            List<double> l = new List<double>(new double[] { 29.73426573, 56.20606061, 100 });
            Dimension PDI = new Dimension("Сплочённость или обособленность", "Collectivism vs Individualism", "IDV", l);
            return PDI;
        }

        public static Dimension MAS()
        {
            List<double> l = new List<double>(new double[] { 30.89066339, 55.99369369, 110 });
            Dimension PDI = new Dimension("Мужественность или женственность", "Masculinity vs Femininity", "MAS", l);
            return PDI;
        }

        public static Dimension UAI()
        {
            List<double> l = new List<double>(new double[] { 43.234375, 73.47723214, 112 }); //CARE! >100
            Dimension PDI = new Dimension("Избегание неопределённости", "Uncertainty Avoidance", "UAI", l);
            return PDI;
        }

        public static Dimension LTO()
        {
            List<double> l = new List<double>(new double[] { 29.92504686, 56.58563749, 100 });
            Dimension PDI = new Dimension("Долгосрочное или краткосрочное планирование", "Long-term vs. Short-term orientation", "LTO", l);
            return PDI;
        }

        public static Dimension IVR()
        {
            List<double> l = new List<double>(new double[] { 32.8765374, 59.01203978, 100 });
            Dimension PDI = new Dimension("Снисхождение к слабостям или сдержанность", "Indulgence versus Restraint", "IVR", l);
            return PDI;
        }
    }
}
