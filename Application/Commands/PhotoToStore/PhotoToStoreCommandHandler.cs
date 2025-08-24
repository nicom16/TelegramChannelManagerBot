using Application.Commands.Common;

namespace Application.Commands.PhotoToStore;

public class PhotoToStoreCommandHandler 
    : ICommandHandler<PhotoToStoreCommand<CommandResult>, CommandResult>
{
    public async Task<CommandResult> HandleAsync(PhotoToStoreCommand<CommandResult> command)
    {
        return await Task.Run(() => 
            new CommandResult($"Photo {command.PhotoId} was added to store."));
    }
}