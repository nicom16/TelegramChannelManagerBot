using Api.Models;

namespace Api.Helpers;

public static class MessageHelpers
{
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