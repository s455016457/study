namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROSCH")]
    public partial class PROSCH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string WONUM { get; set; }

        [StringLength(50)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime SCHEDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string WRKPROCID { get; set; }

        [StringLength(20)]
        public string PROLINEID { get; set; }

        public decimal? QTY { get; set; }

        public int? ISMANUAL { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(50)]
        public string CREATEBY { get; set; }

        [StringLength(50)]
        public string UPDATEBY { get; set; }

        public DateTime? UPDATETIME { get; set; }
    }
}
