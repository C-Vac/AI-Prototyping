using System.Text;
using TheStreets.Prototype.Controllers;

var builder = WebApplication.CreateBuilder(args);

const string CODEGPT_API_KEY = "";
const string CODEGPT_ORG_ID = "";
// TODO: add environment variable injection

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddScoped<CodeGPTService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Define a minimal API endpoint as an example
app.MapPost("/chat", async (ChatMessage chatMessage, CodeGPTService codeGPTService) =>
{
    // Use the CodeGPTService to send the message to CodeGPT and get a response
    var response = await codeGPTService.SendMessageToCodeGPTAsync(chatMessage.Content);
    return response; // This will return the response from CodeGPT
});

// This is the script that ran successfully in Thunder Client
// I have no idea how the other one works, this one is good for now
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

    //TODO: 
    var response = await client.SendAsync(request);
    var result = await response.Content.ReadAsStringAsync();
    Console.WriteLine(result);
}
app.Run();
