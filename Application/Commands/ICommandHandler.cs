namespace Application.Commands;

public interface ICommandHandler
{
    Task Handle(ICommand command);
}