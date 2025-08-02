namespace Application.Commands.Common;

public record CommandResult(string Message)
{
    public string Message { get; init; } = Message;
    private bool Success { get; init; } = string.IsNullOrEmpty(Message);
};