namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARECDTL")]
    public partial class ARECDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ARNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BASENUM { get; set; }

        [Required]
        [StringLength(10)]
        public string BASETYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BASEDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string DOCNUM { get; set; }

        public decimal BASEAMT { get; set; }

        public decimal ORIAMT { get; set; }

        [Required]
        [StringLength(4)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }
    }
}
