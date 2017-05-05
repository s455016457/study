namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_SINVSCAN_HISTORY
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

        public int? POST { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string SEQNUM { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string SOLOT { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(10)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string LOT { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(50)]
        public string TRADETERMDESCR { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string PAYTERMDESCR { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(20)]
        public string CURRDESCR { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smalldatetime")]
        public DateTime SHIPDATE { get; set; }

        [StringLength(50)]
        public string PAYMTDESCR { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(200)]
        public string CUSNAME { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal SOQTY { get; set; }

        [StringLength(30)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal SINVDTL2QTY { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal SINVDTLQTY { get; set; }
    }
}
