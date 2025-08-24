using Api.Telegram;
using Application.Commands.Common;
using Application.ResultPatternImplementation;

namespace Api.UpdateDispatcher;

public interface IUpdateDispatcher
{
    Task<OperationResult> DispatchAsync(Update update);
}