namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UNSCWA")]
    public partial class UNSCWA
    {
        [Key]
        [StringLength(50)]
        public string WONUM { get; set; }

        [StringLength(50)]
        public string SONUM { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string PROLINEID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? WODATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DELIVEYDATE { get; set; }

        public decimal? WOQTY { get; set; }

        public decimal? SCHEDQTY { get; set; }

        public decimal? WIPQTY { get; set; }

        public decimal? NONESCHEQTY { get; set; }

        public decimal? QTY { get; set; }

        public int? PRIORITY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRESCHDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PLANBEGDATE { get; set; }

        public int? UNLIMITED { get; set; }

        public int? SELECTED { get; set; }
    }
}
