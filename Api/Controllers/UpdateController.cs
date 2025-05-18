using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class UpdateController : Controller
{
    [HttpPost("update")]
    public IActionResult Handle(Update update)
    {
        string path = GetRedirectPath(update);
        return Redirect(path);
    }

    private string GetRedirectPath(Update update) => update switch
    {
        { Message: { }, Message.Photo: { }  } => "storePhoto",
        _ => throw new NotImplementedException()
    };
}