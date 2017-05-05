namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARCLET")]
    public partial class ARCLET
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BASETYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string BASENUM { get; set; }

        [StringLength(50)]
        public string DOCNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BASEDATE { get; set; }

        public decimal? ORIAMT { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? RATE { get; set; }

        public decimal? BASEAMT { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }
    }
}
