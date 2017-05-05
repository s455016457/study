namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IQC")]
    public partial class IQC
    {
        [Key]
        [StringLength(20)]
        public string IQCNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string DOCNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string INSPECTOR { get; set; }

        [Required]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string LOT { get; set; }

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

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        [StringLength(30)]
        public string SINUM { get; set; }

        public decimal? SIQTY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}
