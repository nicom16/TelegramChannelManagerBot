namespace Application.Queries;

public interface IQueryHandlerFactory
{
    IQueryHandler<T> GetHandler<T>(IQuery queryToHandle) where T : class;
}