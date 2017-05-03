using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService.Models;
using IBusiness.Interface.Purchase;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using System.Data.Entity;

namespace Service.Purchase
{
    public class PoService : IService.Interface.Purchase.IPOService
    {
        private IPoBusiness _bal;
        public PoService()
        {
            //Mapper.Initialize(p =>
            //{
            //    p.CreateMap<PoSearchModel, IBusiness.Models.Po>();
            //    p.CreateMap<IBusiness.Models.Po, PoSearchModel>();
            //});
            LoggerService.LoggerService.ApplicationLogger.Debug("PoService无参数构造函数");
        }
        public PoService(IPoBusiness bal)
        {
            _bal = bal;
            //Mapper.Initialize(p =>
            //{
            //    p.CreateMap<PoSearchModel, IBusiness.Models.Po>();
            //    p.CreateMap<IBusiness.Models.Po, PoSearchModel>();
            //});
            LoggerService.LoggerService.ApplicationLogger.Debug("PoServicey一个参数构造函数");
        }
        public IList<PoSearchModel> GetList()
        {
            return _bal.GetList().Take(1)
                //.ProjectTo<PoSearchModel>()
                .Select(p => new PoSearchModel()
                {
                    AMOUNT = p.AMOUNT.HasValue ? p.AMOUNT.Value : 0,
                    CLOSED = p.CLOSED.HasValue ? p.CLOSED.Value == 1 : false,
                    CLOSEDDATE = p.CLOSEDDATE,
                    COMMENTS = p.COMMENTS,
                    CREATED = p.CREATED.HasValue ? p.CREATED.Value : DateTime.Now,
                    CURR = p.CURR,
                    DELIVERYCHRG = p.DELIVERYCHRG.HasValue ? p.DELIVERYCHRG.Value : 0,
                    DEPTID = p.DEPTID,
                    HANDLE = p.HANDLE.HasValue ? p.HANDLE.Value : 0,
                    ISPRINTED = p.ISPRINTED,
                    IDATE = p.IDATE,
                    BuyerName = p.BuyerDescr,
                    CreatedUserName = p.CreatedUserName
                })
            .ToList();
        }
    }
}
