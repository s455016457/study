namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_PRHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRNUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime PRDATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string PROPOSER { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(2)]
        public string PRTYPE { get; set; }

        [StringLength(20)]
        public string PURREP { get; set; }

        [StringLength(20)]
        public string EXECDEPTID { get; set; }

        [StringLength(100)]
        public string TOTALQTY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(6)]
        public string CLOSEDDESCR { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string DTLCLOSEDDESCR { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal? DTLQTY { get; set; }

        public decimal? DTLORDQTY { get; set; }

        public decimal? DTLPOQTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ADPODATE { get; set; }

        [StringLength(500)]
        public string PURPOSE { get; set; }

        [StringLength(100)]
        public string VENID { get; set; }

        public int? DTLLEADTIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECDATE { get; set; }

        [StringLength(500)]
        public string DTLREMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESPONSEDATE { get; set; }

        public int? DTLSTATUS { get; set; }

        [StringLength(200)]
        public string SUITENAME { get; set; }

        [StringLength(50)]
        public string SUITENUM { get; set; }

        public decimal? SUITEQTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(20)]
        public string DTLCREATEDUSER { get; set; }

        public DateTime? DTLCREATED { get; set; }

        public DateTime? DTLUPDATEDSTAMP { get; set; }

        [StringLength(20)]
        public string DTLUPDATEDUSER { get; set; }

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

        public decimal? UNPOQTY { get; set; }

        [StringLength(100)]
        public string DEPTNAME { get; set; }
    }
}
