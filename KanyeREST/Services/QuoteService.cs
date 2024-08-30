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
        private HttpClient _client;

        public QuoteService()
        {
            _client = new HttpClient();
        }

        public async Task<string> KanyeRequest()
        {
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = await _client.GetStringAsync(kanyeURL);
            return kanyeResponse;
        }

        public async Task<string> RonRequest()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = await _client.GetStringAsync(ronURL);
            return ronResponse;
        }
    }
}