namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_UNSETGRNFORPI_BAK
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string BASETYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        public decimal? RATE { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? BASEAMOUNT { get; set; }

        public decimal? BASEBAL { get; set; }

        public decimal? BAL { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string VENNAME { get; set; }
    }
}
