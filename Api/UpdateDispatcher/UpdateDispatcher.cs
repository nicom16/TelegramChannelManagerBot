using System.Text.Json;
using Api.Telegram;
using Application.Commands.PhotoToStore;
using Application.ResultPatternImplementation;

namespace Api.UpdateDispatcher;

public class UpdateDispatcher : IUpdateDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public UpdateDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task<OperationResult> DispatchAsync(Update update) => 
        update switch
        {
            { Message: not null } => await HandleAsync(update.Message),
            _ => OperationResult.Fail($"Invalid update!{Environment.NewLine}{JsonSerializer.Serialize(update)}")
        };

    private async Task<OperationResult> HandleAsync(Message message)
    {
        if (message.PhotoSizes is not null)
        {
            int photoId = message.PhotoSizes.OrderByDescending(p => p.Width).First().Id;
            var command = new PhotoToStoreCommand<OperationResult>(photoId);
            PhotoToStoreCommandHandler commandHandler = 
                _serviceProvider.GetRequiredService<PhotoToStoreCommandHandler>();
            return await commandHandler.HandleAsync(command);
        }
        
        return OperationResult.Success();
    }
}