namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MYJOB")]
    public partial class MYJOB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MID { get; set; }

        public int ORD { get; set; }
    }
}
