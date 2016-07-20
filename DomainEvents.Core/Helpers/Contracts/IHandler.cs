using DomainEvents.Core.Events.Contracts;
using System;

namespace DomainEvents.Core.Helpers.Contracts
{
    public interface IHandler<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
