using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KanyeREST.Models;
using Newtonsoft.Json;

namespace KanyeREST
{
    public class QuoteService
    {
        private HttpClient _client = new();
        private readonly string _kanyeUrl = "https://api.kanye.rest";
        private readonly string _ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        public async Task<string> KanyeRequest()
        {
            try
            {
                var kanyeResponse = await _client.GetStringAsync(_kanyeUrl);
                return kanyeResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<string> RonRequest()
        {
            try
            {
                var ronResponse = await _client.GetStringAsync(_ronUrl);
                return ronResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}