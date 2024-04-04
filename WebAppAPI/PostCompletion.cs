using System.Text;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using HttpClient = System.Net.Http.HttpClient;

namespace TheStreets.Prototype;
/// <summary>
/// This code creates a POST request to Big Ounce (Claude-3-Sonnet)
/// through the CodeGPT completions endpoint.
/// </summary>
public class PostCompletionRequest
{
    private readonly static string CODEGPT_API_KEY = "";
    private readonly static string CODEGPT_ORG_ID = "";

    static void Start(string[] args)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage();
        request.RequestUri = new Uri("api-beta.codegpt.co/api/v1/chat/completions");
        request.Method = HttpMethod.Post;

        request.Headers.Add("Accept", "application/json");
        request.Headers.Add("Codegpt-Org-Id", "");
        request.Headers.Add("Authorization", "Bearer CODEGPT_API_KEY");

        var bodyString = "{ \"agentId\": \"bbd0fee3-e52d-4fee-a284-0b64f8b9e01e\", \"messages\": [ { \"content\": \"whats crackin, homie? it's a lil http request right here\", \"role\": \"user\" } ], \"format\": \"json\", \"stream\": false}";
        var content = new StringContent(bodyString, Encoding.UTF8, "application/json");
        request.Content = content;

        //TODO: fix this shit
        // var response = await client.SendAsync(request);
        // var result = await response.Content.ReadAsStringAsync();
        // Console.WriteLine(result);
    }
}
