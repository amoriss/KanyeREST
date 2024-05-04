using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            var quoteService = new QuoteService();
            for (int i = 0; i < 5; i++)
            {
                quoteService.KanyeQuote();
                quoteService.RonQuote();
            }
        }
    }
}