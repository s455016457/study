namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITEMS
    {
        [Key]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

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
        public string ECNNUM { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public int? LEADTIME { get; set; }

        public decimal? SAFETYSTOCK { get; set; }

        public decimal? COST { get; set; }

        public decimal? UPRICE { get; set; }

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

        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal? EXRATE { get; set; }

        [StringLength(20)]
        public string COLOR { get; set; }

        [StringLength(20)]
        public string ANGLE { get; set; }

        public int? ISBACKFLUSH { get; set; }

        [StringLength(50)]
        public string VENDOR { get; set; }

        [StringLength(50)]
        public string CITEMNUM { get; set; }

        [StringLength(50)]
        public string VITEMNUM { get; set; }

        public decimal? COST1 { get; set; }

        public decimal? LASTPOUPRICE { get; set; }

        [StringLength(30)]
        public string LASTPONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LASTPODATE { get; set; }

        public decimal? LASTSOUPRICE { get; set; }

        [StringLength(30)]
        public string LASTSONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LASTSODATE { get; set; }

        public int? ALLOWOVERORDER { get; set; }

        public decimal? MINPACKQTY { get; set; }

        public int? ISDENY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? DENYSTAMP { get; set; }

        [StringLength(20)]
        public string DENYUSER { get; set; }

        public decimal? REFUPRICE { get; set; }

        [StringLength(20)]
        public string REFUOM { get; set; }

        public int? ISSUBCON { get; set; }

        [StringLength(100)]
        public string STYLE { get; set; }

        [StringLength(100)]
        public string STYLETYPE { get; set; }

        public int? CHIPCOUNT { get; set; }

        public virtual ITEMGRP ITEMGRP1 { get; set; }
    }
}
