namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RANKSTDDTL")]
    public partial class RANKSTDDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string RANKCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string RANKTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CODE { get; set; }

        public decimal? RANGE1 { get; set; }

        public decimal? RANGE2 { get; set; }

        [StringLength(10)]
        public string RANGEUOM { get; set; }

        public decimal? POS1X { get; set; }

        public decimal? POS1Y { get; set; }

        public decimal? POS2X { get; set; }

        public decimal? POS2Y { get; set; }

        public decimal? POS3X { get; set; }

        public decimal? POS3Y { get; set; }

        public decimal? POS4X { get; set; }

        public decimal? POS4Y { get; set; }
    }
}
