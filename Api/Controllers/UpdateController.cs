using Api.Helpers;
using Api.Models;
using Application.Commands;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
public class UpdateController : Controller
{
    private readonly ICommandFactory _commandFactory;
    private readonly ICommandHandlerFactory _commandHandlerFactory;
    private readonly IQueryFactory _queryFactory;
    private readonly IQueryHandlerFactory _queryHandlerFactory;

    public UpdateController(
        ICommandFactory commandFactory, 
        ICommandHandlerFactory commandHandlerFactory, 
        IQueryFactory queryFactory, 
        IQueryHandlerFactory queryHandlerFactory)
    {
        _commandFactory = commandFactory;
        _commandHandlerFactory = commandHandlerFactory;
        _queryFactory = queryFactory;
        _queryHandlerFactory = queryHandlerFactory;
    }
    
    [HttpPost]
    public IActionResult Handle(string token, [FromBody] Update update)
    {
        try
        {
            // TODO: token validation
            // TODO: update validation?
            
            if (update.Message.IsCommand())
            {
                // TODO
            }
            else if (update.Message.IsQuery())
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