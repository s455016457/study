namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_SINVDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CURR { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal RATE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TAXRATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string PAYTERM { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string TRADETERM { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(50)]
        public string SHIPVIA { get; set; }

        public decimal? INSURE { get; set; }

        public decimal? HANDLE { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(30)]
        public string MISCHRGTIT { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal UPRICE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(5)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal SINVDTLAMOUNT { get; set; }

        [StringLength(200)]
        public string SINVDTLREMARK { get; set; }

        [StringLength(500)]
        public string SOREMARK { get; set; }

        [StringLength(200)]
        public string SODETAILREMARK { get; set; }

        [StringLength(20)]
        public string CUSITEMNUM { get; set; }
    }
}
