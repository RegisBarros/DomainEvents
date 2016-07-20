using DomainEvents.Core.Sales.Models;

namespace DomainEvents.Application
{
    public class SalesApplicationService
    {
        public void CreateNewOrder()
        {
            var order = Order.CreateOrder("123456", 107.99M);

            order.ChangeStatus(2);
        }
    }
}
