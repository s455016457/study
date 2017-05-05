namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QCTEAM")]
    public partial class QCTEAM
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string DESCR { get; set; }
    }
}
