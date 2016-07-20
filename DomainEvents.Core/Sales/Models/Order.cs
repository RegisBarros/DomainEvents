using DomainEvents.Core.Events;
using DomainEvents.Core.Sales.Events;

namespace DomainEvents.Core.Sales.Models
{
    public class Order
    {
        private Order(string numberOrder, decimal total)
        {
            Number = numberOrder;
            Total = total;
            Status = 1;
        }

        public string Number { get; private set; }

        public decimal Total { get; private set; }

        public int Status { get; private set; }

        public void ChangeStatus(int status)
        {
            if (status > 0)
            {
                Status = status;

                var orderStatusChanged = new OrderStatusChanged(this);
                DomainEvent.Raise(orderStatusChanged);
            }
        }

        public static Order CreateOrder(string numberOrder, decimal total)
        {
            return new Order(numberOrder, total);
        }
    }
}
