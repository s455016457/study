namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPMIPLANB")]
    public partial class MRPMIPLANB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public int SEQNUM { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? DOSAGE { get; set; }

        public decimal? SCPRATE { get; set; }

        public bool ISREP { get; set; }

        [StringLength(50)]
        public string MASTERITEMNUM { get; set; }

        public decimal? REPRATE { get; set; }
    }
}
