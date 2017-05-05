namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_GRADEINVENTORY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string UOM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UPDATESTAMP { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string STATUS { get; set; }

        [StringLength(10)]
        public string VFAID { get; set; }

        [StringLength(10)]
        public string IVAID { get; set; }

        [StringLength(10)]
        public string WDAID { get; set; }

        public decimal? VFAMIN { get; set; }

        public decimal? VFAMAX { get; set; }

        public decimal? IVAMIN { get; set; }

        public decimal? IVAMAX { get; set; }

        public decimal? WDAMIN { get; set; }

        public decimal? WDAMAX { get; set; }

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

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(20)]
        public string COLOR { get; set; }

        [StringLength(20)]
        public string ANGLE { get; set; }

        [StringLength(500)]
        public string SPEC { get; set; }

        [StringLength(10)]
        public string ITEMGRP { get; set; }

        [StringLength(10)]
        public string ITEMTYPE { get; set; }

        [StringLength(500)]
        public string INVREMARK { get; set; }
    }
}
