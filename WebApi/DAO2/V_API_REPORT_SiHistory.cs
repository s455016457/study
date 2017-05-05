namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_SiHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SINUM { get; set; }

        public decimal? AMOUNT { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CURR { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [StringLength(30)]
        public string CUSPONUM { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(100)]
        public string EXPNUM { get; set; }

        public decimal? HANDLE { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        public decimal? INSURE { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(30)]
        public string MISCHRGTIT { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string PAYTERM { get; set; }

        public int? POST { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal RATE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        [StringLength(50)]
        public string SHIPVIA { get; set; }

        [StringLength(20)]
        public string SINVTYPE { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal TAXRATE { get; set; }

        public decimal? TOTALQTY { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string TRADETERM { get; set; }

        public int? VNUM { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal DTLAMOUNT { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string DTLCUSPONUM { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal CUSTOMPRICE { get; set; }

        [StringLength(30)]
        public string INVNUM { get; set; }

        public int? ISSELECTED { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool ISSOACCESSORY { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string LOT { get; set; }

        [StringLength(30)]
        public string PSNUM { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal QTY { get; set; }

        [StringLength(200)]
        public string DTLREMARK { get; set; }

        [StringLength(30)]
        public string SELECTEDUID { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SEQNUM { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(20)]
        public string DTLSONUM { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(5)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal UPRICE { get; set; }

        public decimal? SOQTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PLANDATE { get; set; }

        [StringLength(200)]
        public string CUSNAME { get; set; }

        [StringLength(20)]
        public string SHORTNAME { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(500)]
        public string SPEC { get; set; }

        [StringLength(100)]
        public string CREATEDUSERNAME { get; set; }

        [StringLength(100)]
        public string DEPTNAME { get; set; }

        [StringLength(50)]
        public string INVTYPEDESCR { get; set; }

        [StringLength(50)]
        public string SALESREPDESCR { get; set; }

        [StringLength(50)]
        public string PAYMETHODDESCR { get; set; }

        [StringLength(50)]
        public string PAYTERMDESCR { get; set; }
    }
}
