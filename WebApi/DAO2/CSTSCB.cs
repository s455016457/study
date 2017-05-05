namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTSCB")]
    public partial class CSTSCB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CSTSCNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SCNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(200)]
        public string REMARKS { get; set; }
    }
}
