using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
public class PostsController : Controller
{
    [HttpPost]
    public IActionResult StorePhoto([FromQuery] string token, [FromBody] Update update)
    {
        return Ok("Storing a photo...");
    }
}