using Microsoft.AspNetCore.Mvc;

namespace IE_Quiz1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMessage()
    {
        return Ok(new { message = "Hello from IE_Quiz1 API", timestamp = DateTime.UtcNow });
    }

    [HttpGet("status")]
    public IActionResult Status()
    {
        return Ok(new { status = "OK", uptime = DateTime.UtcNow });
    }
}