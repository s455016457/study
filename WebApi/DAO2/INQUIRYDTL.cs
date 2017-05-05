namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INQUIRYDTL")]
    public partial class INQUIRYDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ISNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(50)]
        public string VENITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? UPRICE { get; set; }

        public int? LEADTIME { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
