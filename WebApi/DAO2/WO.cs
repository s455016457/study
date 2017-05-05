namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WO")]
    public partial class WO
    {
        [Key]
        [StringLength(20)]
        public string WONUM { get; set; }

        public DateTime WODATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Required]
        [StringLength(20)]
        public string WOSRC { get; set; }

        [Required]
        [StringLength(10)]
        public string WOTYPE { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        public decimal QTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PLANBEGDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PLANENDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SUBMITDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKSHOP { get; set; }

        [StringLength(3000)]
        public string REMARK { get; set; }

        public int CLOSED { get; set; }

        public int? INPUTMAT { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

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

        public virtual WOTYPE WOTYPE1 { get; set; }
    }
}
