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
    
    public partial class INVOICEREQUEST
    {
        public string IRNUM { get; set; }
        public System.DateTime IDATE { get; set; }
        public string INVTYPE { get; set; }
        public string REMARK { get; set; }
        public string CUSID { get; set; }
        public int APPROVED { get; set; }
        public string CREATEDBY { get; set; }
        public System.DateTime CREATED { get; set; }
        public string APPROVEDBY { get; set; }
        public Nullable<System.DateTime> APPROVEDSTAMP { get; set; }
        public string WFSTATUS { get; set; }
        public string ISPRINTED { get; set; }
        public string OBJTYPE { get; set; }
    }
}
