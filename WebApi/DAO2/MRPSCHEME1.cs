namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MRPSCHEME1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string LOCID { get; set; }
    }
}
