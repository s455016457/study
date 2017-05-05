namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURIEN")]
    public partial class PURIEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal BASEAMOUNT { get; set; }

        public DateTime? CREATED { get; set; }
    }
}
