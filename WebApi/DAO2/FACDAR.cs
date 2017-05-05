namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACDAR")]
    public partial class FACDAR
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PROLINEID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime FACDATE { get; set; }

        public decimal? WORKHOUR { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
