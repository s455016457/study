namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINV")]
    public partial class SINV
    {
        [Key]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal TAXRATE { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        [Required]
        [StringLength(10)]
        public string TRADETERM { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(50)]
        public string SHIPVIA { get; set; }

        public decimal? INSURE { get; set; }

        public decimal? HANDLE { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(30)]
        public string MISCHRGTIT { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public int? POST { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public int? VNUM { get; set; }

        [StringLength(20)]
        public string SINVTYPE { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        public decimal? TOTALQTY { get; set; }

        [StringLength(100)]
        public string EXPNUM { get; set; }

        [StringLength(30)]
        public string CUSPONUM { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SEQNUM { get; set; }
    }
}
