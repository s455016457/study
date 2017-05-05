namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_SINVDTL2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string SOLOT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal SCANQTY { get; set; }
    }
}
