using DomainEvent;
using Test.TestDomainEvent;
using System.Linq;
using System.Collections.Generic;
using Test.DomainEvent;

namespace Test
{
    class Program
    {
        /// 事件
        /// </summary>
        public static event BaseDomainEventHandler.DomainEventHandler HelloDomainEvent;
        public static event BaseDomainEventHandler.DomainEventHandler BayBayDomainEvent;

        static void Main(string[] args)
        {
            DomainEventPublisher domainEventPublisher = DomainEventPublisher.Initialization(new DomainEventHandlerStore());

            var chinaSayHelloHandler = new ChinaSayHelloHandler();
            var englishSayHelloHandler = new EnglishSayHelloHandler();

            HelloDomainEvent += chinaSayHelloHandler.Handler;
            HelloDomainEvent += englishSayHelloHandler.Handler;
            domainEventPublisher.Publisher(HelloDomainEvent,new SayEventArgs() { Message = "在见面时打招呼" });
            HelloDomainEvent -= englishSayHelloHandler.Handler;
            domainEventPublisher.Publisher(HelloDomainEvent,new SayEventArgs() { Message = "在见面时打招呼" });

            BayBayDomainEvent += new ChinaSayByeByeHandler().Handler;
            domainEventPublisher.Publisher(BayBayDomainEvent, new SayEventArgs() { Message = "在离开时打招呼" });

            domainEventPublisher.Exec();
        }
    }
}
