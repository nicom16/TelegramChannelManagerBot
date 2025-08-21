using Microsoft.AspNetCore.Mvc;
using Shared.Telegram;

namespace Api.UpdateDispatcher;

public interface IUpdateDispatcher
{
    IActionResult Dispatch(Update update);
}