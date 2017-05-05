namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUOTATION")]
    public partial class QUOTATION
    {
        [Key]
        [StringLength(20)]
        public string QTNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime QTDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal TAXRATE { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(20)]
        public string REV { get; set; }

        [Required]
        [StringLength(20)]
        public string SALESREGION { get; set; }

        [Required]
        [StringLength(20)]
        public string SALESREP { get; set; }

        [StringLength(20)]
        public string SHIPVIA { get; set; }

        [StringLength(100)]
        public string SHIPTO { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(30)]
        public string INVTYPE { get; set; }

        public decimal? TOTALAMOUNT { get; set; }

        public decimal? INSURE { get; set; }

        public decimal? HANDLE { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(200)]
        public string MISCHRGTIT { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        [StringLength(200)]
        public string BANKNAME { get; set; }

        [StringLength(50)]
        public string ACCOUNTNUM { get; set; }

        [StringLength(200)]
        public string ACCOUNTNAME { get; set; }

        [StringLength(30)]
        public string SONUM { get; set; }

        public int? ISGENSO { get; set; }

        public int? FSTATUS { get; set; }

        [StringLength(20)]
        public string SOTYPE { get; set; }

        [StringLength(100)]
        public string QUTYPE { get; set; }

        [StringLength(100)]
        public string CUSPONUM { get; set; }
    }
}
