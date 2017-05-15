using DomainEvent.ValueObject;
using Newtonsoft.Json;
using System;

namespace DomainEvent
{
    /// <summary>
    /// 领域事件处理实体
    /// </summary>
    public class DomainEventHandlerEntity
    {
        private Type eventType;
        private Type eventParameterType;
        private BaseDomainEventArgs eventArgs;

        public Boolean IsRuned()
        {
            return objectValue.IsRuned;
        }
        /// <summary>
        /// 领域事件处理值对象
        /// </summary>
        public DomainEventHandlerValueObject objectValue { get; private set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="objectValue"></param>
        private DomainEventHandlerEntity(DomainEventHandlerValueObject objectValue)
        {
            eventType = Type.GetType(objectValue.EventType);
            eventParameterType = Type.GetType(objectValue.EventParameterType);

            eventArgs = (BaseDomainEventArgs)eventParameterType.Assembly.CreateInstance(eventParameterType.FullName);
            JsonConvert.PopulateObject(objectValue.EventJsonParameter, eventArgs);

            this.objectValue = objectValue;
        }
        /// <summary>
        /// 创建新的值对象
        /// </summary>
        /// <param name="EventType"></param>
        /// <param name="EventParameterType"></param>
        /// <param name="EventJsonParameter"></param>
        /// <returns></returns>
        private static DomainEventHandlerValueObject CreateNewObjectValue(String EventType, String EventParameterType, String EventJsonParameter)
        {
            return new DomainEventHandlerValueObject()
            {
                EventId = Guid.NewGuid().ToString(),
                EventType = EventType,
                EventJsonParameter = EventJsonParameter,
                EventParameterType = EventParameterType,
                IsRuned = false
            };
        }
        /// <summary>
        /// 创建新的领域事件处理实体
        /// </summary>
        /// <param name="EventType">事件类型</param>
        /// <param name="EventParameterType">事件参数类型</param>
        /// <param name="eventArgs">事件参数</param>
        /// <returns></returns>
        public static DomainEventHandlerEntity CreateNew(Type EventType, Type EventParameterType, BaseDomainEventArgs eventArgs)
        {
            var objectValue = CreateNewObjectValue(EventType.AssemblyQualifiedName, EventParameterType.AssemblyQualifiedName, JsonConvert.SerializeObject(eventArgs));
            return new DomainEventHandlerEntity(objectValue);
        }

        public static DomainEventHandlerEntity Create(DomainEventHandlerValueObject objectValue)
        {
            return new DomainEventHandlerEntity(objectValue);
        }

        /// <summary>
        /// 运行
        /// </summary>
        public void Run() {
            var target = eventType.Assembly.CreateInstance(eventType.FullName);
            var deletgate = Utilities.DelegateFactory.CreateDelegate<BaseDomainEventHandler.DomainEventHandler>(eventType.GetMethod("Handler"), new Type[] { typeof(object), typeof(BaseDomainEventArgs) });
            deletgate(target, eventArgs);
            objectValue.IsRuned = true;
        }
    }
}
