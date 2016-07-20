using DomainEvents.Core.Events.Contracts;
using DomainEvents.Core.Handlers.Contracts;
using DomainEvents.Core.Helpers.Contracts;

namespace DomainEvents.Core.Events
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if (Container != null)
            {
                var obj = Container.GetService(typeof(IHandler<T>));
                ((IHandler<T>)obj).Handle(args);
            }
        }

        public static void Notify<T>(T args) where T : IDomainEvent
        {
            if (args == null) return;

            if (Container != null)
            {
                foreach (var handler in Container.GetServices(typeof(IDomainNotificationHandler<T>)))
                    ((IDomainNotificationHandler<T>)handler).Handle(args);
            }
        }
    }
}
