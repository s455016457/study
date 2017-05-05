namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APREQB")]
    public partial class APREQB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string AQNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BASETYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string DOCNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string ODNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DOCDATE { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARKS { get; set; }
    }
}
