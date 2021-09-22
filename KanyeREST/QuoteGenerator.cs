using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        { 
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeReponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeReponse).GetValue("quote").ToString();
            Console.WriteLine("------------------");
            Console.WriteLine($"Kanye Says: '{kanyeQuote}'");
            Console.WriteLine("------------------");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine("------------------");
            Console.WriteLine($"Ron Responds: '{ronQuote}'");
            Console.WriteLine("------------------");
        }


    }
}
