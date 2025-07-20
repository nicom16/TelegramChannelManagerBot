namespace Application.Commands;

public abstract class CommandBase : ICommand
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; }

    public CommandBase()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;    
    }
}