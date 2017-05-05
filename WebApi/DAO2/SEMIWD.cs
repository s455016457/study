namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEMIWD")]
    public partial class SEMIWD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SWNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal QTY { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public DateTime? CREATED { get; set; }

        public int GUAPERIOD { get; set; }

        public int ISMATCHED { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }
    }
}
