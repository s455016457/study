namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OTHEND")]
    public partial class OTHEND
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string OENUM { get; set; }

        [Required]
        [StringLength(20)]
        public string MINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOCID { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }
    }
}
