namespace Application.Commands.Common;

public interface ICommand<TResult> where TResult : class
{
    Guid Id { get; init; }
    DateTime CreatedAt { get; init; }
}