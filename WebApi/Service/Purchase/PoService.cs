using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService.Models;

namespace Service.Purchase
{
    public class PoService : IService.Interface.Purchase.IPOService
    {
        public PoService()
        {
            LoggerService.LoggerService.ApplicationLogger.Debug("PoService无参数构造函数");
        }
        public PoService(IBusiness.Interface.Purchase.IPoBusiness bal)
        {
            LoggerService.LoggerService.ApplicationLogger.Debug("PoServicey一个参数构造函数");
        }
        public IList<PoSearchModel> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
