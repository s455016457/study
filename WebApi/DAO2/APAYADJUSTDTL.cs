namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APAYADJUSTDTL")]
    public partial class APAYADJUSTDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string AANUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ACCNUM { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCR { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [StringLength(20)]
        public string DEPARTMENT { get; set; }

        [StringLength(20)]
        public string CATEGORY { get; set; }
    }
}
