namespace Application.Commands.Common;

public abstract record CommandBase<TResult> : ICommand<TResult> where TResult : class
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime CreatedAt { get; init; } = DateTime.Now;
}