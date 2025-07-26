namespace Application.Queries.Base;

public interface IQuery
{
    Guid Id { get; }
    DateTime CreatedAt { get; }
}