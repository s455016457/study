namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APRFND")]
    public partial class APRFND
    {
        [Key]
        [StringLength(20)]
        public string PRNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [Required]
        [StringLength(100)]
        public string PAYEE { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYACC { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CHK { get; set; }

        [Required]
        [StringLength(20)]
        public string CHKACC { get; set; }

        [Required]
        [StringLength(100)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        public decimal ORIAMT { get; set; }

        public decimal BASEAMT { get; set; }

        public int DEPOSIT { get; set; }

        public int POST { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public int? VNUM { get; set; }
    }
}
