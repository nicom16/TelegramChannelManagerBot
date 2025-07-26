namespace Application.Commands;

public interface ICommandHandlerFactory
{
    ICommandHandler GetHandler(ICommand commandToHandle);
}