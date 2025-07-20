using Api.Models;

namespace Api.Helpers;

public static class MessageHelpers
{
    public static bool IsNewPostToStore(this Message message)
    {
        return message.Photo is not null ||
               message.Animation is not null ||
               message.Video is not null;
    }

    public static bool IsNewPhotoToStore(this Message message)
    {
        return message.IsNewPostToStore() && message.Photo is not null;
    }

    public static bool IsNewVideoToStore(this Message message)
    {
        return message.IsNewPostToStore() && message.Video is not null;
    }

    public static bool IsNewAnimationToStore(this Message message)
    {
        return message.IsNewPostToStore() && message.Animation is not null;
    }
}