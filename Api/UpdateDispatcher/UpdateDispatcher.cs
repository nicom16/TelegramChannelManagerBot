using Api.Telegram;
using Microsoft.AspNetCore.Mvc;

namespace Api.UpdateDispatcher;

public class UpdateDispatcher : IUpdateDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public UpdateDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task<IActionResult> DispatchAsync(Update update)
    {
        throw new NotImplementedException();
    }
}