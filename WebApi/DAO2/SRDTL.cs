namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SRDTL")]
    public partial class SRDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SRNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string LOT { get; set; }

        public decimal REJECT { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? REJECTEDQTY { get; set; }

        [StringLength(30)]
        public string CUSPONUM { get; set; }

        [StringLength(30)]
        public string PSNUM { get; set; }

        public bool ISSOACCESSORY { get; set; }

        public bool ISREPLENISH { get; set; }

        public decimal REPLENISHQTY { get; set; }
    }
}
