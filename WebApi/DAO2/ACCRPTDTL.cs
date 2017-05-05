namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCRPTDTL")]
    public partial class ACCRPTDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ACC { get; set; }

        public int SEQ { get; set; }
    }
}
