using Application.Commands.Common;
using Application.Commands.PhotoToStore;
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
                if (update.Message.IsNewPhotoToStore())
                {
                    var command = new PhotoToStoreCommand<CommandResult>(update.Message.Photo.Id);
                    var handler = new PhotoToStoreCommandHandler();
                    var result = handler.Handle(command);
                    return Ok(result);
                }
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