namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_PO_HISTORY
    {
        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(10)]
        public string POTYPE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IDATE { get; set; }

        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(10)]
        public string CURR { get; set; }

        public decimal? RATE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string PAYTERM { get; set; }

        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        [StringLength(200)]
        public string SHIPMARK { get; set; }

        [StringLength(20)]
        public string VIA { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [StringLength(20)]
        public string VENITEMNUM { get; set; }

        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [StringLength(10)]
        public string LOT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECVDATE { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(20)]
        public string PRNUM { get; set; }

        [StringLength(20)]
        public string DESCR { get; set; }

        [StringLength(100)]
        public string VENNAME { get; set; }

        [StringLength(50)]
        public string PAYMETHODDESCR { get; set; }

        [Key]
        [StringLength(50)]
        public string BUYERDESCR { get; set; }

        [StringLength(50)]
        public string TRADETERMDESCR { get; set; }

        [StringLength(100)]
        public string ITEMDESCR { get; set; }

        public decimal? EXQTY { get; set; }

        [StringLength(10)]
        public string EXUOM { get; set; }

        [StringLength(200)]
        public string PODTLREMARK { get; set; }

        public decimal? EXGRNQTY { get; set; }

        public decimal? EXREJECTQTY { get; set; }
    }
}
