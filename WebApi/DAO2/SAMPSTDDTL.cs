namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAMPSTDDTL")]
    public partial class SAMPSTDDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        public decimal? LOTSIZE { get; set; }

        public decimal? SQMPQTY { get; set; }

        [StringLength(255)]
        public string FORMULA { get; set; }

        public decimal? AQQTY1 { get; set; }

        public decimal? REQTY1 { get; set; }

        public decimal? ACQTY2 { get; set; }

        public decimal? REQTY2 { get; set; }
    }
}
