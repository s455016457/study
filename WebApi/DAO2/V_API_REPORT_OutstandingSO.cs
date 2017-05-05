namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_OutstandingSO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SOTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(30)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string CURR { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal RATE { get; set; }

        public decimal? TAXRATE { get; set; }

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
        public string SHIPMARK { get; set; }

        [StringLength(10)]
        public string VIA { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string SOLDTO { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        [StringLength(200)]
        public string BILLTO { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string SALESREGION { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        public int? CLOSED { get; set; }

        public int? CANCELED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(30)]
        public string SOINVTYPE { get; set; }

        public decimal? INSURE { get; set; }

        public decimal? HANDLE { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(200)]
        public string MISCHRGTIT { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        public decimal? TOTALAMOUNT { get; set; }

        [StringLength(200)]
        public string BANKNAME { get; set; }

        [StringLength(50)]
        public string ACCOUNTNUM { get; set; }

        [StringLength(200)]
        public string ACCOUNTNAME { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        public decimal? TOTALQTY { get; set; }

        public int? PRNCOUNT { get; set; }

        [StringLength(30)]
        public string QTNUM { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        public DateTime? CREATED { get; set; }

        public decimal? CTMAX { get; set; }

        public decimal? CTMIN { get; set; }

        [StringLength(50)]
        public string CUSITEMNUM { get; set; }

        public decimal? FLUXMAX { get; set; }

        public decimal? FLUXMIN { get; set; }

        public decimal? FUTUREYIELD { get; set; }

        public int? ISGIFT { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal? IVAMAX { get; set; }

        public decimal? IVAMIN { get; set; }

        public decimal? IVBMAX { get; set; }

        public decimal? IVBMIN { get; set; }

        public decimal? IVCMAX { get; set; }

        public decimal? IVCMIN { get; set; }

        [StringLength(500)]
        public string LABELNUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PLANDATE { get; set; }

        [StringLength(10)]
        public string POS1 { get; set; }

        [StringLength(10)]
        public string POS2 { get; set; }

        public decimal? QTY { get; set; }

        public decimal? REJECTQTY { get; set; }

        [StringLength(200)]
        public string DTLREMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SHIPDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SHIPDATE2 { get; set; }

        public decimal? SIQTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? VFAMAX { get; set; }

        public decimal? VFAMIN { get; set; }

        public decimal? VFBMAX { get; set; }

        public decimal? VFBMIN { get; set; }

        public decimal? VFCMAX { get; set; }

        public decimal? VFCMIN { get; set; }

        public decimal? WDAMAX { get; set; }

        public decimal? WDAMIN { get; set; }

        public decimal? WDBMAX { get; set; }

        public decimal? WDBMIN { get; set; }

        public decimal? WDCMAX { get; set; }

        public decimal? WDCMIN { get; set; }

        public decimal? WOQTY { get; set; }

        public int? DTLSTATUS { get; set; }

        public decimal? UNSIQTY { get; set; }

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
        public string SOTYPEDESCR { get; set; }

        [StringLength(200)]
        public string CUSNAME { get; set; }

        [StringLength(200)]
        public string CUSNAME2 { get; set; }

        [StringLength(20)]
        public string SHORTNAME { get; set; }

        [StringLength(50)]
        public string PAYTERMDESCR { get; set; }

        [StringLength(50)]
        public string PAYMETHODDESCR { get; set; }

        [StringLength(50)]
        public string TRADETERMDESCR { get; set; }

        [StringLength(50)]
        public string SALESPERDESCR { get; set; }

        [StringLength(50)]
        public string SALESREGIONDESCR { get; set; }

        [StringLength(50)]
        public string SOINVTYPEDESCR { get; set; }
    }
}
