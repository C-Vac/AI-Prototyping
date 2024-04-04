using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheStreets.Prototype.Controllers;

// Service to interact with CodeGPT API
public class CodeGPTService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<string> SendMessageToCodeGPTAsync(string message)
    {
        var response = await _httpClient.PostAsJsonAsync("CodeGPT API URL", new { message = message });
        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
        else
        {
            // Handle non-success status codes appropriately
            return $"Error: {response.StatusCode}";
        }
    }
}

// Controller to handle incoming chat messages
[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly CodeGPTService _codeGPTService;

    public ChatController(CodeGPTService codeGPTService)
    {
        _codeGPTService = codeGPTService;
    }
    
    // POST api/chat
    [HttpPost]
    public async Task<IActionResult> PostMessage([FromBody] ChatMessage message)
    {
        var response = await _codeGPTService.SendMessageToCodeGPTAsync(message.Content);
        return Ok(response);
    }
}
public record ChatMessage
{
    public string User { get; set; }
    public string Content { get; set; }
    // Add additional properties as needed
}

public class ChatRequest
{
    public string DocumentContent { get; set; }
    public string Prompt { get; set; }
}
