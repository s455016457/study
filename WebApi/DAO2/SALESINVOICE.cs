namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALESINVOICE")]
    public partial class SALESINVOICE
    {
        [Key]
        [StringLength(20)]
        public string SINVNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(30)]
        public string INVNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime INVDATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal BASEAMOUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string APPROVEDBY { get; set; }

        public DateTime? APPROVEDSTAMP { get; set; }

        public int POST { get; set; }

        public int? VNUM { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public int? ISRECONCILED { get; set; }

        [StringLength(30)]
        public string RECINVNUM { get; set; }

        [StringLength(20)]
        public string SSTATNUM { get; set; }

        public int ISTAXINV { get; set; }

        public decimal? TAXAMOUNT { get; set; }
    }
}
