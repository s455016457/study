namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_PO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string POTYPE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string VENID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CURR { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal RATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TAXRATE { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

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
        public string SHIPTO { get; set; }

        [StringLength(200)]
        public string SHIPMARK { get; set; }

        [StringLength(20)]
        public string VIA { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? CLOSED { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        [StringLength(30)]
        public string DEPTID { get; set; }

        [StringLength(1000)]
        public string COMMENTS { get; set; }

        public decimal? INSURE { get; set; }

        public decimal? HANDLE { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(200)]
        public string MISCHRGTIT { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        public decimal? TOTALQTY { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EXECSTATE { get; set; }

        public DateTime? EXECSTATEUPDATEDSTAMP { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(6)]
        public string CLOSEDDESCR { get; set; }

        [StringLength(20)]
        public string PRNUM { get; set; }

        public decimal? DTLAMOUNT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DTLCLOSEDDATE { get; set; }

        public DateTime? DTLCREATED { get; set; }

        [StringLength(20)]
        public string DTLCREATEDBY { get; set; }

        public decimal? EXQTY { get; set; }

        public decimal? EXTEXPENSE { get; set; }

        public decimal? EXTUPRICE { get; set; }

        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal? GRNQTY { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(50)]
        public string LOT { get; set; }

        public decimal? QTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECVDATE { get; set; }

        public decimal? REJECTQTY { get; set; }

        [StringLength(500)]
        public string DTLREMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REPLYRECVDATE { get; set; }

        public int? DTLSTATUS { get; set; }

        [StringLength(200)]
        public string SUITENAME { get; set; }

        [StringLength(50)]
        public string SUITENUM { get; set; }

        public decimal? SUITEQTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? UPRICE { get; set; }

        [StringLength(50)]
        public string VENITEMNUM { get; set; }

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

        [StringLength(50)]
        public string POTYPEDESCR { get; set; }

        [StringLength(100)]
        public string VENNAME { get; set; }

        [StringLength(50)]
        public string SHORTNAME { get; set; }

        [StringLength(50)]
        public string BUYERDESCR { get; set; }

        public decimal? UNGRNQTY { get; set; }

        [StringLength(100)]
        public string DEPTNAME { get; set; }
    }
}
