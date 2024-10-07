using LineBotMessageAPI.ActionFilter;
using LineBotMessageAPI.Infrastructure;
using LineBotMessageAPI.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace LineBotMessageAPI;

[ApiController]
[Route("api/[controller]")]
public class WebHookController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IProductionRepository _productionRepository;

    public WebHookController(IConfiguration configuration, IProductionRepository productionRepository)
    {
        _configuration = configuration;
        _productionRepository = productionRepository;
    }

    [HttpPost("receiveEvent")]
    [ServiceFilter<ValidateSignature>]
    public IActionResult ReceiveEvent([FromBody] ReceiveEventRequest request)
    {
        return Ok();
    }
}