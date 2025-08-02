namespace Application.Queries.Common;

public interface IQueryHandler<TQuery, TResult> 
    where TQuery : IQuery<TResult> where TResult : class
{
    Task<TResult> HandleAsync(TQuery query);
}