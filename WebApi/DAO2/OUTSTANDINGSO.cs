namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OUTSTANDINGSO")]
    public partial class OUTSTANDINGSO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [StringLength(30)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(50)]
        public string CUSITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal UPRICE { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal SOQTY { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal SIQTY { get; set; }

        public decimal? OUTQTY { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smalldatetime")]
        public DateTime SHIPDATE { get; set; }

        [StringLength(243)]
        public string REMARK { get; set; }

        [StringLength(43)]
        public string LABELID { get; set; }
    }
}
