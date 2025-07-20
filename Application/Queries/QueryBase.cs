namespace Application.Queries;

public abstract class QueryBase : IQuery
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; }
    
    public QueryBase()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
    }
}