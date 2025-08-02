using Application.Commands.Common;

namespace Application.Commands;

public record PhotoToStoreCommand(int PhotoId) : CommandBase<CommandResult>
{
    int PhotoId { get; init; } = PhotoId;
}