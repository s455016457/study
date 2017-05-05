namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WAFERDATA")]
    public partial class WAFERDATA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime IMPDATE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [Key]
        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(30)]
        public string BIN { get; set; }

        [StringLength(30)]
        public string WAFER { get; set; }

        public decimal? DICEHEIGHT { get; set; }

        public decimal? LOPCOV { get; set; }

        [StringLength(10)]
        public string VFAID { get; set; }

        public decimal? VFAMIN { get; set; }

        public decimal? VFAMAX { get; set; }

        public decimal? VFAAVG { get; set; }

        public decimal? VFASTD { get; set; }

        [StringLength(10)]
        public string WDAID { get; set; }

        public decimal? WDAMIN { get; set; }

        public decimal? WDAMAX { get; set; }

        public decimal? WDAAVG { get; set; }

        public decimal? WDASTD { get; set; }

        public decimal? WAVELENGTHSIGMA { get; set; }

        [StringLength(10)]
        public string IVAID { get; set; }

        public decimal? IVAMIN { get; set; }

        public decimal? IVAMAX { get; set; }

        public decimal? IVAAVG { get; set; }

        public decimal? IVASTD { get; set; }

        [StringLength(10)]
        public string VFBID { get; set; }

        [StringLength(10)]
        public string IVBID { get; set; }

        [StringLength(10)]
        public string WDBID { get; set; }

        public decimal? VFBMIN { get; set; }

        public decimal? VFBMAX { get; set; }

        public decimal? IVBMIN { get; set; }

        public decimal? IVBMAX { get; set; }

        public decimal? WDBMIN { get; set; }

        public decimal? WDBMAX { get; set; }

        [StringLength(10)]
        public string VFCID { get; set; }

        [StringLength(10)]
        public string IVCID { get; set; }

        [StringLength(10)]
        public string WDCID { get; set; }

        public decimal? VFCMIN { get; set; }

        public decimal? VFCMAX { get; set; }

        public decimal? IVCMIN { get; set; }

        public decimal? IVCMAX { get; set; }

        public decimal? WDCMIN { get; set; }

        public decimal? WDCMAX { get; set; }

        [StringLength(10)]
        public string POS { get; set; }

        public decimal? POS1X { get; set; }

        public decimal? POS1Y { get; set; }

        public decimal? POS2X { get; set; }

        public decimal? POS2Y { get; set; }

        public decimal? POS3X { get; set; }

        public decimal? POS3Y { get; set; }

        public decimal? POS4X { get; set; }

        public decimal? POS4Y { get; set; }
    }
}
