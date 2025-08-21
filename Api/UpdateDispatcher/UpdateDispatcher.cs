using Microsoft.AspNetCore.Mvc;
using Shared.Telegram;

namespace Api.UpdateDispatcher;

public class UpdateDispatcher : IUpdateDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public UpdateDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IActionResult Dispatch(Update update)
    {
        throw new NotImplementedException();
    }
}