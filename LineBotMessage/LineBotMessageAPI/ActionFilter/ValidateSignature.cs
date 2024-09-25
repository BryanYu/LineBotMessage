using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LineBotMessageAPI.ActionFilter;

public class ValidateSignature : IAsyncActionFilter 
{
    private readonly IConfiguration _configuration;

    public ValidateSignature(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    { 
        var request = context.HttpContext.Request;
        request.Body.Position = 0;
        var signature = context.HttpContext.Request.Headers["x-line-signature"].ToString();
        var secret = _configuration.GetValue<string>("Line:MessageAPI:ChannelSecret");
        if (string.IsNullOrEmpty(signature))
        {
            context.Result = new BadRequestResult();
            return; 
        }
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
        using var reader = new StreamReader(request.Body, Encoding.UTF8, false, 1024, true);
        var requestBody = await reader.ReadToEndAsync();
        var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(requestBody));
        request.Body.Position = 0;
        var contentHash = Convert.ToBase64String(computeHash);
        if (contentHash != signature)
        {
            context.Result = new BadRequestResult();
            return;
        }
    }
}