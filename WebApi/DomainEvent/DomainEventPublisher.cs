using DomainEvent.Utilities;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using DomainEvent.ValueObject;

namespace DomainEvent
{
    /// <summary>
    /// 领域事件发布
    /// </summary>
    public class DomainEventPublisher
    {
        private static readonly Object lock_obj = new Object();
        private static DomainEventPublisher _this;
        private IDomainEventHandlerStore store;

        private DomainEventPublisher(IDomainEventHandlerStore store)
        {
            this.store = store;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public static DomainEventPublisher Initialization(IDomainEventHandlerStore store)
        {
            if (_this == null)
            {
                lock (lock_obj)
                {
                    _this = new DomainEventPublisher(store);
                }
            }
            return _this;
        }
        /// <summary>
        //  发行
        /// </summary>
        /// <param name="eventArgs"></param>
        public void Publisher(BaseDomainEventHandler.DomainEventHandler DomainEvent, BaseDomainEventArgs eventArgs)
        {
            foreach (Delegate item in DomainEvent.GetInvocationList())
            {
                DomainEventHandlerEntity entity = DomainEventHandlerEntity.CreateNew(item.Target.GetType(), eventArgs.GetType(), eventArgs);
                store.AddDomainEventHandler(entity.objectValue);
            }
        }

        public void Exec()
        {
            var ObjectValues = store.GetEntities();
            DomainEventHandlerValueObject[] entityArray = new DomainEventHandlerValueObject[ObjectValues.Count];
            ObjectValues.CopyTo(entityArray, 0);

            foreach (var objectValue in entityArray)
            {
                var entity = DomainEventHandlerEntity.Create(objectValue);
                entity.Run();
                
                store.ChangDomainEventHandlerStuts(objectValue);
            }
        }
    }
}
