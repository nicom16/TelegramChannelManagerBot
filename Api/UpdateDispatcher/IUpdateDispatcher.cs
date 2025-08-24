using Api.Telegram;
using Microsoft.AspNetCore.Mvc;

namespace Api.UpdateDispatcher;

public interface IUpdateDispatcher
{
    Task<IActionResult> DispatchAsync(Update update);
}