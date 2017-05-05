namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AREC")]
    public partial class AREC
    {
        [Key]
        [StringLength(20)]
        public string ARNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(20)]
        public string RECACC { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CHK { get; set; }

        [Required]
        [StringLength(20)]
        public string CHKACC { get; set; }

        [Required]
        [StringLength(10)]
        public string PAYMETHOD { get; set; }

        public decimal ORIAMT { get; set; }

        public decimal BASEAMT { get; set; }

        public int DEPOSIT { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [StringLength(20)]
        public string PRJNUM { get; set; }

        [Required]
        [StringLength(200)]
        public string REMARK { get; set; }

        public int POST { get; set; }

        public int? VNUM { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
