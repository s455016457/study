namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WHPLNE")]
    public partial class WHPLNE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WAREHOUSE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PROLINE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}
