namespace Application.Commands;

public interface ICommand
{
    Guid Id { get; }
    DateTime CreatedAt { get; }
}