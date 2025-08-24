using Api.Telegram;
using Api.UpdateDispatcher;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
public class UpdateController : Controller
{
    private readonly IUpdateDispatcher _updateDispatcher;
    
    public UpdateController(IUpdateDispatcher updateDispatcher)
    {
        _updateDispatcher = updateDispatcher;
    }
    
    [HttpPost]
    public async Task<IActionResult> Handle(string token, [FromBody] Update update)
    {
        try
        {
            // TODO: token validation
            // TODO: update validation?
            
            return await _updateDispatcher.DispatchAsync(update);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}