namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOOKMARK")]
    public partial class BOOKMARK
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string TYPE { get; set; }

        [StringLength(20)]
        public string PREFIX { get; set; }

        [StringLength(2)]
        public string CY { get; set; }

        [StringLength(2)]
        public string CM { get; set; }

        public int? CURNUM { get; set; }

        public int? LENGTH { get; set; }

        public int? DENYINPUT { get; set; }
    }
}
