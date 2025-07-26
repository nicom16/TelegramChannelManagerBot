namespace Application.Commands.Base;

public interface ICommand
{
    Guid Id { get; init; }
    DateTime CreatedAt { get; init; }
}