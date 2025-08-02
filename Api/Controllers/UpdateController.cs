using Application.UpdateAnalyzer;
using Microsoft.AspNetCore.Mvc;
using Shared.Telegram;

namespace Api.Controllers;

[Controller]
public class UpdateController : Controller
{
    public UpdateController()
    {
        // TODO
    }
    
    [HttpPost]
    public IActionResult Handle(string token, [FromBody] Update update)
    {
        try
        {
            // TODO: token validation
            // TODO: update validation?
            
            if (update.IsCommand())
            {
                // TODO
            }
            else if (update.IsQuery())
            {
                // TODO
            }
            
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}