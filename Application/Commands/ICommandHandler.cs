using Application.Commands.Base;

namespace Application.Commands;

public interface ICommandHandler
{
    Task Handle(ICommand command);
}