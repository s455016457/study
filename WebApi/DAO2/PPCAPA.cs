namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PPCAPA")]
    public partial class PPCAPA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WRKPROCID { get; set; }

        public decimal? CAPACITY { get; set; }

        public int? SORTBY { get; set; }
    }
}
