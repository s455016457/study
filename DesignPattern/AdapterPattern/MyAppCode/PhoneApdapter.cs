using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 对象适配器
    /// 提供程序扩展性
    /// 会使源对象丢失接口外的功能
    /// </summary>
    public class PhoneApdapter
    {
        private IPhone _phone;
        public PhoneApdapter(IPhone phone)
        {
            this._phone = phone;
        }

        public void Call()
        {
            _phone.Call();
        }

        public void Message()
        {
            Console.WriteLine("适配器提供的Message");
        }
    }
}
