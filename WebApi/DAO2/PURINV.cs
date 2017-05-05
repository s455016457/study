namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURINV")]
    public partial class PURINV
    {
        [Key]
        [StringLength(20)]
        public string PINUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string INVNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? INVDATE { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal AMT { get; set; }

        public decimal BASEAMT { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public int APPROVE { get; set; }

        public DateTime? APPROVED { get; set; }

        [StringLength(20)]
        public string APPROVEDBY { get; set; }

        public int? VNUM { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public decimal? SELECTEDBASEAMT { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

        public int? ISRECONCILED { get; set; }

        [StringLength(30)]
        public string RECINVNUM { get; set; }

        public decimal? TAXAMOUNT { get; set; }
    }
}
