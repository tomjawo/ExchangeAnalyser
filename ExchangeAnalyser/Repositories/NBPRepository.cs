using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExchangeAnalyser.Models;
using RestSharp;

namespace ExchangeAnalyser.Repositories
{
    public class NBPRepository : ICurrencyRepository
    {
        RestClient client;

        public NBPRepository(string ApiAdress = "http://api.nbp.pl/api/")
        {
            this.client = new RestClient(ApiAdress);
        }

        public CurrencyData GetData(string CurrencyCode, DateTime StartDate, DateTime EndDate)
        {
            RestRequest request = new RestRequest($"exchangerates/rates/a/{CurrencyCode}/{StartDate.ToString("yyyy-MM-dd")}/{EndDate.ToString("yyyy-MM-dd")}", Method.GET);
            request.AddHeader("header", "Accept: application/json");
            IRestResponse<CurrencyData> response = client.Execute<CurrencyData>(request);
            return response.Data;
        }
    }
}