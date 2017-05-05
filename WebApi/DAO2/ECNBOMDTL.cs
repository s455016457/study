namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECNBOMDTL")]
    public partial class ECNBOMDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ANCESTOR { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ECNNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public int SEQNUM { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal SCPRATE { get; set; }

        public int ISKEY { get; set; }

        public int ISREP { get; set; }

        [StringLength(50)]
        public string MASTERITEMNUM { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string EXTRA1 { get; set; }

        [StringLength(100)]
        public string EXTRA2 { get; set; }

        public decimal? REPRATE { get; set; }

        [StringLength(70)]
        public string ECNBOMNUM { get; set; }
    }
}
