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
    
    public partial class MRPOUT
    {
        public string MRPCODE { get; set; }
        public int SEQNUM { get; set; }
        public string DOCTYPE { get; set; }
        public string DOCNUM { get; set; }
        public string DEPTID { get; set; }
        public string PROLINE { get; set; }
        public string REFNUM { get; set; }
        public string REFITEMNUM { get; set; }
        public System.DateTime DOCDATE { get; set; }
        public string ITEMNUM { get; set; }
        public Nullable<decimal> ORDERQTY { get; set; }
        public Nullable<decimal> ISSUEDQTY { get; set; }
        public Nullable<decimal> REJECTQTY { get; set; }
        public Nullable<decimal> OUTQTY { get; set; }
        public string DEPTNAME { get; set; }
        public string PROLINENAME { get; set; }
    }
}