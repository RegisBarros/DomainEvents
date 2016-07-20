using DomainEvents.Core.Events.Contracts;
using DomainEvents.Core.Helpers.Contracts;
using System.Collections.Generic;

namespace DomainEvents.Core.Handlers.Contracts
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : IDomainEvent
    {
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
