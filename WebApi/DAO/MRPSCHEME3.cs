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
    
    public partial class MRPSCHEME3
    {
        public string MRPCODE { get; set; }
        public int LINEID { get; set; }
        public int PERIODID { get; set; }
        public string ITEMNUM { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public string BASEDOCNUM { get; set; }
        public string BASELOT { get; set; }
        public Nullable<System.DateTime> BASEDUE { get; set; }
        public string STOCKTYPE { get; set; }
        public string PARENTCODE { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<System.DateTime> ENDDATE { get; set; }
        public string ORDERTYPE { get; set; }
    }
}
