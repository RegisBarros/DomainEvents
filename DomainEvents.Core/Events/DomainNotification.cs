using DomainEvents.Core.Events.Contracts;

namespace DomainEvents.Core.Events
{
    public class DomainNotification: IDomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
