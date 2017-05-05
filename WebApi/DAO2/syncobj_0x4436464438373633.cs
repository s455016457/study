namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syncobj_0x4436464438373633
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DESCR { get; set; }

        [StringLength(2)]
        public string ATTRIB { get; set; }
    }
}
