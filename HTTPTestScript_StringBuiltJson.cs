using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class HTTPrequest
{
    public static bool SendRequest(string json, string url)
    {
        var http = PostAsync(json, url);
        if (http.Result == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static async Task<bool> PostAsync(string json, string url)
    {
        // Insert the URL generated by Power Automate here
        //var url = "https://prod-18.westeurope.logic.azure.com/workflows/97cf66200f4b422e9813fb3160542b7d/triggers/manual/paths/invoke/SendRevitMail?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=VOrg9ugiBY8TBVyiYd04sY0InLdtLsdI0yiRmB7PJcQ";
        // Declare the client
        var client = new HttpClient();

        // This is a test API key, change the characters to your own 36 character alphanumeric string
        client.DefaultRequestHeaders.Add("X-API-Key", "testkey");

        StringContent jsonContent = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            // Sends the HTTP Request and waits for a response to limit threading issues
            HttpResponseMessage response = client.PostAsync(url, jsonContent).Result;


            // Checks if the request was successful
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (Exception e)
        {
            //await Console.Out.WriteLineAsync(e.Message);
            return false;
        }
    }

}