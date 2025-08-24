using Api.Telegram;
using Api.UpdateDispatcher;
using Application.Commands.Common;
using Application.ResultPatternImplementation;
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
            
            OperationResult operationResult = await _updateDispatcher.DispatchAsync(update);    
            if (!operationResult.IsSuccess)
                return BadRequest(operationResult.Message);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}