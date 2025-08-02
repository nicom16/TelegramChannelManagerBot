namespace Application.Queries.Common;

public abstract class QueryBase<TResult> : IQuery<TResult> where TResult : class
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; }
    
    public QueryBase()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
    }
}