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
    
    public partial class V_STOCKADJUSTDTL
    {
        public string SANUM { get; set; }
        public string REFNUM { get; set; }
        public string ITEMNUM { get; set; }
        public string LOT { get; set; }
        public string REASON { get; set; }
        public decimal CURRQTY { get; set; }
        public decimal ADJQTY { get; set; }
        public Nullable<decimal> MQTY { get; set; }
        public string UOM { get; set; }
        public string LABELID { get; set; }
        public Nullable<System.DateTime> MFGDATE { get; set; }
        public Nullable<int> GUAPERIOD { get; set; }
        public System.DateTime CREATED { get; set; }
        public string CREATEDBY { get; set; }
        public Nullable<System.DateTime> UPDATESTAMP { get; set; }
        public string UPDATEUSER { get; set; }
        public string ITEMDESCR { get; set; }
        public string SPEC { get; set; }
    }
}
