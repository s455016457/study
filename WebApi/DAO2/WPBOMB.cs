namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WPBOMB")]
    public partial class WPBOMB
    {
        public int ID { get; set; }

        public int MASTERID { get; set; }

        public int SEQNUM { get; set; }

        [Required]
        [StringLength(100)]
        public string WORKPROCEDURE { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

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
    }
}
