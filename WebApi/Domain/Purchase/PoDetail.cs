using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Purchase
{
    public class PoDetail
    {
        #region 属性
        public string _PoNum { get;private set; }

        public string _ItemNum { get; private set; }

        public string _Lot { get; private set; }

        public string _VenItemNum { get; private set; }

        public DateTime _RecvDate { get; private set; }

        public decimal _UPrice { get; private set; }

        public decimal _ExQty { get; private set; }

        public string _ExUom { get; private set; }

        public decimal _Qty { get; private set; }

        public string _Uom { get; private set; }

        public decimal _Amount { get; private set; }

        public string _Remark { get; private set; }

        public string _PrNum { get; private set; }

        public decimal _GrnQty { get; private set; }

        public decimal _RejectQty { get; private set; }

        public int _Closed { get; private set; }

        public string _CreatedUser { get; private set; }

        public DateTime _CreatedStamp { get; private set; }

        public DateTime? _ClosedDate { get; private set; }

        public DateTime _ReplyRecvDate { get; private set; }

        public decimal _ExtUPrice { get; private set; }

        public decimal _Extexpense { get; private set; }

        public string _SuItemNum { get; private set; }

        public string _SuItemName { get; private set; }

        public decimal _SuItemQty { get; private set; }
        #endregion

        #region 构造函数
        public PoDetail(String PoNum,String ItemNum,String Lot,String VenItemNum,DateTime RecvDate,decimal UPrice,decimal ExQty,string ExUom
            ,decimal Qty,string Uom,decimal Amount,string Remark,string PrNum,decimal GrnQty,decimal RejectQty,int Status,string CreatedUser
            ,DateTime CreatedStamp,DateTime ClosedDate,DateTime ReplyRecvDate,decimal ExtUPrice,decimal Extexpense,string SuItemNum
            ,string SuItemName,decimal SuitemQty)
        {
            _PoNum = PoNum;
            _ItemNum = ItemNum;
            _Lot = Lot;
            _VenItemNum = VenItemNum;
            _RecvDate = RecvDate;
            _UPrice = UPrice;
            _ExQty = ExQty;
            _ExUom = ExUom;
            _Qty = Qty;
            _Uom = Uom;
            _Amount = Amount;
            _Remark = Remark;
            _PrNum = PrNum;
            _GrnQty = GrnQty;
            _RejectQty = RejectQty;
            _Closed = Status;
            _CreatedUser = CreatedUser;
            _CreatedStamp = CreatedStamp;
            _ClosedDate = ClosedDate;
            _ReplyRecvDate = ReplyRecvDate;
            _ExtUPrice = ExtUPrice;
            _Extexpense = Extexpense;
            _SuItemNum = SuItemNum;
            _SuItemName = SuItemName;
            _SuItemQty = SuitemQty;
        }
        #endregion

        public void AddGrnQty(decimal qty)
        {
            _GrnQty += qty;
        }

        public void AddRejectQty(decimal qty)
        {
            _RejectQty += qty;
        }

        public void Closed(DateTime cloasedDate)
        {
            _Closed = 1;
            _ClosedDate = cloasedDate;
        }

        public void UnClosed()
        {
            _Closed = 0;
            _ClosedDate = null;
        }
    }
}
