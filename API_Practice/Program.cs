using Newtonsoft.Json.Linq;
using System;



var client = new HttpClient();



var kanyeURL = "https://api.kanye.rest/";


var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";





for (int i = 0; i < 5; i++)
{


    var ronResponse = client.GetStringAsync(ronSwansonURL).Result;


    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;


    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"',' ').Trim();
    string kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

    Console.WriteLine(ronQuote);

    Console.WriteLine(kanyeQuote);
}


