using Application.Commands.Common;
using Application.ResultPatternImplementation;

namespace Application.Commands.PhotoToStore;

public class PhotoToStoreCommandHandler 
    : ICommandHandler<PhotoToStoreCommand<OperationResult>, OperationResult>
{
    public async Task<OperationResult> HandleAsync(PhotoToStoreCommand<OperationResult> command)
    {
        return await Task.Run(() => OperationResult.Success());
    }
}