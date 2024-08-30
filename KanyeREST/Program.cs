using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace KanyeREST
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            var quoteService = new QuoteViewer();
            await quoteService.ViewRonKanyeConvo();
         
        }
    }
}