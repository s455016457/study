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
        public IList<PoSearchModel> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
