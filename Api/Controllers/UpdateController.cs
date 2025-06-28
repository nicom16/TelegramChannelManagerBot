using Api.ActionCommands;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
public class UpdateController : Controller
{
    [HttpPost]
    public IActionResult Handle(string token, [FromBody] Update update)
    {
        try
        {
            // TODO: handle token validation here or with middleware?
            IActionCommand command = GetCommand(token, update);
            command.Execute();
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    private IActionCommand GetCommand(string token, Update update) => update switch
    {
        { Message.Photo: not null } => new StorePhotoCommand(token, update.Message),
        _ => throw new NotImplementedException()
    };
}