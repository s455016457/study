namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_SO_HISTORY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SOTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(30)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string CURR { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal RATE { get; set; }

        public decimal? TAXRATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(200)]
        public string SHIPMARK { get; set; }

        [StringLength(10)]
        public string VIA { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string SOLDTO { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        [StringLength(200)]
        public string BILLTO { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string SALESREGION { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string LOT { get; set; }

        [StringLength(20)]
        public string CUSITEMNUM { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smalldatetime")]
        public DateTime SHIPDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PLANDATE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal UPRICE { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(10)]
        public string UOM { get; set; }

        public DateTime? CREATED { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(200)]
        public string CUSNAME { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string SOTYPEDESCR { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(100)]
        public string ITEMDESCR { get; set; }
    }
}
