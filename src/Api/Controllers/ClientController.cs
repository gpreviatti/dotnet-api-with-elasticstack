using Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    [HttpPost]
    public IActionResult PostClient([FromBody] ClientViewModel client)
    {
        Serilog.Log.Information($"PostClient method called: {client.Name}");

        return Ok();
    }

    [HttpGet]
    public IActionResult GetClient([FromQuery] string name)
    {
        Serilog.Log.Information($"GetClient method called. With the parameter name={name}");

        return Ok();
    }
}
