namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIDTL")]
    public partial class MIDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? ISSUEDQTY { get; set; }

        public decimal? DOSAGE { get; set; }

        public decimal? SCPRATE { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public decimal? FREJECTEDQTY { get; set; }

        public int? ISREP { get; set; }

        [StringLength(50)]
        public string MASTERITEMNUM { get; set; }

        public int? SEQNUM { get; set; }

        public decimal? REPRATE { get; set; }
    }
}
