using Application.Commands.Common;

namespace Application.Commands.PhotoToStore;

public class PhotoToStoreCommand<TResult> 
    : CommandBase<TResult> where TResult : CommandResult
{
    public PhotoToStoreCommand(int photoId)
    {
        PhotoId = photoId;
    }
    
    public int PhotoId { get; }
}