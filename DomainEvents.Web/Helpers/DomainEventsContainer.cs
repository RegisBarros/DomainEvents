﻿using DomainEvents.Core.Helpers.Contracts;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DomainEvents.Web.Helpers
{
    public class DomainEventsContainer : IContainer
    {
        private IDependencyResolver _resolver;

        public DomainEventsContainer(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            return _resolver.GetService(serviceType);
        }

        public T GetService<T>()
        {
            return (T)_resolver.GetService(typeof(T));
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolver.GetServices(serviceType);
        }

        public IEnumerable<T> GetServices<T>(Type serviceType)
        {
            return (IEnumerable<T>)_resolver.GetServices(serviceType);
        }
    }
}