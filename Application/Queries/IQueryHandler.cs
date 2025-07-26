using Application.Queries.Base;

namespace Application.Queries;

public interface IQueryHandler<T> where T : class
{
    Task<T> HandleAsync(IQuery query);
}