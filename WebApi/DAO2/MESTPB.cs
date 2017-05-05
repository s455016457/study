namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESTPB")]
    public partial class MESTPB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MESTPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [StringLength(30)]
        public string DEVNUM { get; set; }

        [StringLength(30)]
        public string BINNUM { get; set; }

        [Required]
        [StringLength(500)]
        public string LABELID { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(30)]
        public string SERIESNUM { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
