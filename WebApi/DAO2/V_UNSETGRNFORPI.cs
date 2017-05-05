namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_UNSETGRNFORPI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string BASETYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string VENID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal? QTY { get; set; }

        public decimal? UPRICE { get; set; }

        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal? ORIAMT { get; set; }

        public decimal? BASEAMT { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? RATE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? BASEBAL { get; set; }

        public decimal? BAL { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string VENNAME { get; set; }

        [StringLength(500)]
        public string REFINFO { get; set; }
    }
}
