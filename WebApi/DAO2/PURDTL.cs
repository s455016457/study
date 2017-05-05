namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURDTL")]
    public partial class PURDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PURNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string POLOT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal REJECT { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        [StringLength(20)]
        public string PURAPNUM { get; set; }
    }
}
