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
    
    public partial class SINVDATA
    {
        public int ID { get; set; }
        public string SINUM { get; set; }
        public string CUSSHORTNAME { get; set; }
        public Nullable<System.DateTime> SIDATE { get; set; }
        public string CUSPONUM { get; set; }
        public string PSNUM { get; set; }
        public string STYLE { get; set; }
        public string STYLETYPE { get; set; }
        public string ITEMNUM { get; set; }
        public string ITEMDESCR { get; set; }
        public Nullable<decimal> QTY1 { get; set; }
        public Nullable<decimal> SOQTY { get; set; }
        public Nullable<decimal> QTY { get; set; }
        public Nullable<decimal> QTY2 { get; set; }
        public Nullable<decimal> UPRICE { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public string UOM { get; set; }
        public string REMARK { get; set; }
        public bool ISGENSI { get; set; }
        public string CREATEDUSER { get; set; }
        public System.DateTime CREATEDSTAMP { get; set; }
        public string UPDATEDUSER { get; set; }
        public Nullable<System.DateTime> UPDATEDSTAMP { get; set; }
    }
}
