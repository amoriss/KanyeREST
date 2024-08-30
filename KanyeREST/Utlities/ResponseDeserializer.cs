using System.Collections.Generic;
using KanyeREST.Models;
using Newtonsoft.Json;

namespace KanyeREST;

public static class ResponseDeserializer
{
    public static Kanye DeserializeKanye(string kanyeResponse)
    {
        return JsonConvert.DeserializeObject<Kanye>(kanyeResponse);
    }

    public static List<string> DeserializeRon(string ronResponse)
    {
        return JsonConvert.DeserializeObject<List<string>>(ronResponse);
    }
}