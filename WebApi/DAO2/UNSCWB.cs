namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UNSCWB")]
    public partial class UNSCWB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string WONUM { get; set; }

        [StringLength(20)]
        public string PROLINEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WRKPROCID { get; set; }

        public int? SORTBY { get; set; }
    }
}
