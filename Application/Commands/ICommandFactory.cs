using Shared.Telegram;

namespace Application.Commands;

public interface ICommandFactory
{
    ICommand Create(Message message);
}