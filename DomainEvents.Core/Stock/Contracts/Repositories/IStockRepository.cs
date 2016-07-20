using DomainEvents.Core.Sales.Models;

namespace DomainEvents.Core.Stock.Contracts.Repositories
{
    public interface IStockRepository
    {
        void UpdateStock(Models.Stock stock);
    }
}
