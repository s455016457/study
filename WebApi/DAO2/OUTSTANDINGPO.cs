namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OUTSTANDINGPO")]
    public partial class OUTSTANDINGPO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string VENID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(10)]
        public string POTYPE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal? EXRATE { get; set; }

        public decimal? UPRICE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal POQTY { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal RECQTY { get; set; }

        public decimal? OUTQTY { get; set; }

        [StringLength(100)]
        public string ITEMDESCR { get; set; }

        [StringLength(100)]
        public string SPEC { get; set; }
    }
}
