namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_QUERYSEQNUM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string RANKNUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string SEQNUM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal QTY { get; set; }
    }
}
