namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APAYDTL")]
    public partial class APAYDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string APNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BASETYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string BASENUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BASEDATE { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        public decimal ORIAMT { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal BASEAMT { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }
    }
}
