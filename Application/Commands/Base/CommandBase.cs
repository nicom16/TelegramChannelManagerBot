namespace Application.Commands.Base;

public abstract record CommandBase : ICommand
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime CreatedAt { get; init; } = DateTime.Now;
}