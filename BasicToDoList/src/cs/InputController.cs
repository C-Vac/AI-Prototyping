using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace TheStreets;

// Controller for handling Goblin's text input
[ApiController]
[Route("[controller]")]
public class InputController : ControllerBase
{
    private readonly Backend backend;

    public InputController(Backend backend)
    {
        this.backend = backend;
    }

    [HttpPost]
    public IActionResult ReceiveInput([FromBody] string inputText)
    {
        backend.StateMachine.TriggerState(inputText);
        return Ok("Input received, processing...");
    }
}
