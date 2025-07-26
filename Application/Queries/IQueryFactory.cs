using Shared.Telegram;

namespace Application.Queries;

public interface IQueryFactory
{
    IQuery Create(Message message);
}