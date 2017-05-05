namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_OutstandingWO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime WODATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string WOSRC { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string WOTYPE { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime PLANBEGDATE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smalldatetime")]
        public DateTime PLANENDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SUBMITDATE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string WORKSHOP { get; set; }

        [StringLength(3000)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLOSED { get; set; }

        public int? INPUTMAT { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal WIPQTY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        [StringLength(500)]
        public string PRIMATDESCR { get; set; }

        [StringLength(50)]
        public string WOTYPE2 { get; set; }

        [StringLength(20)]
        public string SCHEMENUM { get; set; }

        [StringLength(20)]
        public string FIRSTWORKPROC { get; set; }

        [StringLength(20)]
        public string ECNNUM { get; set; }

        public decimal? SCHEDQTY { get; set; }

        [StringLength(50)]
        public string SOITEMNUM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(500)]
        public string ITEMDESCRENG { get; set; }

        [StringLength(500)]
        public string SPEC { get; set; }

        [StringLength(500)]
        public string SPECCHN { get; set; }

        [StringLength(500)]
        public string SPECENG { get; set; }

        [StringLength(100)]
        public string DRAWNUM { get; set; }

        [StringLength(20)]
        public string ITEMECNNUM { get; set; }

        [StringLength(10)]
        public string ITEMSUOM { get; set; }

        public int? LEADTIME { get; set; }

        public decimal? SAFETYSTOCK { get; set; }

        public decimal? COST { get; set; }

        public decimal? ITEMSUPRICE { get; set; }

        [StringLength(10)]
        public string ITEMGRP { get; set; }

        [StringLength(10)]
        public string ITEMTYPE { get; set; }

        [StringLength(20)]
        public string BRAND { get; set; }

        [StringLength(2)]
        public string SRCTYPE { get; set; }

        public decimal? MAXORDQTY { get; set; }

        public decimal? MINORDQTY { get; set; }

        public decimal? FIXORDQTY { get; set; }

        public decimal? ECONLOTSIZE { get; set; }

        public decimal? REORDQTY { get; set; }

        [StringLength(10)]
        public string BATCHPRINC { get; set; }

        [StringLength(10)]
        public string ORDPOLICY { get; set; }

        [StringLength(1)]
        public string ABC { get; set; }

        public decimal? YIELD { get; set; }

        [StringLength(1)]
        public string INSPECGRADE { get; set; }

        public int? SAMPLES { get; set; }

        [StringLength(200)]
        public string INSPECDESCR { get; set; }

        [StringLength(20)]
        public string INSPECLEVEL { get; set; }

        [StringLength(20)]
        public string SAMPLESSTD { get; set; }

        [StringLength(20)]
        public string AQL { get; set; }

        public decimal? WIDTH { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? LENGTH { get; set; }

        public decimal? GROSSWEIGHT { get; set; }

        public decimal? NETWEIGHT { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(100)]
        public string CREATEDBYDESCR { get; set; }

        [StringLength(30)]
        public string WOTYPEDESCR { get; set; }

        [StringLength(30)]
        public string PROLINEDESCR { get; set; }

        public decimal? UNWIPQTY { get; set; }
    }
}
