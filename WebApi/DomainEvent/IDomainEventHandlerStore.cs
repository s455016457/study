using DomainEvent.ValueObject;
using System;
using System.Collections.Generic;

namespace DomainEvent
{
    public interface IDomainEventHandlerStore
    {
        void AddDomainEventHandler(DomainEventHandlerValueObject entity);

        void AddDomainEventHandler(DomainEventHandlerValueObject[] entities);

        void AddDomainEventHandler(ICollection<DomainEventHandlerValueObject> entities);

        void ChangDomainEventHandlerStuts(DomainEventHandlerValueObject entity);

        ICollection<DomainEventHandlerValueObject> GetEntities();

        ICollection<DomainEventHandlerValueObject> GetEntities(Func<DomainEventHandlerValueObject, bool> predicate);

        DomainEventHandlerValueObject GetEntity(String EventId);
    }
}
