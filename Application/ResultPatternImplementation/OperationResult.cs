namespace Application.ResultPatternImplementation;

public record OperationResult
{
    public string Message { get; init; }
    public bool IsSuccess { get; init; }
    public bool HasMessage => !string.IsNullOrWhiteSpace(Message);
    
    private OperationResult(string errorMessage)
    {
        Message = errorMessage;
        IsSuccess = false;
    }

    private OperationResult()
    {
        Message = string.Empty;
        IsSuccess = true;
    }
    
    public static OperationResult Fail(string message) => new OperationResult(message);
    public static OperationResult Success() => new OperationResult();
};