namespace Application.Queries.Common;

public interface IQuery<TResult> where TResult : class
{
    Guid Id { get; }
    DateTime CreatedAt { get; }
}