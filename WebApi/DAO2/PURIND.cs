namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURIND")]
    public partial class PURIND
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BASETYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string BASENUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string REFDOC { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string REFLOT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BASEDATE { get; set; }

        public decimal? ORIAMT { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? RATE { get; set; }

        public decimal? BASEAMT { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(1000)]
        public string REFINFO { get; set; }
    }
}
