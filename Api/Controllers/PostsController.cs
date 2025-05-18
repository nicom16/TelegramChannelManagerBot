using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class PostsController : Controller
{
    [HttpGet("storePhoto")]
    public IActionResult StorePhoto()
    {
        return Ok("Storing a photo...");
    }
}