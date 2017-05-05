namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECNTEB")]
    public partial class ECNTEB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ECNTENUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ANCESTOR { get; set; }

        [Required]
        [StringLength(50)]
        public string PARTNUM1 { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM1 { get; set; }

        public decimal? QTY1 { get; set; }

        public decimal? SCPRATE1 { get; set; }

        [Required]
        [StringLength(50)]
        public string PARTNUM2 { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM2 { get; set; }

        public decimal? QTY2 { get; set; }

        public decimal? SCPRATE2 { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }
    }
}
