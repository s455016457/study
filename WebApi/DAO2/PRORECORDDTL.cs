namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRORECORDDTL")]
    public partial class PRORECORDDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRORECNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string TEAM { get; set; }

        [Required]
        [StringLength(20)]
        public string DEVICE { get; set; }

        [Required]
        [StringLength(2)]
        public string PERDAY { get; set; }

        [Required]
        [StringLength(2)]
        public string HR { get; set; }

        [Required]
        [StringLength(2)]
        public string MU { get; set; }

        public decimal QTY { get; set; }

        public decimal PASSQTY { get; set; }

        public int? ISDISPATCH { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }
    }
}
