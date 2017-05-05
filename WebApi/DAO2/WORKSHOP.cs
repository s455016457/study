namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WORKSHOP")]
    public partial class WORKSHOP
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(30)]
        public string DESCR { get; set; }
    }
}
