//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PODTL
    {
        public string PONUM { get; set; }
        public string ITEMNUM { get; set; }
        public string LOT { get; set; }
        public string VENITEMNUM { get; set; }
        public System.DateTime RECVDATE { get; set; }
        public decimal UPRICE { get; set; }
        public Nullable<decimal> EXQTY { get; set; }
        public string EXUOM { get; set; }
        public decimal QTY { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public string REMARK { get; set; }
        public string PRNUM { get; set; }
        public decimal GRNQTY { get; set; }
        public decimal REJECTQTY { get; set; }
        public int STATUS { get; set; }
        public Nullable<System.DateTime> CREATED { get; set; }
        public string CREATEDBY { get; set; }
        public Nullable<System.DateTime> CLOSEDDATE { get; set; }
        public Nullable<System.DateTime> REPLYRECVDATE { get; set; }
        public Nullable<decimal> EXTUPRICE { get; set; }
        public Nullable<decimal> EXTEXPENSE { get; set; }
        public string SUITENUM { get; set; }
        public string SUITENAME { get; set; }
        public Nullable<decimal> SUITEQTY { get; set; }
    }
}