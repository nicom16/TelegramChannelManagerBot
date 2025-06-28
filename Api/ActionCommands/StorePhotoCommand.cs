using Api.Models;

namespace Api.ActionCommands;

internal class StorePhotoCommand : IActionCommand
{
    private readonly string _token;
    private readonly Message _message;

    public StorePhotoCommand(string token, Message message)
    {
        _message = message;
        _token = token;
    }

    public void Execute()
    {
        Console.WriteLine("Storing a photo...");
    }
}