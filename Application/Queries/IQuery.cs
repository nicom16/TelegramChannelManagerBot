namespace Application.Queries;

public interface IQuery
{
    Guid Id { get; }
    DateTime CreatedAt { get; }
}