namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_ACCGRN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string POLOT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [StringLength(100)]
        public string ITEMDESCR { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string LOCID { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }
    }
}
