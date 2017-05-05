namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRACRC")]
    public partial class GRACRC
    {
        [Key]
        public int GRACRC_ID { get; set; }

        public int GRACRB_ID { get; set; }

        public int GRACRA_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string RANKSTDDTL_CODE { get; set; }

        public decimal? MIN { get; set; }

        public decimal? MAX { get; set; }

        [StringLength(10)]
        public string RANGEUOM { get; set; }

        public decimal? X1 { get; set; }

        public decimal? Y1 { get; set; }

        public decimal? X2 { get; set; }

        public decimal? Y2 { get; set; }

        public decimal? X3 { get; set; }

        public decimal? Y3 { get; set; }

        public decimal? X4 { get; set; }

        public decimal? Y4 { get; set; }

        public int SEQNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
