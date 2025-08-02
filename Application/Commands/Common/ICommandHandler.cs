namespace Application.Commands.Common;

public interface ICommandHandler<TCommand, TResult> 
    where TCommand : ICommand<TResult> where TResult : class
{
    Task Handle(TCommand command);
}