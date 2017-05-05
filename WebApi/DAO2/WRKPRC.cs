namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WRKPRC")]
    public partial class WRKPRC
    {
        [Key]
        [StringLength(20)]
        public string WRKPROCID { get; set; }

        [StringLength(100)]
        public string WRKPROCNAME { get; set; }

        public int? WRKPROCTYPE { get; set; }

        public decimal? LOADRATE { get; set; }

        public decimal? FIXEDHOUR { get; set; }
    }
}
