using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExchangeAnalyser.Models
{
    public class CurrencyData
    {
        public string Code { get; set; }
        public List<Rate> Rates { get; set; }
    }

    public class Rate
    {
        public string No { get; set; }
        public DateTime EffectiveDate { get; set; }
        public double Mid { get; set; }

    }

}