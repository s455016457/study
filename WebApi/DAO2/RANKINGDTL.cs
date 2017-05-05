namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RANKINGDTL")]
    public partial class RANKINGDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string RANKNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SEQNUM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        public decimal QTY { get; set; }

        public DateTime CREATED { get; set; }
    }
}
