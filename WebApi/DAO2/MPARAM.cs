namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPARAM")]
    public partial class MPARAM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string DEFAULTEXECDEPTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DEFAULTPOPURREP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string DEFAULTSCPURREP { get; set; }
    }
}
