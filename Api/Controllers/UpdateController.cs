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
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}