namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCTYPE")]
    public partial class ACCTYPE
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string DESCR { get; set; }

        public int? ISSYS { get; set; }
    }
}
