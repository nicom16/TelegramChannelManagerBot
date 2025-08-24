using Application.Commands.Common;
using Application.ResultPatternImplementation;

namespace Application.Commands.PhotoToStore;

public class PhotoToStoreCommand<TResult> 
    : CommandBase<TResult> where TResult : OperationResult
{
    public PhotoToStoreCommand(int photoId)
    {
        PhotoId = photoId;
    }
    
    public int PhotoId { get; }
}