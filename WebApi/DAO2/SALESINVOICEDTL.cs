namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALESINVOICEDTL")]
    public partial class SALESINVOICEDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SINVNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal BASEAMOUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string DOCTYPE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SEQNUM { get; set; }
    }
}
