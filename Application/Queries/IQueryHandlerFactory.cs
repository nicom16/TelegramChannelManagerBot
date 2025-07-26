namespace Application.Queries;

public interface IQueryHandlerFactory
{
    IQueryHandler<T> GetHandler<T>() where T : class;
}