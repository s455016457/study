using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBusiness.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq.Expressions;

namespace Business.Purchase
{
    public class PoBusiness :BaseBusiness, IBusiness.Interface.Purchase.IPoBusiness
    {
        public PoBusiness(DAO.swerpEntities Context)
        {
            _context = Context;
            Mapper.Initialize(p =>
            {
                p.CreateMap<IBusiness.Models.Po, DAO.PO>();
                p.CreateMap<DAO.PO, IBusiness.Models.Po>()
                .ForMember(dest => dest.CreatedUserName, opt => opt.MapFrom(src => src.CREATEDBY));//建立外键
            });
            LoggerService.LoggerService.ApplicationLogger.Debug("初始化PoBusiness");
        }
        public bool Add(Po model)
        {
            var entity = ToEntity(model);
            _context.POes.Add(ToEntity(model));
            return true;
        }

        public bool AddDetail(PoDetail model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Po model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDetail(PoDetail model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDetail(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public bool Exists(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public bool ExistsDetail(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PoDetail> GetDetailList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Po> GetList()
        {
            //Func<Po, IEnumerable<DAO.USER>, Po> lam = (a, b) => { a.CreatedUserName = b.FirstOrDefault() == null ? String.Empty : b.FirstOrDefault().NAME; return a; };
            return _context.POes
                .ProjectTo<Po>()
                //.GroupJoin(_context.USERS, p => p.CREATEDBY, p => p.UID
                //, (a,b)=> new { PO = a, USERS = b })
                //.Select(p => new IBusiness.Models.Po
                //{
                //    AMOUNT = p.PO.AMOUNT,
                //    BuyerName = p.PO.BUYER.DESCR,
                //    CLOSED = p.PO.CLOSED,
                //    CLOSEDDATE = p.PO.CLOSEDDATE,
                //    COMMENTS = p.PO.COMMENTS,
                //    CREATED = p.PO.CREATED,
                //    CREATEDBY = p.PO.CREATEDBY,
                //    CreatedUserName = p.USERS.FirstOrDefault() != null ? p.USERS.FirstOrDefault().NAME : String.Empty,
                //    CURR = p.PO.CURR,
                //    DELIVERYCHRG = p.PO.DELIVERYCHRG,
                //    DEPTID = p.PO.DEPTID,
                //    HANDLE = p.PO.HANDLE,
                //    IDATE = p.PO.IDATE,
                //    INSURE = p.PO.INSURE,
                //    InvTypeDescr = p.PO.INVTYPE.DESCR,
                //    ISPRINTED = p.PO.ISPRINTED,
                //    MISCACC = p.PO.MISCACC,
                //    MISCHRG = p.PO.MISCHRG,
                //    MISCHRGTIT = p.PO.MISCHRGTIT,
                //    OBJTYPE = p.PO.OBJTYPE,
                //    PayMethodDescr = p.PO.PAYMETHOD.DESCR,
                //    PayTermDescr = p.PO.PAYTERM.DESCR,
                //    PoNum = p.PO.PONUM,
                //    POTYPE = p.PO.POTYPE,
                //    PROJECT=p.PO.PROJECT
                //})
                .Where(p=>p.CreatedUserName!="")
                ;
        }

        public Po GetModel(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public PoDetail GetModelDetail(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public bool Update(Po model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetail(PoDetail model)
        {
            throw new NotImplementedException();
        }

        private IBusiness.Models.Po ToModel(DAO.PO entity)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<DAO.PO, IBusiness.Models.Po>());
            return Mapper.Map<IBusiness.Models.Po>(entity);
        }

        private DAO.PO ToEntity(IBusiness.Models.Po entity)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<IBusiness.Models.Po, DAO.PO>());
            return Mapper.Map<DAO.PO>(entity);
        }
    }
}
