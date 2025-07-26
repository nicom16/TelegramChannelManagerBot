using Application.Commands.Base;
using Application.UpdateAnalyzer;
using Shared.Telegram;

namespace Application.Commands.Factory;

public class CommandFactory : ICommandFactory
{
    public CommandFactory() { }

    public ICommand Create(Update update)
    {
        if (!update.IsCommand()) 
            throw new InvalidOperationException("Update is not a command!");

        if (update.Message.IsNewPhotoToStore())
            return new PhotoToStoreCommand(update.Message.Photo.Id);

        return null;
    }
}