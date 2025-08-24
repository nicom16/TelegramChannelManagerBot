using Shared.Telegram;

namespace Application.UpdateAnalyzer;

public static class UpdateAnalyzer
{
    public static bool IsCommand(this Update update)
    {
        if (update.Message is null) return false;
        
        return update.Message.IsNewPhotoToStore() ||
               update.Message.IsNewVideoToStore() ||
               update.Message.IsNewAnimationToStore();
    }

    public static bool IsQuery(this Update update)
    {
        // TODO
        return false;
    }
    
    public static bool IsNewPhotoToStore(this Message message)
    {
        return message.PhotoSizes is not null;
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