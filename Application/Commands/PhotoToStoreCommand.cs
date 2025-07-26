using Application.Commands.Base;

namespace Application.Commands;

public record PhotoToStoreCommand(int PhotoId) : CommandBase
{
    int PhotoId { get; init; } = PhotoId;
}