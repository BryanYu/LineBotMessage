using LineBotMessageAPI.ActionFilter;
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
    [ServiceFilter<ValidateSignature>]
    public IActionResult ReceiveEvent([FromBody] ReceiveEventRequest request)
    {
        return Ok();
    }
}