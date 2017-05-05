namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AVLSALESREJECT")]
    public partial class AVLSALESREJECT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal UPRICE { get; set; }

        public decimal? AVLQTY { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(5)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime SIDATE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smalldatetime")]
        public DateTime SODATE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal SIQTY { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal REJEDQTY { get; set; }
    }
}
