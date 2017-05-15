using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvent
{
    public abstract class BaseDomainEventHandler
    {
        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        /// <summary>
        public delegate void DomainEventHandler(object sender, BaseDomainEventArgs eventArgs);
        public abstract void Handler(object sender, BaseDomainEventArgs eventArgs);
    }
}
