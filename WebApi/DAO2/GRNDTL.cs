namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRNDTL")]
    public partial class GRNDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string POLOT { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(2)]
        public string GTYPE { get; set; }

        [StringLength(30)]
        public string INVACCNUM { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        public int TOTALBOXNUMBER { get; set; }
    }
}
