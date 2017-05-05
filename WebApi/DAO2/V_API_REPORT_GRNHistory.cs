namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_GRNHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(20)]
        public string YOURREF { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? POST { get; set; }

        public int? COMPLETED { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(2)]
        public string GTYPE { get; set; }

        [StringLength(2)]
        public string DTYPE { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public int? VNUM { get; set; }

        [StringLength(30)]
        public string GRNACC { get; set; }

        public DateTime? CHECKEDSTAMP { get; set; }

        [StringLength(20)]
        public string CHECKEDUSER { get; set; }

        public int? ISCHECKED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        public DateTime? DTLCREATED { get; set; }

        [StringLength(20)]
        public string POLOT { get; set; }

        [StringLength(20)]
        public string LOCID { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(500)]
        public string DTLREMARK { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECVDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REPLYRECVDATE { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

        [StringLength(50)]
        public string BUYERNAME { get; set; }

        [StringLength(50)]
        public string WAREHOUSEDESCR { get; set; }

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

        [StringLength(100)]
        public string VENNAME { get; set; }

        [StringLength(50)]
        public string SHORTNAME { get; set; }
    }
}
