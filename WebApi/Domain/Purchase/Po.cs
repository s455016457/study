using ObjectValue;
using System;

namespace Domain.Purchase
{
    /// <summary>
    /// 采购订单
    /// </summary>
    public class Po
    {
        #region 属性
        /// <summary>
        /// 采购订单号
        /// </summary>
        public String _PoNum { get; private set; }
        /// <summary>
        /// 单据日期
        /// </summary>
        public DateTime _IDate { get; private set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public String _PoType { get { return "01"; } }

        /// <summary>
        /// 版本
        /// </summary>
        public String _Rev { get; private set; }
                
        /// <summary>
        /// 供应商编号
        /// </summary>
        public String _VenID { get; private set; }

        /// <summary>
        /// 币别
        /// </summary>
        public String _Curr { get; private set; }

        /// <summary>
        /// 汇率
        /// </summary>
        public Decimal _Rate { get; private set; }

        /// <summary>
        /// 发票
        /// </summary>
        public String _InvType { get; private set; }

        /// <summary>
        /// 税率
        /// </summary>
        public Decimal _TaxRate { get; private set; }

        /// <summary>
        /// 采购员
        /// </summary>
        public String _BuYer { get; private set; }

        /// <summary>
        /// 付款条件
        /// </summary>
        public String _PayTerm { get; private set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        public String _PayMethod { get; private set; }

        /// <summary>
        /// 交易条件
        /// </summary>
        public String _TradeTerm { get; private set; }

        /// <summary>
        /// 送货地址
        /// </summary>
        public String _ShipTo { get; private set; }

        /// <summary>
        /// 运输标记
        /// </summary>
        public String _ShipMark { get; private set; }

        /// <summary>
        /// 运输方式
        /// </summary>
        public String _Via { get; private set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String _Remark { get; private set; }

        /// <summary>
        /// 金额
        /// </summary>
        public Decimal _Amount { get; private set; }

        /// <summary>
        /// 结案
        /// </summary>
        public Int32 _Closed { get; private set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime _Created { get; private set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String _CreatedBy { get; private set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        public String _WfStatus { get; private set; }

        /// <summary>
        /// 已打印
        /// </summary>
        public String _IsPrinted { get; private set; }
        
        /// <summary>
        /// 结案时间
        /// </summary>
        public DateTime? _ClosedDate { get; private set; }

        /// <summary>
        /// 部门
        /// </summary>
        public String _DeptID { get; private set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        public String _Comments { get; private set; }

        /// <summary>
        /// 保险费
        /// </summary>
        public Decimal _Insure { get; private set; }

        /// <summary>
        /// 手续费
        /// </summary>
        public Decimal _Handle { get; private set; }

        /// <summary>
        /// 送货费
        /// </summary>
        public Decimal _DeliveryChrg { get; private set; }

        /// <summary>
        /// 其他费用
        /// </summary>
        public Decimal _Mischrg { get; private set; }

        /// <summary>
        /// 费用说明
        /// </summary>
        public String _Mischrgtit { get; private set; }

        /// <summary>
        /// 费用科目
        /// </summary>
        public String _MiscAcc { get; private set; }

        /// <summary>
        /// 合计数量
        /// </summary>
        public Decimal _TotalQty { get; private set; }

        /// <summary>
        /// 执行状态
        /// </summary>
        public PoExecStatus _ExecState { get; private set; }

        /// <summary>
        /// 状态更新时间
        /// </summary>
        public DateTime? _ExecStatedStamp { get; private set; }
        #endregion

        #region 构造函数
        public Po(String PoNum, DateTime IDate, String Rev, String VenID, String Curr, Decimal Rate, String InvType
            , Decimal TaxRate, String BuYer, String PayTerm, String PayMethod, String TradeTerm, String ShipTo, String ShipMark
            , String Via, String Remark, Decimal Amount, Int32 Closed, DateTime Created, String CreatedBy, String WfStatus
            , String IsPrinted, DateTime? ClosedDate, String DeptID, String Comments, Decimal Insure, Decimal Handle
            , Decimal DeliveryChrg, Decimal Mischrg, String MiscAcc, String Mischrgtit, Decimal TotalQty
            , PoExecStatus ExecState, DateTime? ExecStatedStamp)
        {
            this._PoNum = PoNum;
            this._IDate = IDate;
            this._Rev = Rev;
            this._VenID = VenID;
            this._Curr = Curr;
            this._Rate = Rate;
            this._InvType = InvType;
            this._TaxRate = TaxRate;
            this._BuYer = BuYer;
            this._PayTerm = PayTerm;
            this._PayMethod = PayMethod;
            this._TradeTerm = TradeTerm;
            this._ShipTo = ShipTo;
            this._ShipMark = ShipMark;
            this._Via = Via;
            this._Remark = Remark;
            this._Amount = Amount;
            this._Closed = Closed;
            this._Created = Created;
            this._CreatedBy = CreatedBy;
            this._WfStatus = WfStatus;
            this._DeliveryChrg = DeliveryChrg;
            this._MiscAcc = MiscAcc;
            this._Mischrg = Mischrg;
            this._Mischrgtit = Mischrgtit;
            this._TotalQty = TotalQty;
            this._ExecState = ExecState;
            this._ExecStatedStamp = ExecStatedStamp;
        }
        #endregion

        /// <summary>
        /// 添加合计数量
        /// </summary>
        /// <param name="qty"></param>
        public void AddTotalQty(Decimal qty)
        {
            this._TotalQty += qty;
        }
        /// <summary>
        /// 添加合计金额
        /// </summary>
        /// <param name="amount"></param>
        public void AddAmount(decimal amount)
        {
            this._Amount += amount;
        }

        /// <summary>
        /// 结案
        /// </summary>
        public void Closed()
        {
            this._Closed = 1;
            this._ClosedDate = DateTime.Now;
            UpdateExecStated(PoExecStatus.Closed);
        }

        /// <summary>
        /// 取消结案
        /// </summary>
        public void UnClosed()
        {
            this._Closed = 0;
            this._ClosedDate = null;
            UpdateExecStated(PoExecStatus.UnExce);
        }
        /// <summary>
        /// 更新执行状态
        /// </summary>
        /// <param name="poExecStatus"></param>
        public void UpdateExecStated(PoExecStatus poExecStatus)
        {
            this._ExecState = poExecStatus;
            this._ExecStatedStamp = DateTime.Now;
        }
        /// <summary>
        /// 更新审批状态
        /// </summary>
        /// <param name="wfStauts"></param>
        public void UpdateWfStatus(String wfStauts)
        {
            this._WfStatus = wfStauts;
        }
    }
}
