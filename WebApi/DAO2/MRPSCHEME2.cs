namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MRPSCHEME2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PERIODID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? INITIAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? INSTOCK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OUTSTOCK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FINAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? REQUESTS { get; set; }
    }
}
