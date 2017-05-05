namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WIPDTL2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WIPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string SEQNUM { get; set; }

        public decimal QTY { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CREATED { get; set; }

        public int GUAPERIOD { get; set; }

        public int ISMATCHED { get; set; }
    }
}
