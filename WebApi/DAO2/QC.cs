namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QC")]
    public partial class QC
    {
        [Key]
        [StringLength(20)]
        public string QCNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string DOCNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKPROC { get; set; }

        [Required]
        [StringLength(10)]
        public string WORKSHOP { get; set; }

        [Required]
        [StringLength(10)]
        public string PROLINE { get; set; }

        [Required]
        [StringLength(20)]
        public string INSPECTOR { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        public decimal QTY { get; set; }

        public decimal CHECKQTY { get; set; }

        public decimal SAMPLEQTY { get; set; }

        public decimal DEFECTQTY { get; set; }

        [Required]
        [StringLength(10)]
        public string DEFECTHANDLING { get; set; }

        [Required]
        [StringLength(10)]
        public string HANDLING { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string QCTEAM { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}
