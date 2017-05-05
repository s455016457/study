namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OTHAPD")]
    public partial class OTHAPD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string OPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ACCNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string DESCR { get; set; }

        public decimal QTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }
    }
}
