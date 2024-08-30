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
        var kanyeObject = ResponseDeserializer.DeserializeKanye(kanyeRequest);
        Console.WriteLine($"Kanye says: {kanyeObject.Quote}");
    }

    public async Task ViewRonQuote()
    {
        var ronRequest = await _quoteService.RonRequest();
        var ronObject = ResponseDeserializer.DeserializeRon(ronRequest);
        Console.WriteLine($"Ron says: {ronObject[0]}");
    }

    public async Task ViewRonKanyeConvo()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"--------- Part {i}: ----------");
            await ViewKanyeQuote();
            await ViewRonQuote();
            Console.WriteLine();
        }
    }
    
}