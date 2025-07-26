using Application.Commands.Base;
using Shared.Telegram;

namespace Application.Commands.Factory;

public interface ICommandFactory
{
    ICommand Create(Update update);
}