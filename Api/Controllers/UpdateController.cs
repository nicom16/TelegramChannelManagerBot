using Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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
            return RedirectRequest(token, update);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    private IActionResult RedirectRequest(string token, Update update) => update switch
    {
        { Message: not null, Message.Photo: not null } => RedirectToAction($"{token}/Posts/StorePhoto", new { update }),
        _ => throw new NotImplementedException()
    };
}