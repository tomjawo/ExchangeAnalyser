using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeAnalyser.Models;

namespace ExchangeAnalyser.Repositories
{
    interface ICurrencyRepository
    {
        CurrencyData GetData(string CurrencyCode, DateTime StartDate, DateTime EndDate);
    }
}
