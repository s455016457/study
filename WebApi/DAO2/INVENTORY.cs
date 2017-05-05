namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTORY")]
    public partial class INVENTORY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 3)]
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
        public string LABELID { get; set; }

        [Required]
        [StringLength(2)]
        public string STATUS { get; set; }

        public DateTime UPDATESTAMP { get; set; }

        [StringLength(500)]
        public string INVREMARK { get; set; }

        [StringLength(50)]
        public string LOCATION { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }
    }
}
