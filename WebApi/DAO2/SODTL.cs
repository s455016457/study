namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SODTL")]
    public partial class SODTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LOT { get; set; }

        [StringLength(50)]
        public string CUSITEMNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SHIPDATE { get; set; }

        public decimal UPRICE { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public DateTime? CREATED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PLANDATE { get; set; }

        public decimal? VFAMIN { get; set; }

        public decimal? VFAMAX { get; set; }

        public decimal? WDAMIN { get; set; }

        public decimal? WDAMAX { get; set; }

        public decimal? IVAMIN { get; set; }

        public decimal? IVAMAX { get; set; }

        public decimal? VFBMIN { get; set; }

        public decimal? VFBMAX { get; set; }

        public decimal? IVBMIN { get; set; }

        public decimal? IVBMAX { get; set; }

        public decimal? WDBMIN { get; set; }

        public decimal? WDBMAX { get; set; }

        public decimal? VFCMIN { get; set; }

        public decimal? VFCMAX { get; set; }

        public decimal? IVCMIN { get; set; }

        public decimal? IVCMAX { get; set; }

        public decimal? WDCMIN { get; set; }

        public decimal? WDCMAX { get; set; }

        [StringLength(10)]
        public string POS1 { get; set; }

        [StringLength(10)]
        public string POS2 { get; set; }

        public decimal SIQTY { get; set; }

        public decimal REJECTQTY { get; set; }

        public decimal WOQTY { get; set; }

        public int STATUS { get; set; }

        public decimal? FUTUREYIELD { get; set; }

        public int? ISGIFT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SHIPDATE2 { get; set; }

        public decimal? CTMIN { get; set; }

        public decimal? CTMAX { get; set; }

        public decimal? FLUXMIN { get; set; }

        public decimal? FLUXMAX { get; set; }

        [StringLength(500)]
        public string LABELNUM { get; set; }

        public decimal REPLENISHQTY { get; set; }
    }
}
