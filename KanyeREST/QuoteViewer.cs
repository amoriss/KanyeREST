using System;
using System.Threading.Tasks;

namespace KanyeREST;

public class QuoteViewer
{
    private readonly QuoteService _quoteService;

    public QuoteViewer()
    {
        _quoteService = new QuoteService();
    }

    public async Task ViewKanyeQuote()
    {
        var kanyeRequest = await _quoteService.KanyeRequest();
        var kanyeObject = await _quoteService.DeserializeKanye(kanyeRequest);
        Console.WriteLine($"Kanye says: {kanyeObject.Quote}");
         }

    public async Task ViewRonQuote()
    {
        var ronRequest = await _quoteService.RonRequest();
        var ronObject = await _quoteService.DeserializeRon(ronRequest);
        Console.WriteLine($"Ron says: {ronObject[0]}");
    }

    public async Task RonKanyeConvo()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine();
            await ViewKanyeQuote();
            await ViewRonQuote();
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
        }
    }

}