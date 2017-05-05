namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OTHARA")]
    public partial class OTHARA
    {
        [Key]
        [StringLength(20)]
        public string ORNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOCDATE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string PRJCODE { get; set; }

        public decimal AMOUNT { get; set; }

        public int POST { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public int? VNUM { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }
    }
}
