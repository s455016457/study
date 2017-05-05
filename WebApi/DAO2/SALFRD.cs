namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALFRD")]
    public partial class SALFRD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SFNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SHIPDATE { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public DateTime? CREATED { get; set; }

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

        public decimal? FUTUREYIELD { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(50)]
        public string LABELID { get; set; }
    }
}
