using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBusiness.Models;

namespace Business.Purchase
{
    public class PoBusiness : IBusiness.Interface.Purchase.IPoBusiness
    {
        private DAO.swerpEntities _context;
        public PoBusiness(DAO.swerpEntities Context)
        {
            _context = Context;
        }
        public bool Add(Po model)
        {
            throw new NotImplementedException();
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
            return _context.POes
                .GroupJoin(_context.USERS, p => p.CREATEDBY, p => p.UID, (a, b) => new { PO = a, USERS = b })
                .Select(p => new IBusiness.Models.Po
                {
                    AMOUNT = p.PO.AMOUNT,
                    BuyerName = p.PO.BUYER.DESCR,
                    CLOSED = p.PO.CLOSED,
                    CLOSEDDATE = p.PO.CLOSEDDATE,
                    COMMENTS = p.PO.COMMENTS,
                    CREATED = p.PO.CREATED,
                    CREATEDBY = p.PO.CREATEDBY,
                    CreatedUserName = p.USERS.FirstOrDefault() != null ? p.USERS.FirstOrDefault().NAME : String.Empty,
                    CURR = p.PO.CURR,
                    DELIVERYCHRG=p.PO.DELIVERYCHRG,
                    DEPTID=p.PO.DEPTID,
                    HANDLE=p.PO.HANDLE,
                    IDATE=p.PO.IDATE,
                    INSURE=p.PO.INSURE,
                    InvTypeDescr=p.PO.INVTYPE.DESCR,
                    ISPRINTED=p.PO.ISPRINTED,
                    MISCACC=p.PO.MISCACC,
                    MISCHRG=p.PO.MISCHRG,
                    MISCHRGTIT=p.PO.MISCHRGTIT,
                    OBJTYPE=p.PO.OBJTYPE,
                    PayMethodDescr=p.PO.PAYMETHOD.DESCR,
                    PayTermDescr=p.PO.PAYTERM.DESCR,
                    PONUM=p.PO.PONUM,
                    POTYPE=p.PO.POTYPE
                });
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
    }
}
