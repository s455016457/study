namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STDTL")]
    public partial class STDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string STNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string LOCIDIN { get; set; }

        public double QTY { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }
    }
}
