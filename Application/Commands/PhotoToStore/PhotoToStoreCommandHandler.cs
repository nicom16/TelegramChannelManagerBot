using Application.Commands.Common;

namespace Application.Commands.PhotoToStore;

public class PhotoToStoreCommandHandler 
    : ICommandHandler<PhotoToStoreCommand<CommandResult>, CommandResult>
{
    public Task<CommandResult> HandleAsync(PhotoToStoreCommand<CommandResult> command)
    {
        var commandResult = 
            new CommandResult($"Photo {command.PhotoId} was added to store.");
        return Task.Run(() => commandResult);
    }
}