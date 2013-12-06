using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hofstede_s_dimensions_analysier
{
    public class Country //Class contains description of country
    {
        string name;            //country name
        public string _name     
        {
            get { return name; }
        }

        double[] ranks = new double[6];//array of countries' Hofstede's ranks (PDI, IDV, MAS, UAI, LTO, IVR)
        public double[] _ranks
        {
            get { return ranks; }
        }

        public Country(string name, double pdi, double idv, double mas, double uai, double lto, double ivr)
        {
            this.name = name;
            this.ranks =  new double [] {pdi, idv, mas, uai, lto, ivr};
        }
    }
}
