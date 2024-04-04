using TheStreets.Prototype.Controllers;

var builder = WebApplication.CreateBuilder(args);

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


app.Run();
