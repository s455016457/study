namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIBKFH")]
    public partial class MIBKFH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MINUM { get; set; }

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
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string WIPNUM { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string WOITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [StringLength(20)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }
    }
}
