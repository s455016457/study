namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SO")]
    public partial class SO
    {
        [Key]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Required]
        [StringLength(20)]
        public string SOTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(30)]
        public string PONUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal? TAXRATE { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Required]
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

        [Required]
        [StringLength(20)]
        public string SALESREGION { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        public int? CLOSED { get; set; }

        public int? CANCELED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

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

        [StringLength(20)]
        public string ORDERLEVEL { get; set; }

        public virtual PAYMETHOD PAYMETHOD1 { get; set; }

        public virtual SALESREGION SALESREGION1 { get; set; }
    }
}
