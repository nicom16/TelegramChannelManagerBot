using Api.Models;

namespace Api.Helpers;

public static class MessageHelpers
{
    public static bool IsCommand(this Message message)
    {
        return message.IsNewPhotoToStore() ||
               message.IsNewVideoToStore() ||
               message.IsNewAnimationToStore();
    }

    public static bool IsQuery(this Message message)
    {
        // TODO
        return false;
    }
    
    public static bool IsNewPhotoToStore(this Message message)
    {
        return message.Photo is not null;
    }

    public static bool IsNewVideoToStore(this Message message)
    {
        return message.Video is not null;
    }

    public static bool IsNewAnimationToStore(this Message message)
    {
        return message.Animation is not null;
    }
}