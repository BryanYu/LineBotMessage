using LineBotMessageAPI.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace LineBotMessageAPI;

[ApiController]
[Route("api/[controller]")]
public class WebHookController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public WebHookController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost("receiveEvent")]
    public IActionResult ReceiveEvent([FromBody] ReceiveEventRequest request, [FromHeader(Name = "x-line-signature")] string signature)
    {
        return Ok();
    }
}