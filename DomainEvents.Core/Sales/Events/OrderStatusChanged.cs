using DomainEvents.Core.Events.Contracts;
using DomainEvents.Core.Sales.Models;
using System;

namespace DomainEvents.Core.Sales.Events
{
    public class OrderStatusChanged : IDomainEvent
    {
        public Order Order { get; }

        public DateTime DateTimeEventOccured { get; }

        public OrderStatusChanged(Order order)
        {
            Order = order;
            DateTimeEventOccured = DateTime.Now;
        }
    }
}
