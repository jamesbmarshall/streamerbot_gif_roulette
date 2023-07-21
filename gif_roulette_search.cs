using System;
using System.Net;
using Newtonsoft.Json.Linq;

public class CPHInline
{
	public bool Execute()
	{
		
	string searchTerm = args["rawInput"].ToString();
	
	using (var webClient = new WebClient())
            {
                var jsonStr = webClient.DownloadString($"https://api.giphy.com/v1/gifs/search?api_key=YOUR_API_KEY&q={searchTerm}&limit=1&rating=pg13");

                // Parse the JSON response.
                var json = JObject.Parse(jsonStr);

                // Extract the URL property.
                var url = (string)json["data"][0]["embed_url"];
                CPH.SetGlobalVar("gifurl", url, false);
            }
		return true;
	}
}
