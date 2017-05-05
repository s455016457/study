namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_WIPDTL
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
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal SCANQTY { get; set; }
    }
}
