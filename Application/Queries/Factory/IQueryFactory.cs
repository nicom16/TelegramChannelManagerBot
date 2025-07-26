using Application.Queries.Base;
using Shared.Telegram;

namespace Application.Queries.Factory;

public interface IQueryFactory
{
    IQuery Create(Update update);
}