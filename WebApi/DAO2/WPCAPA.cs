namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WPCAPA")]
    public partial class WPCAPA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PROLINEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WORKPROCID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime SCHEDATE { get; set; }

        public decimal? TOTALHOUR { get; set; }
    }
}
