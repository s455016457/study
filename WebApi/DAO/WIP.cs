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
    
    public partial class WIP
    {
        public string WIPNUM { get; set; }
        public System.DateTime WIPDATE { get; set; }
        public string LOCID { get; set; }
        public string REMARK { get; set; }
        public Nullable<int> COMPLETED { get; set; }
        public string CREATEDBY { get; set; }
        public string WFSTATUS { get; set; }
        public string ISPRINTED { get; set; }
        public string OBJTYPE { get; set; }
        public Nullable<System.DateTime> CREATEDSTAMP { get; set; }
    
        public virtual WIPTYPE WIPTYPE { get; set; }
    }
}