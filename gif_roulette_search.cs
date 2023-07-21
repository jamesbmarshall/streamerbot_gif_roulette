using System;
using System.Net;
using Newtonsoft.Json.Linq;

public class CPHInline
{
	public bool Execute()
	{
	// Get the search term from the stream, such as from a channel point redeem or chat command.
	string searchTerm = args["rawInput"].ToString();
	
	using (var webClient = new WebClient())
            {
		 // You'll need to get your own API key for GIPHY to use in the URL below. This will return a GIF using the random endpoint, of a PG13 rating. You can adjust as you require, see the
                // GIPHY docs for more details.
                var jsonStr = webClient.DownloadString($"https://api.giphy.com/v1/gifs/search?api_key=YOUR_API_KEY&q={searchTerm}&limit=1&rating=pg13");

                // Parse the JSON response.
                var json = JObject.Parse(jsonStr);

                // Extract the URL property.
                var url = (string)json["data"][0]["embed_url"];
		
		// Set a variable that you can use elsewhere in your action, such as to set the OBS browser source URL.
                CPH.SetGlobalVar("gifurl", url, false);
            }
		return true;
	}
}
