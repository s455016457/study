namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVOICEREQUESTDTL")]
    public partial class INVOICEREQUESTDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string IRNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SIDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
