namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROINB")]
    public partial class PROINB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PROINNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }
    }
}
