using DomainEvents.Core.Helpers.Contracts;
using DomainEvents.Core.Sales.Events;
using DomainEvents.Core.Stock.Contracts.Repositories;
using System;

namespace DomainEvents.Core.Stock.Handler
{
    public class OrderStatusChangedHandler : IHandler<OrderStatusChanged>
    {
        private readonly IStockRepository _stockRepository;

        public OrderStatusChangedHandler(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public void Handle(OrderStatusChanged args)
        {
            // do something
            
            _stockRepository.UpdateStock(new Models.Stock());
        }
    }
}
