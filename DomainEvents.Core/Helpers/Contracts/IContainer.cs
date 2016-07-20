using System;
using System.Collections.Generic;

namespace DomainEvents.Core.Helpers.Contracts
{
    public interface IContainer
    {
        T GetService<T>();
        object GetService(Type serviceType);
        IEnumerable<T> GetServices<T>(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}
